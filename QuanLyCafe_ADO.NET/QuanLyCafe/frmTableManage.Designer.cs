
namespace QuanLyCafe
{
    partial class frmTableManage
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PersonalInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LogoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnCancelBill = new System.Windows.Forms.Button();
            this.btnSaveBill = new System.Windows.Forms.Button();
            this.btnEditBill = new System.Windows.Forms.Button();
            this.btnDeleteBill = new System.Windows.Forms.Button();
            this.btnAddBill = new System.Windows.Forms.Button();
            this.plBill = new System.Windows.Forms.Panel();
            this.txtStatusBill = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpkDateOut = new System.Windows.Forms.DateTimePicker();
            this.dtpkDateIn = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIdTableBill = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdBill = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dtgvBillBoth = new System.Windows.Forms.DataGridView();
            this.btnBillInfo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.plBill.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBillBoth)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(0, 0);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(300, 300);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.adminToolStripMenuItem.Text = "Admin";
            this.adminToolStripMenuItem.Click += new System.EventHandler(this.adminToolStripMenuItem_Click);
            // 
            // thôngTinTàiKhoảnToolStripMenuItem
            // 
            this.thôngTinTàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PersonalInformationToolStripMenuItem,
            this.LogoutToolStripMenuItem});
            this.thôngTinTàiKhoảnToolStripMenuItem.Name = "thôngTinTàiKhoảnToolStripMenuItem";
            this.thôngTinTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(122, 20);
            this.thôngTinTàiKhoảnToolStripMenuItem.Text = "Thông tin tài khoản";
            // 
            // PersonalInformationToolStripMenuItem
            // 
            this.PersonalInformationToolStripMenuItem.Name = "PersonalInformationToolStripMenuItem";
            this.PersonalInformationToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.PersonalInformationToolStripMenuItem.Text = "Thông tin cá nhân";
            this.PersonalInformationToolStripMenuItem.Click += new System.EventHandler(this.PersonalInformationToolStripMenuItem_Click);
            // 
            // LogoutToolStripMenuItem
            // 
            this.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem";
            this.LogoutToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.LogoutToolStripMenuItem.Text = "Đăng xuất";
            this.LogoutToolStripMenuItem.Click += new System.EventHandler(this.LogoutToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolStripMenuItem,
            this.thôngTinTàiKhoảnToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(786, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnCancelBill);
            this.panel5.Controls.Add(this.btnSaveBill);
            this.panel5.Controls.Add(this.btnEditBill);
            this.panel5.Controls.Add(this.btnDeleteBill);
            this.panel5.Controls.Add(this.btnAddBill);
            this.panel5.Location = new System.Drawing.Point(12, 27);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(444, 42);
            this.panel5.TabIndex = 5;
            // 
            // btnCancelBill
            // 
            this.btnCancelBill.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelBill.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelBill.Location = new System.Drawing.Point(350, 5);
            this.btnCancelBill.Name = "btnCancelBill";
            this.btnCancelBill.Size = new System.Drawing.Size(80, 30);
            this.btnCancelBill.TabIndex = 4;
            this.btnCancelBill.Text = "Hủy bỏ";
            this.btnCancelBill.UseVisualStyleBackColor = true;
            this.btnCancelBill.Click += new System.EventHandler(this.btnCancelBill_Click);
            // 
            // btnSaveBill
            // 
            this.btnSaveBill.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveBill.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveBill.Location = new System.Drawing.Point(264, 5);
            this.btnSaveBill.Name = "btnSaveBill";
            this.btnSaveBill.Size = new System.Drawing.Size(80, 30);
            this.btnSaveBill.TabIndex = 3;
            this.btnSaveBill.Text = "Lưu";
            this.btnSaveBill.UseVisualStyleBackColor = true;
            this.btnSaveBill.Click += new System.EventHandler(this.btnSaveBill_Click);
            // 
            // btnEditBill
            // 
            this.btnEditBill.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditBill.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditBill.Location = new System.Drawing.Point(178, 5);
            this.btnEditBill.Name = "btnEditBill";
            this.btnEditBill.Size = new System.Drawing.Size(80, 30);
            this.btnEditBill.TabIndex = 2;
            this.btnEditBill.Text = "Sửa";
            this.btnEditBill.UseVisualStyleBackColor = true;
            this.btnEditBill.Click += new System.EventHandler(this.btnEditBill_Click);
            // 
            // btnDeleteBill
            // 
            this.btnDeleteBill.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteBill.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteBill.Location = new System.Drawing.Point(92, 5);
            this.btnDeleteBill.Name = "btnDeleteBill";
            this.btnDeleteBill.Size = new System.Drawing.Size(80, 30);
            this.btnDeleteBill.TabIndex = 1;
            this.btnDeleteBill.Text = "Xóa";
            this.btnDeleteBill.UseVisualStyleBackColor = true;
            this.btnDeleteBill.Click += new System.EventHandler(this.btnDeleteBill_Click);
            // 
            // btnAddBill
            // 
            this.btnAddBill.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddBill.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddBill.Location = new System.Drawing.Point(6, 5);
            this.btnAddBill.Name = "btnAddBill";
            this.btnAddBill.Size = new System.Drawing.Size(80, 30);
            this.btnAddBill.TabIndex = 0;
            this.btnAddBill.Text = "Thêm";
            this.btnAddBill.UseVisualStyleBackColor = true;
            this.btnAddBill.Click += new System.EventHandler(this.btnAddBill_Click);
            // 
            // plBill
            // 
            this.plBill.Controls.Add(this.txtStatusBill);
            this.plBill.Controls.Add(this.label5);
            this.plBill.Controls.Add(this.dtpkDateOut);
            this.plBill.Controls.Add(this.dtpkDateIn);
            this.plBill.Controls.Add(this.label4);
            this.plBill.Controls.Add(this.label3);
            this.plBill.Controls.Add(this.txtIdTableBill);
            this.plBill.Controls.Add(this.label2);
            this.plBill.Controls.Add(this.txtIdBill);
            this.plBill.Controls.Add(this.label1);
            this.plBill.Location = new System.Drawing.Point(462, 75);
            this.plBill.Name = "plBill";
            this.plBill.Size = new System.Drawing.Size(306, 350);
            this.plBill.TabIndex = 4;
            // 
            // txtStatusBill
            // 
            this.txtStatusBill.Location = new System.Drawing.Point(103, 179);
            this.txtStatusBill.Name = "txtStatusBill";
            this.txtStatusBill.Size = new System.Drawing.Size(173, 20);
            this.txtStatusBill.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "Trạng thái:";
            // 
            // dtpkDateOut
            // 
            this.dtpkDateOut.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpkDateOut.Location = new System.Drawing.Point(103, 141);
            this.dtpkDateOut.Name = "dtpkDateOut";
            this.dtpkDateOut.Size = new System.Drawing.Size(173, 20);
            this.dtpkDateOut.TabIndex = 9;
            // 
            // dtpkDateIn
            // 
            this.dtpkDateIn.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpkDateIn.Location = new System.Drawing.Point(103, 101);
            this.dtpkDateIn.Name = "dtpkDateIn";
            this.dtpkDateIn.Size = new System.Drawing.Size(173, 20);
            this.dtpkDateIn.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ngày ra:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ngày vào:";
            // 
            // txtIdTableBill
            // 
            this.txtIdTableBill.Location = new System.Drawing.Point(103, 58);
            this.txtIdTableBill.Name = "txtIdTableBill";
            this.txtIdTableBill.Size = new System.Drawing.Size(173, 20);
            this.txtIdTableBill.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã bàn:";
            // 
            // txtIdBill
            // 
            this.txtIdBill.Location = new System.Drawing.Point(103, 16);
            this.txtIdBill.Name = "txtIdBill";
            this.txtIdBill.Size = new System.Drawing.Size(173, 20);
            this.txtIdBill.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dtgvBillBoth);
            this.panel3.Location = new System.Drawing.Point(12, 75);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(444, 350);
            this.panel3.TabIndex = 3;
            // 
            // dtgvBillBoth
            // 
            this.dtgvBillBoth.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvBillBoth.Location = new System.Drawing.Point(6, 8);
            this.dtgvBillBoth.Name = "dtgvBillBoth";
            this.dtgvBillBoth.Size = new System.Drawing.Size(430, 330);
            this.dtgvBillBoth.TabIndex = 0;
            this.dtgvBillBoth.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvBillBoth_CellClick);
            // 
            // btnBillInfo
            // 
            this.btnBillInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBillInfo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBillInfo.Location = new System.Drawing.Point(533, 32);
            this.btnBillInfo.Name = "btnBillInfo";
            this.btnBillInfo.Size = new System.Drawing.Size(178, 30);
            this.btnBillInfo.TabIndex = 6;
            this.btnBillInfo.Text = "Chi tiết hóa đơn:";
            this.btnBillInfo.UseVisualStyleBackColor = true;
            this.btnBillInfo.Click += new System.EventHandler(this.btnBillInfo_Click);
            // 
            // frmTableManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(786, 445);
            this.Controls.Add(this.btnBillInfo);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.plBill);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmTableManage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mềm quản lý quán Cafe";
            this.Load += new System.EventHandler(this.frmTableManage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.plBill.ResumeLayout(false);
            this.plBill.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBillBoth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinTàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PersonalInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LogoutToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnCancelBill;
        private System.Windows.Forms.Button btnSaveBill;
        private System.Windows.Forms.Button btnEditBill;
        private System.Windows.Forms.Button btnDeleteBill;
        private System.Windows.Forms.Button btnAddBill;
        private System.Windows.Forms.Panel plBill;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIdTableBill;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdBill;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dtgvBillBoth;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpkDateOut;
        private System.Windows.Forms.DateTimePicker dtpkDateIn;
        private System.Windows.Forms.TextBox txtStatusBill;
        private System.Windows.Forms.Button btnBillInfo;
    }
}