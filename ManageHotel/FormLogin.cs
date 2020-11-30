using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManageHotel
{
    public partial class fLogin : Form
    {
        ManageHotelEntities entities = fRoomCategories.entities;
        public fLogin()
        {
            InitializeComponent();
        }

        #region Functions for event
        private void ResetData()    //Hàm xóa thông tin đăng nhập mỗi khi khởi tạo form
        {
            txtAccount.Clear();     //reset dữ liệu textbox tài khoản
            txtPassword.Clear();    //reset dữ liệu textbox mật khẩu
            txtAccount.Focus();
        }

        private void Login()
        {
            Manager CurrentUser = entities.Managers.Where(p => p.account == txtAccount.Text && p.password == txtPassword.Text).SingleOrDefault();   //truy vấn ra tài khoản hiện tại
            if (CurrentUser != null)    //nếu truy vấn ra được thì đăng nhập thành công
            {
                fRoomCategories form = new fRoomCategories(CurrentUser);    //truyền người dùng hiện tại vào constructor của form danh mục
                Hide();
                form.ShowDialog();
                Show();
                ResetData();
            }   //nếu truy vấn không ra thì báo lỗi
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác!", "Không thể đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion

        #region Event
        private void btnLogin_Click(object sender, EventArgs e) //sự kiện nhấn nút đăng nhập
        {
            Login();
        }
        #endregion
    }
}
