using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace ManageHotel
{
    public partial class fCustomer : Form
    {
        #region Initialization
        private ManageHotelEntities entities = fRoomCategories.entities;
        private BindingSource source = new BindingSource();
        #endregion

        public fCustomer()
        {
            InitializeComponent();
            LoadRules();

            List<string> roomName = entities.RoomCategories.Select(p => p.name).ToList();
            if (roomName.Count != 0)
            {
                cbRoom.DataSource = roomName;   //truy vấn và đổ tên phòng vào comboBox
                RefreshData();
                AddBinding();
            }
        }

        private void LoadRules()    //tải quy định cho form này
        {
            cbCustomerKind.DataSource = fRoomCategories.kindAndCoefficient.Keys.ToList();
        }

        private void AddBinding()
        {
            txtCustomerName.DataBindings.Add(new Binding("Text", dgvTicket.DataSource, "name", true, DataSourceUpdateMode.Never));
            cbCustomerKind.DataBindings.Add(new Binding("Text", dgvTicket.DataSource, "kind", true, DataSourceUpdateMode.Never));
            txtIdentity.DataBindings.Add(new Binding("Text", dgvTicket.DataSource, "identityNumber", true, DataSourceUpdateMode.Never));
            txtAddress.DataBindings.Add(new Binding("Text", dgvTicket.DataSource, "address", true, DataSourceUpdateMode.Never));
        }

        private void RefreshData()  //làm mới dữ liệu
        {
            //trường hợp vào form tính tiền, trở ngược ra form khách hàng
            if (cbRoom.DataSource == null)
                return;
            //thực hiện việc đánh số cho mẫu dữ liệu được tải ra (ở đây sử dụng ordinalNumber như một biến tạm)
            List<int> id = entities.Customers.Where(p => p.roomName == cbRoom.SelectedValue.ToString()).Select(p => p.id).ToList();
            for (int i = 0; i < id.Count; i++)
            {
                Customer customer = entities.Customers.Find(id[i]);
                customer.ordinalNumber = i + 1;
            }
            entities.SaveChanges();

            //truy vấn những trường cần thiết, đổ vào DataGridView
            var ambiguosData = (from p in entities.Customers.AsEnumerable()
                        where p.roomName == cbRoom.SelectedValue.ToString()
                        orderby p.ordinalNumber ascending
                        select new { p.ordinalNumber, p.name, p.kind, p.identityNumber, p.address }).ToList();

            source.DataSource = ambiguosData;
            dgvTicket.DataSource = source;

            //đặt tên cho tiêu đề của các cột
            dgvTicket.Columns[0].HeaderText = "Số thứ tự";
            dgvTicket.Columns[1].HeaderText = "Tên khách";
            dgvTicket.Columns[2].HeaderText = "Loại khách";
            dgvTicket.Columns[3].HeaderText = "Số căn cước";
            dgvTicket.Columns[4].HeaderText = "Địa chỉ";
        }

        #region Functions for event
        private void AddCustomer()  //thêm khách hàng vào phòng (cho thuê)
        {
            //ràng buộc các trường dữ liệu phía dưới không được là null, ký tự trắng hay rỗng
            if (string.IsNullOrEmpty(txtCustomerName.Text) || string.IsNullOrWhiteSpace(txtCustomerName.Text)
            || string.IsNullOrEmpty(txtIdentity.Text) || string.IsNullOrWhiteSpace(txtIdentity.Text)
            || string.IsNullOrEmpty(txtAddress.Text) || string.IsNullOrWhiteSpace(txtAddress.Text)
            || string.IsNullOrEmpty(cbCustomerKind.SelectedValue.ToString()))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Không thể thêm", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {   //ràng buộc phòng đã đầy (biến số người tối đa trong phòng được lấy từ form Danh mục)
                if (entities.Customers.Where(p => p.roomName == cbRoom.SelectedValue.ToString()).ToList().Count >= fRoomCategories.maximumCustomer)
                {
                    MessageBox.Show("Phòng đã đầy, vui lòng chọn phòng khác", "Không thể thêm", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {   //dắt này mới bắt đầu thuê
                    Customer customer = new Customer()
                    {
                        name = txtCustomerName.Text,
                        kind = cbCustomerKind.SelectedValue.ToString(),
                        identityNumber = txtIdentity.Text,
                        address = txtAddress.Text,
                        rentedDay = dtpRentRoom.Value,
                        roomName = cbRoom.SelectedValue.ToString()
                    };
                    entities.Customers.Add(customer);
                    //đánh đấu một số thuộc tính của phòng là đã có chủ
                    RoomCategory room = entities.RoomCategories.Where(p => p.name == customer.roomName).SingleOrDefault();
                    room.rentedDay = customer.rentedDay;
                    room.roomStatus = "Đã được thuê";
                    entities.SaveChanges();
                }
            }
        }

        private void EditCustomer() //cập nhật thông tin cho khách hàng
        {
            if (txtCustomerName.Text == "") //khi tên của khách hàng là rỗng
            {
                MessageBox.Show("Không tìm thấy thông tin hiện tại để cập nhật", "Không thể lưu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int id = int.Parse(dgvTicket.SelectedCells[0].OwningRow.Cells[0].Value.ToString());
            Customer customer = entities.Customers.Find(id);
            customer.name = txtCustomerName.Text;
            customer.kind = cbCustomerKind.SelectedItem.ToString();
            customer.identityNumber = txtIdentity.Text;
            customer.address = txtAddress.Text;
            entities.SaveChanges();
        }
        #endregion

        #region Events
        private void cbRoom_SelectedValueChanged(object sender, EventArgs e)    //sự kiện comboBox thay đổi
        {
            RefreshData();
        }

        private void btnAdd_Click(object sender, EventArgs e)   //sự kiện thêm khách hàng
        {
            AddCustomer();
            RefreshData();
        }

        private void btnEdit_Click(object sender, EventArgs e)  //sự kiện chỉnh sửa khách hàng
        {
            EditCustomer();
            RefreshData();
        }

        private void btnPay_Click(object sender, EventArgs e)   //sự kiện qua form Thanh toán
        {
            FormBill form = new FormBill();
            Hide();
            form.ShowDialog();
            Show();
            RefreshData();
        }
        #endregion
    }
}
