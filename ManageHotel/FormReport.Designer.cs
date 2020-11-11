namespace ManageHotel
{
    partial class FormReport
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
            this.tcReport = new System.Windows.Forms.TabControl();
            this.tpRevenue = new System.Windows.Forms.TabPage();
            this.lblMonth = new System.Windows.Forms.Label();
            this.cbMonthRevenue = new System.Windows.Forms.ComboBox();
            this.dgvRevenue = new System.Windows.Forms.DataGridView();
            this.tpDensity = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.cbMonthDensity = new System.Windows.Forms.ComboBox();
            this.dgvDensity = new System.Windows.Forms.DataGridView();
            this.lblTicket = new System.Windows.Forms.Label();
            this.tcReport.SuspendLayout();
            this.tpRevenue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRevenue)).BeginInit();
            this.tpDensity.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDensity)).BeginInit();
            this.SuspendLayout();
            // 
            // tcReport
            // 
            this.tcReport.Controls.Add(this.tpRevenue);
            this.tcReport.Controls.Add(this.tpDensity);
            this.tcReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcReport.Location = new System.Drawing.Point(13, 47);
            this.tcReport.Name = "tcReport";
            this.tcReport.SelectedIndex = 0;
            this.tcReport.Size = new System.Drawing.Size(410, 382);
            this.tcReport.TabIndex = 0;
            // 
            // tpRevenue
            // 
            this.tpRevenue.Controls.Add(this.lblMonth);
            this.tpRevenue.Controls.Add(this.cbMonthRevenue);
            this.tpRevenue.Controls.Add(this.dgvRevenue);
            this.tpRevenue.Location = new System.Drawing.Point(4, 25);
            this.tpRevenue.Name = "tpRevenue";
            this.tpRevenue.Padding = new System.Windows.Forms.Padding(3);
            this.tpRevenue.Size = new System.Drawing.Size(402, 353);
            this.tpRevenue.TabIndex = 0;
            this.tpRevenue.Text = "Doanh thu theo loại phòng";
            this.tpRevenue.UseVisualStyleBackColor = true;
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.Location = new System.Drawing.Point(5, 12);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(47, 16);
            this.lblMonth.TabIndex = 2;
            this.lblMonth.Text = "Tháng";
            // 
            // cbMonthRevenue
            // 
            this.cbMonthRevenue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMonthRevenue.FormattingEnabled = true;
            this.cbMonthRevenue.Location = new System.Drawing.Point(58, 8);
            this.cbMonthRevenue.Name = "cbMonthRevenue";
            this.cbMonthRevenue.Size = new System.Drawing.Size(121, 24);
            this.cbMonthRevenue.TabIndex = 1;
            this.cbMonthRevenue.SelectedValueChanged += new System.EventHandler(this.cbMonth_SelectedValueChanged);
            // 
            // dgvRevenue
            // 
            this.dgvRevenue.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRevenue.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvRevenue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRevenue.Location = new System.Drawing.Point(7, 43);
            this.dgvRevenue.Name = "dgvRevenue";
            this.dgvRevenue.ReadOnly = true;
            this.dgvRevenue.RowHeadersVisible = false;
            this.dgvRevenue.Size = new System.Drawing.Size(388, 304);
            this.dgvRevenue.TabIndex = 0;
            // 
            // tpDensity
            // 
            this.tpDensity.Controls.Add(this.label1);
            this.tpDensity.Controls.Add(this.cbMonthDensity);
            this.tpDensity.Controls.Add(this.dgvDensity);
            this.tpDensity.Location = new System.Drawing.Point(4, 25);
            this.tpDensity.Name = "tpDensity";
            this.tpDensity.Padding = new System.Windows.Forms.Padding(3);
            this.tpDensity.Size = new System.Drawing.Size(402, 353);
            this.tpDensity.TabIndex = 1;
            this.tpDensity.Text = "Mật độ sử dụng phòng";
            this.tpDensity.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tháng";
            // 
            // cbMonthDensity
            // 
            this.cbMonthDensity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMonthDensity.FormattingEnabled = true;
            this.cbMonthDensity.Location = new System.Drawing.Point(58, 8);
            this.cbMonthDensity.Name = "cbMonthDensity";
            this.cbMonthDensity.Size = new System.Drawing.Size(121, 24);
            this.cbMonthDensity.TabIndex = 3;
            this.cbMonthDensity.SelectedValueChanged += new System.EventHandler(this.cbMonthDensity_SelectedValueChanged);
            // 
            // dgvDensity
            // 
            this.dgvDensity.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDensity.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDensity.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDensity.Location = new System.Drawing.Point(7, 43);
            this.dgvDensity.Name = "dgvDensity";
            this.dgvDensity.ReadOnly = true;
            this.dgvDensity.RowHeadersVisible = false;
            this.dgvDensity.Size = new System.Drawing.Size(388, 304);
            this.dgvDensity.TabIndex = 1;
            // 
            // lblTicket
            // 
            this.lblTicket.AutoSize = true;
            this.lblTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTicket.Location = new System.Drawing.Point(159, 13);
            this.lblTicket.Name = "lblTicket";
            this.lblTicket.Size = new System.Drawing.Size(107, 25);
            this.lblTicket.TabIndex = 3;
            this.lblTicket.Text = "BÁO CÁO";
            // 
            // FormReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 441);
            this.Controls.Add(this.lblTicket);
            this.Controls.Add(this.tcReport);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo cáo";
            this.tcReport.ResumeLayout(false);
            this.tpRevenue.ResumeLayout(false);
            this.tpRevenue.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRevenue)).EndInit();
            this.tpDensity.ResumeLayout(false);
            this.tpDensity.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDensity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tcReport;
        private System.Windows.Forms.TabPage tpRevenue;
        private System.Windows.Forms.TabPage tpDensity;
        private System.Windows.Forms.Label lblTicket;
        private System.Windows.Forms.DataGridView dgvRevenue;
        private System.Windows.Forms.DataGridView dgvDensity;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.ComboBox cbMonthRevenue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbMonthDensity;
    }
}