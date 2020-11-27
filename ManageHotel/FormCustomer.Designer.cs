namespace ManageHotel
{
    partial class fCustomer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvTicket = new System.Windows.Forms.DataGridView();
            this.lblTicket = new System.Windows.Forms.Label();
            this.lblRoom = new System.Windows.Forms.Label();
            this.cbRoom = new System.Windows.Forms.ComboBox();
            this.lblRentRoom = new System.Windows.Forms.Label();
            this.dtpRentRoom = new System.Windows.Forms.DateTimePicker();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.cbCustomerKind = new System.Windows.Forms.ComboBox();
            this.lblCustomerKind = new System.Windows.Forms.Label();
            this.lblIdentity = new System.Windows.Forms.Label();
            this.txtIdentity = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnPay = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTicket)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTicket
            // 
            this.dgvTicket.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTicket.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvTicket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTicket.Location = new System.Drawing.Point(21, 279);
            this.dgvTicket.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvTicket.Name = "dgvTicket";
            this.dgvTicket.RowHeadersVisible = false;
            this.dgvTicket.Size = new System.Drawing.Size(720, 384);
            this.dgvTicket.TabIndex = 0;
            this.dgvTicket.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTicket_CellClick);
            // 
            // lblTicket
            // 
            this.lblTicket.AutoSize = true;
            this.lblTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTicket.Location = new System.Drawing.Point(291, 18);
            this.lblTicket.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTicket.Name = "lblTicket";
            this.lblTicket.Size = new System.Drawing.Size(196, 31);
            this.lblTicket.TabIndex = 2;
            this.lblTicket.Text = "THUÊ PHÒNG";
            // 
            // lblRoom
            // 
            this.lblRoom.AutoSize = true;
            this.lblRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoom.Location = new System.Drawing.Point(20, 76);
            this.lblRoom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRoom.Name = "lblRoom";
            this.lblRoom.Size = new System.Drawing.Size(56, 20);
            this.lblRoom.TabIndex = 3;
            this.lblRoom.Text = "Phòng";
            // 
            // cbRoom
            // 
            this.cbRoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRoom.FormattingEnabled = true;
            this.cbRoom.Location = new System.Drawing.Point(132, 71);
            this.cbRoom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbRoom.Name = "cbRoom";
            this.cbRoom.Size = new System.Drawing.Size(199, 28);
            this.cbRoom.TabIndex = 1;
            this.cbRoom.SelectedValueChanged += new System.EventHandler(this.cbRoom_SelectedValueChanged);
            // 
            // lblRentRoom
            // 
            this.lblRentRoom.AutoSize = true;
            this.lblRentRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRentRoom.Location = new System.Drawing.Point(343, 76);
            this.lblRentRoom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRentRoom.Name = "lblRentRoom";
            this.lblRentRoom.Size = new System.Drawing.Size(84, 20);
            this.lblRentRoom.TabIndex = 5;
            this.lblRentRoom.Text = "Ngày thuê";
            // 
            // dtpRentRoom
            // 
            this.dtpRentRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpRentRoom.Location = new System.Drawing.Point(439, 73);
            this.dtpRentRoom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpRentRoom.Name = "dtpRentRoom";
            this.dtpRentRoom.Size = new System.Drawing.Size(301, 26);
            this.dtpRentRoom.TabIndex = 6;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerName.Location = new System.Drawing.Point(132, 113);
            this.txtCustomerName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(199, 26);
            this.txtCustomerName.TabIndex = 2;
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerName.Location = new System.Drawing.Point(20, 118);
            this.lblCustomerName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(97, 20);
            this.lblCustomerName.TabIndex = 8;
            this.lblCustomerName.Text = "Khách hàng";
            // 
            // cbCustomerKind
            // 
            this.cbCustomerKind.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCustomerKind.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCustomerKind.FormattingEnabled = true;
            this.cbCustomerKind.Location = new System.Drawing.Point(132, 155);
            this.cbCustomerKind.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbCustomerKind.Name = "cbCustomerKind";
            this.cbCustomerKind.Size = new System.Drawing.Size(199, 28);
            this.cbCustomerKind.TabIndex = 3;
            // 
            // lblCustomerKind
            // 
            this.lblCustomerKind.AutoSize = true;
            this.lblCustomerKind.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerKind.Location = new System.Drawing.Point(20, 160);
            this.lblCustomerKind.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCustomerKind.Name = "lblCustomerKind";
            this.lblCustomerKind.Size = new System.Drawing.Size(90, 20);
            this.lblCustomerKind.TabIndex = 10;
            this.lblCustomerKind.Text = "Loại khách";
            // 
            // lblIdentity
            // 
            this.lblIdentity.AutoSize = true;
            this.lblIdentity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdentity.Location = new System.Drawing.Point(20, 201);
            this.lblIdentity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIdentity.Name = "lblIdentity";
            this.lblIdentity.Size = new System.Drawing.Size(60, 20);
            this.lblIdentity.TabIndex = 12;
            this.lblIdentity.Text = "CMND";
            // 
            // txtIdentity
            // 
            this.txtIdentity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdentity.Location = new System.Drawing.Point(132, 197);
            this.txtIdentity.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIdentity.Name = "txtIdentity";
            this.txtIdentity.Size = new System.Drawing.Size(199, 26);
            this.txtIdentity.TabIndex = 4;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(20, 240);
            this.lblAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(61, 20);
            this.lblAddress.TabIndex = 14;
            this.lblAddress.Text = "Địa chỉ";
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(132, 236);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(199, 26);
            this.txtAddress.TabIndex = 5;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(347, 113);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(185, 66);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnPay
            // 
            this.btnPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPay.Location = new System.Drawing.Point(347, 201);
            this.btnPay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(395, 62);
            this.btnPay.TabIndex = 9;
            this.btnPay.Text = "Thanh toán/Trả phòng...";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(557, 113);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(185, 66);
            this.btnEdit.TabIndex = 8;
            this.btnEdit.Text = "Lưu";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // fCustomer
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 678);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.lblIdentity);
            this.Controls.Add(this.txtIdentity);
            this.Controls.Add(this.lblCustomerKind);
            this.Controls.Add(this.cbCustomerKind);
            this.Controls.Add(this.lblCustomerName);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.dtpRentRoom);
            this.Controls.Add(this.lblRentRoom);
            this.Controls.Add(this.cbRoom);
            this.Controls.Add(this.lblRoom);
            this.Controls.Add(this.lblTicket);
            this.Controls.Add(this.dgvTicket);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "fCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vé thuê phòng";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTicket)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTicket;
        private System.Windows.Forms.Label lblTicket;
        private System.Windows.Forms.Label lblRoom;
        private System.Windows.Forms.ComboBox cbRoom;
        private System.Windows.Forms.Label lblRentRoom;
        private System.Windows.Forms.DateTimePicker dtpRentRoom;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.ComboBox cbCustomerKind;
        private System.Windows.Forms.Label lblCustomerKind;
        private System.Windows.Forms.Label lblIdentity;
        private System.Windows.Forms.TextBox txtIdentity;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Button btnEdit;
    }
}