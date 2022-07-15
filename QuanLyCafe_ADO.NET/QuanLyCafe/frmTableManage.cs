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
    public partial class frmTableManage : Form
    {
        string user;
        DataTable dtBB = null;
        bool Them = false;
        string err;
        BLBill dbBB = new BLBill();
        public frmTableManage(string username)
        {
            user = username;
            InitializeComponent();
        }

        private void LogoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PersonalInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmAccount frmAcc = new frmAccount(user);
            frmAcc.ShowDialog();
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdmin frmAd = new frmAdmin();
            frmAd.ShowDialog();
        }

        private void frmTableManage_Load(object sender, EventArgs e)
        {
            LoadBillBoth();
        }

        private void dtgvBillBoth_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dtgvBillBoth.CurrentCell.RowIndex;

            this.txtIdBill.Text = dtgvBillBoth.Rows[r].Cells[0].Value.ToString();
            this.dtpkDateIn.Text = dtgvBillBoth.Rows[r].Cells[1].Value.ToString();
            this.dtpkDateOut.Text = dtgvBillBoth.Rows[r].Cells[2].Value.ToString();
            this.txtIdTableBill.Text = dtgvBillBoth.Rows[r].Cells[3].Value.ToString();
            if (dtgvBillBoth.Rows[r].Cells[4].Value.ToString() == "1")
            {
                this.txtStatusBill.Text = "Đã thanh toán";
            }
            else
            {
                this.txtStatusBill.Text = "Chưa thanh toán";
            }
        }
        void LoadBillBoth()
        {
            try
            {
                BLAccount blacc = new BLAccount();
                List<string> acc = new List<string>();

                acc = blacc.LayInfoAcc(user);
                if(acc[3] == "0")
                {
                    this.adminToolStripMenuItem.Enabled = false;
                }

                dtBB = new DataTable();
                dtBB.Clear();

                DataSet ds = dbBB.LayBill();
                dtBB = ds.Tables[0];

                dtgvBillBoth.DataSource = dtBB;
                dtgvBillBoth.AutoResizeColumns();

                this.txtIdBill.ResetText();
                this.txtIdTableBill.ResetText();
                this.txtStatusBill.ResetText();
                this.txtIdBill.Enabled = true;

                this.btnAddBill.Enabled = true;
                this.btnEditBill.Enabled = true;
                this.btnDeleteBill.Enabled = true;

                this.btnSaveBill.Enabled = false;
                this.btnCancelBill.Enabled = false;
                this.plBill.Enabled = false;

                dtgvBillBoth_CellClick(null, null);
            }
            catch
            {
                MessageBox.Show("Không lấy được nội dung trong bảng Bill. Lỗi rồi!!!");
            }
        }

        private void btnAddBill_Click(object sender, EventArgs e)
        {
            Them = true;

            this.txtIdBill.ResetText();
            this.txtIdTableBill.ResetText();
            this.txtStatusBill.ResetText();
            this.dtpkDateIn.ResetText();
            this.dtpkDateOut.ResetText();

            this.btnAddBill.Enabled = false;
            this.btnEditBill.Enabled = false;
            this.btnDeleteBill.Enabled = false;

            this.btnSaveBill.Enabled = true;
            this.btnCancelBill.Enabled = true;
            this.plBill.Enabled = true;

            this.txtIdBill.Focus();
            this.txtStatusBill.Enabled = false;
        }

        private void btnDeleteBill_Click(object sender, EventArgs e)
        {
            int r = dtgvBillBoth.CurrentCell.RowIndex;
            string strBB = dtgvBillBoth.Rows[r].Cells[0].Value.ToString();

            DialogResult traloi;
            traloi = MessageBox.Show("Chắc xóa mẫu tin này không?", "Trả lời",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (traloi == DialogResult.Yes)
            {
                dbBB.XoaBill(strBB, ref err);
                LoadBillBoth();
                MessageBox.Show("Đã xóa xong!");
            }
            else
            {
                MessageBox.Show("Không thực hiện việc xóa mẫu tin!");
            }
        }

        private void btnEditBill_Click(object sender, EventArgs e)
        {
            Them = false;

            this.btnAddBill.Enabled = false;
            this.btnEditBill.Enabled = false;
            this.btnDeleteBill.Enabled = false;

            this.btnSaveBill.Enabled = true;
            this.btnCancelBill.Enabled = true;
            this.plBill.Enabled = true;

            this.txtIdBill.Enabled = false ;
            this.txtStatusBill.Enabled = false;
            this.txtIdTableBill.Focus();
        }

        private void btnSaveBill_Click(object sender, EventArgs e)
        {
            if (Them)
            {
                try
                {
                    if (this.txtIdBill.Text == "" || this.txtIdTableBill.Text == "" )
                    {
                        MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                    }
                    else
                    {
                        BLBill blBB = new BLBill();
                        blBB.ThemBill(this.txtIdBill.Text, this.dtpkDateIn.Value, this.dtpkDateOut.Value, this.txtIdTableBill.Text, ref err);
                        LoadBillBoth();
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
                BLBill blBB = new BLBill();
                blBB.SuaBill(this.txtIdBill.Text, this.dtpkDateIn.Value, this.dtpkDateOut.Value, this.txtIdTableBill.Text,this.txtStatusBill.Text, ref err);
                LoadBillBoth();
                MessageBox.Show("Đã sửa xong!");
            }
        }

        private void btnCancelBill_Click(object sender, EventArgs e)
        {
            this.txtIdBill.ResetText();
            this.txtIdTableBill.ResetText();
            this.txtStatusBill.ResetText();

            this.btnAddBill.Enabled = true;
            this.btnEditBill.Enabled = true;
            this.btnDeleteBill.Enabled = true;

            this.btnSaveBill.Enabled = false;
            this.btnCancelBill.Enabled = false;
            this.plBill.Enabled = false;
            this.txtIdBill.Enabled = true;

            dtgvBillBoth_CellClick(null, null);
        }

        private void btnBillInfo_Click(object sender, EventArgs e)
        {
            int r = dtgvBillBoth.CurrentCell.RowIndex;
            string id = this.txtIdBill.Text = dtgvBillBoth.Rows[r].Cells[0].Value.ToString(); ;
            frmBillInfo frmBI = new frmBillInfo(id);
            frmBI.ShowDialog();
            LoadBillBoth();
        }
    }
}
