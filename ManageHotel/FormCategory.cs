using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace ManageHotel
{
    public partial class fRoomCategories : Form
    {
        #region Initilization
        public static ManageHotelEntities entities = new ManageHotelEntities(); //tạo biến entites để truy vấn
        private BindingSource source = new BindingSource(); //tạo source cho kỹ thuật DataBinding

        public static int nRoomKind;    //số loại phòng
        public static int nCustomerKind;    //số loại khách hàng
        public static int maximumCustomer;  //số khách hàng tối đa trong một phòng
        public static float surchargeRatio; //tỷ lệ phụ thu
        public static int surchargeBeginning;   //phụ thu khi lượng khách bắt đầu là
        public static Dictionary<string, float> kindAndPrice = new Dictionary<string, float>(); //ánh xạ giữa loại phòng và giá
        public static Dictionary<string, float> kindAndCoefficient = new Dictionary<string, float>();   //ánh xạ giữa loại khách hàng và hệ số
        #endregion

        public fRoomCategories()
        {
            InitializeComponent();
            LoadRules();        //tải các quy định vào
            RefreshData();      //làm mới dữ liệu
            AddBinding();       //tạo DataBinding
        }

        private void LoadRules()
        {
            //Tải những quy định từ DB lên các biến public để sử dụng chung cho tất cả các form
            Rule rule = entities.Rules.FirstOrDefault();

            nRoomKind = rule.nRoomKind;
            nCustomerKind = rule.nCustomerKind;
            maximumCustomer = rule.maximumCustomer;
            surchargeRatio = (float)rule.surchargeRatio;
            surchargeBeginning = rule.surchargeBeginning;

            //tokenize chuỗi từ DB để thêm vào ánh xạ giữa phòng và giá
            string[] strRoomKind = rule.roomKindPrice.Split(new[] { Environment.NewLine }, StringSplitOptions.None);
            for (int i = 0; i < nRoomKind; i++)
            {
                string[] singleKind = strRoomKind[i].Split(',');
                kindAndPrice.Add(singleKind[0], float.Parse(singleKind[1]));
            }
            //tokenize chuỗi từ DB để thêm vào ánh xạ giữa khách hàng và hệ số
            string[] strCustomerKind = rule.customerKindCoefficient.Split(new[] { Environment.NewLine }, StringSplitOptions.None);
            for (int i = 0; i < nCustomerKind; i++)
            {
                string[] singleKind = strCustomerKind[i].Split(',');
                kindAndCoefficient.Add(singleKind[0], float.Parse(singleKind[1]));
            }
            cbRoomKind.DataSource = kindAndPrice.Keys.ToList();
        }

        private void RefreshData()  //hàm làm mới dữ liệu
        {
            //thực hiện việc đánh số cho mẫu dữ liệu được tải ra (ở đây sử dụng ordinalNumber như một biến tạm)
            List<string> name = entities.RoomCategories.Select(p => p.name).ToList();
            for (int i = 0; i < name.Count; i++)
            {
                RoomCategory room = entities.RoomCategories.Find(name[i]);
                room.ordinalNumber = i + 1;
            }
            entities.SaveChanges();

            //truy vấn những trường cần thiết, đổ vào DataGridView
            var ambiguosData = (from p in entities.RoomCategories
                        orderby p.id ascending
                        select new { p.ordinalNumber, p.name, p.kind, p.price, p.note }).ToList();

            source.DataSource = ambiguosData;
            dgvRoomCategories.DataSource = source;

            //đặt tên cho tiêu đề của các cột
            dgvRoomCategories.Columns[0].HeaderText = "Số thứ tự";
            dgvRoomCategories.Columns[1].HeaderText = "Tên phòng";
            dgvRoomCategories.Columns[2].HeaderText = "Loại phòng";
            dgvRoomCategories.Columns[3].HeaderText = "Giá";
            dgvRoomCategories.Columns[4].HeaderText = "Ghi chú";
        }

        private void AddBinding()   //hàm tạo DataBinding
        {
            txtRoomName.DataBindings.Add(new Binding("Text", dgvRoomCategories.DataSource, "name", true, DataSourceUpdateMode.Never));
            cbRoomKind.DataBindings.Add(new Binding("Text", dgvRoomCategories.DataSource, "kind", true, DataSourceUpdateMode.Never));
            txtRoomPrice.DataBindings.Add(new Binding("Text", dgvRoomCategories.DataSource, "price", true, DataSourceUpdateMode.Never));
            txtNote.DataBindings.Add(new Binding("Text", dgvRoomCategories.DataSource, "note", true, DataSourceUpdateMode.Never));
        }

        #region Functions for event
        private void AddRoom()
        {
            if (txtRoomName.Text == "") //tên phòng rỗng
            {
                MessageBox.Show("Vui lòng nhập tên phòng", "Tên phòng rỗng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //tạo một thể hiện mới cho đối tượng RoomCategory
            RoomCategory roomCategory = new RoomCategory()
            {
                name = txtRoomName.Text,
                kind = cbRoomKind.SelectedItem.ToString(),
                price = Convert.ToDouble(txtRoomPrice.Text),
                note = txtNote.Text,
                roomStatus = "Trống",
                countRented = 0,
                rentedDay = null,
                total = 0
            };
            //xử lý trường hợp tên phòng hiện tại có tồn tại hay chưa
            List<string> roomName = entities.RoomCategories.Select(p => p.name).ToList();
            if (!roomName.Contains(roomCategory.name))
            {
                entities.RoomCategories.Add(roomCategory);
                entities.SaveChanges();
            }
            else
                MessageBox.Show("Vui lòng chọn một tên phòng khác", "Tên đã tồn tại", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void DeleteRoom()
        {
            int countRoom = entities.RoomCategories.Count();    //đếm số phòng
            if (int.Parse(countRoom.ToString()) != 0)   //số phòng bằng 0 thì không có gì để xóa
            {
                RoomCategory roomCategory = entities.RoomCategories.Where(p => p.name == txtRoomName.Text).SingleOrDefault();
                if (entities.Customers.Where(p => p.roomName == roomCategory.name).ToList().Count == 0) //nếu phòng đang được thuê thì ai cho xóa
                {
                    entities.RoomCategories.Remove(roomCategory);
                    entities.SaveChanges();
                }
                else
                    MessageBox.Show("Phòng này đang trong tình trạng được thuê.\n" +
                        "Để xóa vui lòng thanh toán phòng trước!", "Không thể xóa", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
                MessageBox.Show("Không thể xóa", "Hết dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void EditRoom()
        {
            if (txtRoomName.Text == "") //tên phòng rỗng
            {
                MessageBox.Show("Vui lòng nhập tên phòng", "Tên phòng rỗng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string name = dgvRoomCategories.SelectedCells[0].OwningRow.Cells["name"].Value.ToString();
            RoomCategory roomCategory = entities.RoomCategories.Find(name);
            if (entities.Customers.Where(p => p.roomName == roomCategory.name).ToList().Count == 0) //nếu phòng đang được thuê thì ai cho sửa
            {
                roomCategory.name = txtRoomName.Text;
                roomCategory.kind = cbRoomKind.SelectedItem.ToString();
                roomCategory.price = Convert.ToInt32(txtRoomPrice.Text);
                roomCategory.note = txtNote.Text;
                entities.SaveChanges();
            }
            else
                MessageBox.Show("Phòng này đang trong tình trạng được thuê.\n" +
                        "Để sửa vui lòng thanh toán phòng trước!", "Không thể sửa", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        #endregion

        #region Events
        private void btnAdd_Click(object sender, EventArgs e)   //sự kiện thêm
        {
            AddRoom();
            RefreshData();
        }

        private void btnDelete_Click(object sender, EventArgs e)    //sự kiện xóa
        {
            DeleteRoom();
            RefreshData();
        }

        private void btnEdit_Click(object sender, EventArgs e)  //sự kiện sửa
        {
            EditRoom();
            RefreshData();
        }

        private void cbRoomKind_SelectedValueChanged(object sender, EventArgs e)    //sự kiện thay đổi comboBox
        {
            txtRoomPrice.Text = kindAndPrice[cbRoomKind.SelectedItem.ToString()].ToString();
        }

        private void btnCheckStatus_Click(object sender, EventArgs e)   //sự kiện qua form danh sách phòng
        {
            fRoomList form = new fRoomList();
            Hide();
            form.ShowDialog();
            Show();
        }

        private void tsmiRules_Click(object sender, EventArgs e)    //sự kiện qua form quy định
        {
            FormRules form = new FormRules();
            form.ShowDialog();
        }

        private void tsmiStatistic_Click(object sender, EventArgs e)    //sự kiện qua form báo cáo
        {
            FormReport form = new FormReport();
            form.ShowDialog();
        }

        private void tsmiExit_Click(object sender, EventArgs e) //sự kiện thoát chương trình
        {
            Application.Exit();
        }
        #endregion
    }
}
