
namespace QuanLyCafe
{
    partial class frmBillInfo
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
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnPay = new System.Windows.Forms.Button();
            this.btnCancelBillInfo = new System.Windows.Forms.Button();
            this.btnSaveBillInfo = new System.Windows.Forms.Button();
            this.btnEditBillInfo = new System.Windows.Forms.Button();
            this.btnDeleteBillInfo = new System.Windows.Forms.Button();
            this.btnAddBillInfo = new System.Windows.Forms.Button();
            this.plBillInfo = new System.Windows.Forms.Panel();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbFoodBillInfo = new System.Windows.Forms.ComboBox();
            this.nmCountBillInfo = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIdBill = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdBillInfo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dtgvBillInfo = new System.Windows.Forms.DataGridView();
            this.panel5.SuspendLayout();
            this.plBillInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmCountBillInfo)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBillInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnPay);
            this.panel5.Controls.Add(this.btnCancelBillInfo);
            this.panel5.Controls.Add(this.btnSaveBillInfo);
            this.panel5.Controls.Add(this.btnEditBillInfo);
            this.panel5.Controls.Add(this.btnDeleteBillInfo);
            this.panel5.Controls.Add(this.btnAddBillInfo);
            this.panel5.Location = new System.Drawing.Point(12, 12);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(756, 42);
            this.panel5.TabIndex = 8;
            // 
            // btnPay
            // 
            this.btnPay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPay.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPay.Location = new System.Drawing.Point(570, 5);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(143, 30);
            this.btnPay.TabIndex = 10;
            this.btnPay.Text = "Thanh toán";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // btnCancelBillInfo
            // 
            this.btnCancelBillInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelBillInfo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelBillInfo.Location = new System.Drawing.Point(350, 5);
            this.btnCancelBillInfo.Name = "btnCancelBillInfo";
            this.btnCancelBillInfo.Size = new System.Drawing.Size(80, 30);
            this.btnCancelBillInfo.TabIndex = 4;
            this.btnCancelBillInfo.Text = "Hủy bỏ";
            this.btnCancelBillInfo.UseVisualStyleBackColor = true;
            this.btnCancelBillInfo.Click += new System.EventHandler(this.btnCancelBillInfo_Click);
            // 
            // btnSaveBillInfo
            // 
            this.btnSaveBillInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveBillInfo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveBillInfo.Location = new System.Drawing.Point(264, 5);
            this.btnSaveBillInfo.Name = "btnSaveBillInfo";
            this.btnSaveBillInfo.Size = new System.Drawing.Size(80, 30);
            this.btnSaveBillInfo.TabIndex = 3;
            this.btnSaveBillInfo.Text = "Lưu";
            this.btnSaveBillInfo.UseVisualStyleBackColor = true;
            this.btnSaveBillInfo.Click += new System.EventHandler(this.btnSaveBillInfo_Click);
            // 
            // btnEditBillInfo
            // 
            this.btnEditBillInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditBillInfo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditBillInfo.Location = new System.Drawing.Point(178, 5);
            this.btnEditBillInfo.Name = "btnEditBillInfo";
            this.btnEditBillInfo.Size = new System.Drawing.Size(80, 30);
            this.btnEditBillInfo.TabIndex = 2;
            this.btnEditBillInfo.Text = "Sửa";
            this.btnEditBillInfo.UseVisualStyleBackColor = true;
            this.btnEditBillInfo.Click += new System.EventHandler(this.btnEditBillInfo_Click);
            // 
            // btnDeleteBillInfo
            // 
            this.btnDeleteBillInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteBillInfo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteBillInfo.Location = new System.Drawing.Point(92, 5);
            this.btnDeleteBillInfo.Name = "btnDeleteBillInfo";
            this.btnDeleteBillInfo.Size = new System.Drawing.Size(80, 30);
            this.btnDeleteBillInfo.TabIndex = 1;
            this.btnDeleteBillInfo.Text = "Xóa";
            this.btnDeleteBillInfo.UseVisualStyleBackColor = true;
            this.btnDeleteBillInfo.Click += new System.EventHandler(this.btnDeleteBillInfo_Click);
            // 
            // btnAddBillInfo
            // 
            this.btnAddBillInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddBillInfo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddBillInfo.Location = new System.Drawing.Point(6, 5);
            this.btnAddBillInfo.Name = "btnAddBillInfo";
            this.btnAddBillInfo.Size = new System.Drawing.Size(80, 30);
            this.btnAddBillInfo.TabIndex = 0;
            this.btnAddBillInfo.Text = "Thêm";
            this.btnAddBillInfo.UseVisualStyleBackColor = true;
            this.btnAddBillInfo.Click += new System.EventHandler(this.btnAddBillInfo_Click);
            // 
            // plBillInfo
            // 
            this.plBillInfo.Controls.Add(this.txtTotal);
            this.plBillInfo.Controls.Add(this.label5);
            this.plBillInfo.Controls.Add(this.cbFoodBillInfo);
            this.plBillInfo.Controls.Add(this.nmCountBillInfo);
            this.plBillInfo.Controls.Add(this.label4);
            this.plBillInfo.Controls.Add(this.label3);
            this.plBillInfo.Controls.Add(this.txtIdBill);
            this.plBillInfo.Controls.Add(this.label2);
            this.plBillInfo.Controls.Add(this.txtIdBillInfo);
            this.plBillInfo.Controls.Add(this.label1);
            this.plBillInfo.Location = new System.Drawing.Point(462, 60);
            this.plBillInfo.Name = "plBillInfo";
            this.plBillInfo.Size = new System.Drawing.Size(306, 350);
            this.plBillInfo.TabIndex = 7;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(120, 232);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(156, 20);
            this.txtTotal.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 18);
            this.label5.TabIndex = 15;
            this.label5.Text = "Tổng tiền:";
            // 
            // cbFoodBillInfo
            // 
            this.cbFoodBillInfo.FormattingEnabled = true;
            this.cbFoodBillInfo.Location = new System.Drawing.Point(120, 101);
            this.cbFoodBillInfo.Name = "cbFoodBillInfo";
            this.cbFoodBillInfo.Size = new System.Drawing.Size(156, 21);
            this.cbFoodBillInfo.TabIndex = 14;
            // 
            // nmCountBillInfo
            // 
            this.nmCountBillInfo.Location = new System.Drawing.Point(120, 141);
            this.nmCountBillInfo.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nmCountBillInfo.Name = "nmCountBillInfo";
            this.nmCountBillInfo.Size = new System.Drawing.Size(156, 20);
            this.nmCountBillInfo.TabIndex = 13;
            this.nmCountBillInfo.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Số lượng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Món ăn:";
            // 
            // txtIdBill
            // 
            this.txtIdBill.Location = new System.Drawing.Point(120, 58);
            this.txtIdBill.Name = "txtIdBill";
            this.txtIdBill.Size = new System.Drawing.Size(156, 20);
            this.txtIdBill.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã hóa đơn:";
            // 
            // txtIdBillInfo
            // 
            this.txtIdBillInfo.Location = new System.Drawing.Point(120, 16);
            this.txtIdBillInfo.Name = "txtIdBillInfo";
            this.txtIdBillInfo.Size = new System.Drawing.Size(156, 20);
            this.txtIdBillInfo.TabIndex = 1;
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
            this.panel3.Controls.Add(this.dtgvBillInfo);
            this.panel3.Location = new System.Drawing.Point(12, 60);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(444, 350);
            this.panel3.TabIndex = 6;
            // 
            // dtgvBillInfo
            // 
            this.dtgvBillInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvBillInfo.Location = new System.Drawing.Point(6, 8);
            this.dtgvBillInfo.Name = "dtgvBillInfo";
            this.dtgvBillInfo.Size = new System.Drawing.Size(430, 330);
            this.dtgvBillInfo.TabIndex = 0;
            this.dtgvBillInfo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvBillInfo_CellClick);
            // 
            // frmBillInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 429);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.plBillInfo);
            this.Controls.Add(this.panel3);
            this.Name = "frmBillInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBillInfo";
            this.Load += new System.EventHandler(this.frmBillInfo_Load);
            this.panel5.ResumeLayout(false);
            this.plBillInfo.ResumeLayout(false);
            this.plBillInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmCountBillInfo)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBillInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnCancelBillInfo;
        private System.Windows.Forms.Button btnSaveBillInfo;
        private System.Windows.Forms.Button btnEditBillInfo;
        private System.Windows.Forms.Button btnDeleteBillInfo;
        private System.Windows.Forms.Button btnAddBillInfo;
        private System.Windows.Forms.Panel plBillInfo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIdBill;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdBillInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dtgvBillInfo;
        private System.Windows.Forms.ComboBox cbFoodBillInfo;
        private System.Windows.Forms.NumericUpDown nmCountBillInfo;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnPay;
    }
}