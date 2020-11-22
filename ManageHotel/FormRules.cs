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
    public partial class FormRules : Form
    {
        ManageHotelEntities entities = fRoomCategories.entities;

        public FormRules()
        {
            InitializeComponent();
            FetchRules();
        }

        private void FetchRules()   //hàm đổ dữ liệu vào các control trong form
        {
            Rule rule = entities.Rules.Find(1); //truy cập dòng đầu tiên của bảng Rule trong DB (2 vì đã bị sửa)
            //gán dữ liệu cho các value của các control
            nudAmountRooms.Value = rule.nRoomKind;
            txtKindAndPrice.Text = rule.roomKindPrice;
            nudAmountCustomerKinds.Value = rule.nCustomerKind;
            txtCustomerKinds.Text = rule.customerKindCoefficient;
            nudMaximumAmount.Value = rule.maximumCustomer;
            txtRatio.Text = rule.surchargeRatio.ToString();
            nudSurchargeBeginning.Value = rule.surchargeBeginning;
        }

        #region Functions for event
        private void ChangeRules()  //hàm cập nhật các quy định
        {
            Rule rule = entities.Rules.Find(1); //truy cập dòng đầu tiên của bảng Rule trong DB
            //gán các value của các control cho DB
            rule.nRoomKind = int.Parse(nudAmountRooms.Value.ToString());
            rule.roomKindPrice = txtKindAndPrice.Text;
            rule.nCustomerKind = int.Parse(nudAmountCustomerKinds.Value.ToString());
            rule.customerKindCoefficient = txtCustomerKinds.Text;
            rule.maximumCustomer = int.Parse(nudMaximumAmount.Value.ToString());
            rule.surchargeRatio = float.Parse(txtRatio.Text);
            rule.surchargeBeginning = int.Parse(nudSurchargeBeginning.Value.ToString());

            entities.SaveChanges();
        }
        #endregion

        #region Events
        private void btnSave_Click(object sender, EventArgs e)  //sự kiện cập nhật quy định
        {
            ChangeRules();
            DialogResult result = MessageBox.Show("Lưu quy định thành công. Vui lòng khởi động lại phần mềm để cập nhật.\n" +
                "Bạn có muốn thoát?", "Quy định", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
            if (result == DialogResult.Yes)
                Application.Exit();
        }
        #endregion
    }
}
