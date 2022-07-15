using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using QuanLyCafe.BS_Layer;

namespace QuanLyCafe
{
    public partial class frmBillInfo : Form
    {
        private string strId;
        DataTable dtBI = null;
        bool Them = false;
        string err;
        BLBillInfo dbBI = new BLBillInfo();
        public frmBillInfo(string id)
        {
            strId = id;
            InitializeComponent();
        }

        private void dtgvBillInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dtgvBillInfo.CurrentCell.RowIndex;

            this.txtIdBillInfo.Text = dtgvBillInfo.Rows[r].Cells[0].Value.ToString();
            this.txtIdBill.Text = dtgvBillInfo.Rows[r].Cells[1].Value.ToString();
            this.cbFoodBillInfo.Text = dtgvBillInfo.Rows[r].Cells[2].Value.ToString();
            this.nmCountBillInfo.Text = dtgvBillInfo.Rows[r].Cells[3].Value.ToString();

        }
        void LoadBillInfo()
        {
            try
            {
                dtBI = new DataTable();
                dtBI.Clear();

                DataSet ds = dbBI.LayBillInfo(strId);
                dtBI = ds.Tables[0];

                dtgvBillInfo.DataSource = dtBI;
                dtgvBillInfo.AutoResizeColumns();

                this.txtIdBill.Text = strId;
                this.txtIdBillInfo.ResetText();
                this.cbFoodBillInfo.ResetText();
                this.nmCountBillInfo.ResetText();
                this.txtTotal.Text = dbBI.TotalPay(strId).ToString();

                this.btnAddBillInfo.Enabled = true;
                this.btnEditBillInfo.Enabled = true;
                this.btnDeleteBillInfo.Enabled = true;

                this.btnSaveBillInfo.Enabled = false;
                this.btnCancelBillInfo.Enabled = false;
                this.plBillInfo.Enabled = false;
                this.txtTotal.Enabled = false;
                this.txtIdBillInfo.Enabled = true;

            }
            catch
            {
                MessageBox.Show("Không lấy được nội dung trong bảng BillInfo. Lỗi rồi!!!");
            }
        }

        private void frmBillInfo_Load(object sender, EventArgs e)
        {
            LoadBillInfo();
            BLFood f = new BLFood();
            DataSet ds = f.LayFood();
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                cbFoodBillInfo.Items.Add(row["name"].ToString());
            }
        }

        private void btnAddBillInfo_Click(object sender, EventArgs e)
        {
            Them = true;

            this.txtIdBillInfo.ResetText();
            this.cbFoodBillInfo.ResetText();
            this.nmCountBillInfo.ResetText();

            this.btnAddBillInfo.Enabled = false;
            this.btnEditBillInfo.Enabled = false;
            this.btnDeleteBillInfo.Enabled = false;

            this.btnSaveBillInfo.Enabled = true;
            this.btnCancelBillInfo.Enabled = true;
            this.plBillInfo.Enabled = true;
            this.txtIdBill.Enabled = false;

            this.txtIdBillInfo.Focus();
        }

        private void btnDeleteBillInfo_Click(object sender, EventArgs e)
        {
            int r = dtgvBillInfo.CurrentCell.RowIndex;
            string strBI = dtgvBillInfo.Rows[r].Cells[0].Value.ToString();

            DialogResult traloi;
            traloi = MessageBox.Show("Chắc xóa mẫu tin này không?", "Trả lời",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (traloi == DialogResult.Yes)
            {
                dbBI.XoaBillInfo(strBI, ref err);
                LoadBillInfo();
                MessageBox.Show("Đã xóa xong!");
            }
            else
            {
                MessageBox.Show("Không thực hiện việc xóa mẫu tin!");
            }
        }

        private void btnEditBillInfo_Click(object sender, EventArgs e)
        {
            Them = false;

            this.btnAddBillInfo.Enabled = false;
            this.btnEditBillInfo.Enabled = false;
            this.btnDeleteBillInfo.Enabled = false;

            this.btnSaveBillInfo.Enabled = true;
            this.btnCancelBillInfo.Enabled = true;
            this.plBillInfo.Enabled = true;
            this.txtIdBill.Enabled = false;
            this.txtIdBillInfo.Enabled = false;
        }

        private void btnSaveBillInfo_Click(object sender, EventArgs e)
        {
            if (Them)
            {
                try
                {
                    if (this.txtIdBill.Text == "" || this.cbFoodBillInfo.Text == "" || this.nmCountBillInfo.Text == "")
                    {
                        MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                    }
                    else
                    {
                        BLBillInfo blBI = new BLBillInfo();
                        blBI.ThemBillInfo(this.txtIdBillInfo.Text, this.txtIdBill.Text, this.cbFoodBillInfo.Text, (int)this.nmCountBillInfo.Value, ref err);
                        LoadBillInfo();
                        MessageBox.Show("Đã thêm xong!");
                    }
                }
                catch
                {
                    MessageBox.Show("Lỗi rồi!");
                }
            }
            else
            {
                BLBillInfo blBI = new BLBillInfo();
                blBI.SuaBillInfo(this.txtIdBillInfo.Text, this.txtIdBill.Text, this.cbFoodBillInfo.Text, (int)this.nmCountBillInfo.Value, ref err);
                LoadBillInfo();
                MessageBox.Show("Đã sửa xong!");
            }
        }

        private void btnCancelBillInfo_Click(object sender, EventArgs e)
        {
            this.txtIdBillInfo.ResetText();
            this.cbFoodBillInfo.ResetText();
            this.nmCountBillInfo.ResetText();

            this.btnAddBillInfo.Enabled = true;
            this.btnEditBillInfo.Enabled = true;
            this.btnDeleteBillInfo.Enabled = true;

            this.btnSaveBillInfo.Enabled = false;
            this.btnCancelBillInfo.Enabled = false;
            this.plBillInfo.Enabled = false;
            this.txtIdBillInfo.Enabled = true;

            dtgvBillInfo_CellClick(null, null);
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            BLBill bl = new BLBill();
            bl.PayBill(strId,ref err);
            this.Close();
        }
    }
}
