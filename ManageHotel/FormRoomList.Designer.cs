namespace ManageHotel
{
    partial class fRoomList
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
            this.dgvRoomList = new System.Windows.Forms.DataGridView();
            this.lblRoomList = new System.Windows.Forms.Label();
            this.btnPay = new System.Windows.Forms.Button();
            this.cbRoomKind = new System.Windows.Forms.ComboBox();
            this.txtRoomPrice = new System.Windows.Forms.TextBox();
            this.lblRoomPrice = new System.Windows.Forms.Label();
            this.btnView = new System.Windows.Forms.Button();
            this.lblRoomKind = new System.Windows.Forms.Label();
            this.lblRoomName = new System.Windows.Forms.Label();
            this.txtRoomName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoomList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRoomList
            // 
            this.dgvRoomList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRoomList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvRoomList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRoomList.Location = new System.Drawing.Point(18, 166);
            this.dgvRoomList.Name = "dgvRoomList";
            this.dgvRoomList.RowHeadersVisible = false;
            this.dgvRoomList.Size = new System.Drawing.Size(544, 372);
            this.dgvRoomList.TabIndex = 6;
            // 
            // lblRoomList
            // 
            this.lblRoomList.AutoSize = true;
            this.lblRoomList.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomList.Location = new System.Drawing.Point(186, 22);
            this.lblRoomList.Name = "lblRoomList";
            this.lblRoomList.Size = new System.Drawing.Size(217, 25);
            this.lblRoomList.TabIndex = 2;
            this.lblRoomList.Text = "DANH SÁCH PHÒNG";
            // 
            // btnPay
            // 
            this.btnPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPay.Location = new System.Drawing.Point(347, 109);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(215, 39);
            this.btnPay.TabIndex = 5;
            this.btnPay.Text = "Thanh toán...";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // cbRoomKind
            // 
            this.cbRoomKind.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRoomKind.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRoomKind.FormattingEnabled = true;
            this.cbRoomKind.Location = new System.Drawing.Point(94, 92);
            this.cbRoomKind.Name = "cbRoomKind";
            this.cbRoomKind.Size = new System.Drawing.Size(242, 24);
            this.cbRoomKind.TabIndex = 2;
            this.cbRoomKind.SelectedValueChanged += new System.EventHandler(this.cbRoomKind_SelectedValueChanged);
            // 
            // txtRoomPrice
            // 
            this.txtRoomPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRoomPrice.Location = new System.Drawing.Point(94, 125);
            this.txtRoomPrice.Name = "txtRoomPrice";
            this.txtRoomPrice.ReadOnly = true;
            this.txtRoomPrice.Size = new System.Drawing.Size(242, 22);
            this.txtRoomPrice.TabIndex = 3;
            // 
            // lblRoomPrice
            // 
            this.lblRoomPrice.AutoSize = true;
            this.lblRoomPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomPrice.Location = new System.Drawing.Point(16, 128);
            this.lblRoomPrice.Name = "lblRoomPrice";
            this.lblRoomPrice.Size = new System.Drawing.Size(29, 16);
            this.lblRoomPrice.TabIndex = 52;
            this.lblRoomPrice.Text = "Giá";
            // 
            // btnView
            // 
            this.btnView.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.Location = new System.Drawing.Point(347, 61);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(214, 39);
            this.btnView.TabIndex = 4;
            this.btnView.Text = "Xem thông tin/Thuê phòng...";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblRoomKind
            // 
            this.lblRoomKind.AutoSize = true;
            this.lblRoomKind.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomKind.Location = new System.Drawing.Point(17, 95);
            this.lblRoomKind.Name = "lblRoomKind";
            this.lblRoomKind.Size = new System.Drawing.Size(75, 16);
            this.lblRoomKind.TabIndex = 45;
            this.lblRoomKind.Text = "Kiểu phòng";
            // 
            // lblRoomName
            // 
            this.lblRoomName.AutoSize = true;
            this.lblRoomName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomName.Location = new System.Drawing.Point(16, 63);
            this.lblRoomName.Name = "lblRoomName";
            this.lblRoomName.Size = new System.Drawing.Size(73, 16);
            this.lblRoomName.TabIndex = 44;
            this.lblRoomName.Text = "Tên phòng";
            // 
            // txtRoomName
            // 
            this.txtRoomName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRoomName.Location = new System.Drawing.Point(94, 61);
            this.txtRoomName.Name = "txtRoomName";
            this.txtRoomName.ReadOnly = true;
            this.txtRoomName.Size = new System.Drawing.Size(242, 22);
            this.txtRoomName.TabIndex = 1;
            // 
            // fRoomList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 555);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.cbRoomKind);
            this.Controls.Add(this.txtRoomPrice);
            this.Controls.Add(this.lblRoomPrice);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.lblRoomKind);
            this.Controls.Add(this.lblRoomName);
            this.Controls.Add(this.txtRoomName);
            this.Controls.Add(this.lblRoomList);
            this.Controls.Add(this.dgvRoomList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "fRoomList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách phòng";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoomList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRoomList;
        private System.Windows.Forms.Label lblRoomList;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.ComboBox cbRoomKind;
        private System.Windows.Forms.TextBox txtRoomPrice;
        private System.Windows.Forms.Label lblRoomPrice;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Label lblRoomKind;
        private System.Windows.Forms.Label lblRoomName;
        private System.Windows.Forms.TextBox txtRoomName;
    }
}