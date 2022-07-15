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
    public partial class frmAdmin : Form
    {   
        DataTable dtAcc = null;
        bool Them = false;
        string err;
        BLAccount dbAcc = new BLAccount();

        DataTable dtTb = null;
        BLTable dbTb = new BLTable();

        DataTable dtC = null;
        BLCategory dbC = new BLCategory();

        DataTable dtF = null;
        BLFood dbF = new BLFood();

        BLBill dbB = new BLBill();

        public frmAdmin()
        {
            InitializeComponent();
        }

        void LoadDataAccount()
        {
            try
            {
                dtAcc = new DataTable();
                dtAcc.Clear();

                dtAcc = dbAcc.LayAccount();

                dtgvAccount.DataSource = dtAcc;
                dtgvAccount.AutoResizeColumns();

                this.txtUsernameAccount.ResetText();
                this.txtDisplaynameAccount.ResetText();
                this.txtPasswordAccount.ResetText();
                this.txtTypeAccount.ResetText();

                this.btnAddAccount.Enabled = true;
                this.btnEditAccount.Enabled = true;
                this.btnDeleteAccount.Enabled = true;

                this.btnSaveAccount.Enabled = false;
                this.btnCancelAccount.Enabled = false;
                this.plAccount.Enabled = false;
                this.txtUsernameAccount.Enabled = true;

            }
            catch
            {
                MessageBox.Show("Không lấy được nội dung trong bảng Account. Lỗi rồi!!!");
            }
        }

        private void frmAdmin_Load(object sender, EventArgs e)
        {
            LoadDataAccount();
            LoadDataTable();
            LoadDataCategory();
            LoadDataFood();
        }

        private void dtgvAccount_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dtgvAccount.CurrentCell.RowIndex;

            this.txtUsernameAccount.Text = dtgvAccount.Rows[r].Cells[0].Value.ToString();
            this.txtDisplaynameAccount.Text = dtgvAccount.Rows[r].Cells[1].Value.ToString();
            this.txtPasswordAccount.Text = dtgvAccount.Rows[r].Cells[2].Value.ToString();
            this.txtTypeAccount.Text = dtgvAccount.Rows[r].Cells[3].Value.ToString();
        }

        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            Them = true;

            this.txtUsernameAccount.ResetText();
            this.txtDisplaynameAccount.ResetText();
            this.txtPasswordAccount.ResetText();
            this.txtTypeAccount.ResetText();

            this.btnAddAccount.Enabled = false;
            this.btnEditAccount.Enabled = false;
            this.btnDeleteAccount.Enabled = false;

            this.btnSaveAccount.Enabled = true;
            this.btnCancelAccount.Enabled = true;
            this.plAccount.Enabled = true;

            this.txtUsernameAccount.Focus();
        }

        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            
            int r = dtgvAccount.CurrentCell.RowIndex;
            string strAccount = dtgvAccount.Rows[r].Cells[0].Value.ToString();

            DialogResult traloi;
            traloi = MessageBox.Show("Chắc xóa mẫu tin này không?", "Trả lời",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (traloi == DialogResult.Yes)
            {
                dbAcc.XoaAccount(strAccount, ref err);
                LoadDataAccount();
                MessageBox.Show("Đã xóa xong!");
            }
            else
            {
                MessageBox.Show("Không thực hiện việc xóa mẫu tin!");
            }
            
        }

        private void btnEditAccount_Click(object sender, EventArgs e)
        {
            Them = false;
            dtgvAccount_CellClick(null, null);

            this.btnAddAccount.Enabled = false;
            this.btnEditAccount.Enabled = false;
            this.btnDeleteAccount.Enabled = false;

            this.btnSaveAccount.Enabled = true;
            this.btnCancelAccount.Enabled = true;
            this.plAccount.Enabled = true;


            this.txtUsernameAccount.Enabled = false;
            this.txtDisplaynameAccount.Focus();
        }

        private void btnCancelAccount_Click(object sender, EventArgs e)
        {
            this.txtUsernameAccount.ResetText();
            this.txtDisplaynameAccount.ResetText();
            this.txtPasswordAccount.ResetText();
            this.txtTypeAccount.ResetText();

            this.btnAddAccount.Enabled = true;
            this.btnEditAccount.Enabled = true;
            this.btnDeleteAccount.Enabled = true;

            this.btnSaveAccount.Enabled = false;
            this.btnCancelAccount.Enabled = false;
            this.plAccount.Enabled = false;
            this.txtUsernameAccount.Enabled = true;

            dtgvAccount_CellClick(null, null);
        }

        private void btnSaveAccount_Click(object sender, EventArgs e)
        {
            if (Them)
            {
                try
                {
                    if(this.txtUsernameAccount.Text == "" || this.txtDisplaynameAccount.Text == "" || this.txtPasswordAccount.Text == "" || this.txtTypeAccount.Text == "")
                    {
                        MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                    }
                    else
                    {
                        BLAccount blAcc = new BLAccount();
                        blAcc.ThemAccount(this.txtUsernameAccount.Text, this.txtDisplaynameAccount.Text, this.txtPasswordAccount.Text, this.txtTypeAccount.Text, ref err);
                        LoadDataAccount();
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
                BLAccount blAcc = new BLAccount();
                blAcc.SuaAccount(this.txtUsernameAccount.Text, this.txtDisplaynameAccount.Text, this.txtPasswordAccount.Text, this.txtTypeAccount.Text, ref err);
                LoadDataAccount();
                MessageBox.Show("Đã sửa xong!");
            }
        }

        void LoadDataTable()
        {
            try
            {
                dtTb = new DataTable();
                dtTb.Clear();

                dtTb = dbTb.LayTable();

                dtgvTable.DataSource = dtTb;
                dtgvTable.AutoResizeColumns();

                this.txtIdTable.ResetText();
                this.txtTableName.ResetText();
                this.txtTableStatus.ResetText();

                this.btnAddTable.Enabled = true;
                this.btnEditTable.Enabled = true;
                this.btnDeleteTable.Enabled = true;

                this.btnSaveTable.Enabled = false;
                this.btnCancelTable.Enabled = false;
                this.plTable.Enabled = false;
                this.txtIdTable.Enabled = true;

            }
            catch
            {
                MessageBox.Show("Không lấy được nội dung trong bảng TableFood. Lỗi rồi!!!");
            }
        }

        private void dtgvTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dtgvTable.CurrentCell.RowIndex;

            this.txtIdTable.Text = dtgvTable.Rows[r].Cells[0].Value.ToString();
            this.txtTableName.Text = dtgvTable.Rows[r].Cells[1].Value.ToString();
            this.txtTableStatus.Text = dtgvTable.Rows[r].Cells[2].Value.ToString();
        }

        private void btnAddTable_Click(object sender, EventArgs e)
        {
            Them = true;

            this.txtIdTable.ResetText();
            this.txtTableName.ResetText();
            this.txtTableStatus.ResetText();

            this.btnAddTable.Enabled = false;
            this.btnEditTable.Enabled = false;
            this.btnDeleteTable.Enabled = false;

            this.btnSaveTable.Enabled = true;
            this.btnCancelTable.Enabled = true;
            this.plTable.Enabled = true;

            this.txtIdTable.Focus();
        }

        private void btnDeleteTable_Click(object sender, EventArgs e)
        {
            int r = dtgvTable.CurrentCell.RowIndex;
            string strTable = dtgvTable.Rows[r].Cells[0].Value.ToString();

            DialogResult traloi;
            traloi = MessageBox.Show("Chắc xóa mẫu tin này không?", "Trả lời",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (traloi == DialogResult.Yes)
            {
                dbTb.XoaTable(strTable, ref err);
                LoadDataTable();
                MessageBox.Show("Đã xóa xong!");
            }
            else
            {
                MessageBox.Show("Không thực hiện việc xóa mẫu tin!");
            }
        }

        private void btnEditTable_Click(object sender, EventArgs e)
        {
            Them = false;
            dtgvTable_CellClick(null, null);

            this.btnAddTable.Enabled = false;
            this.btnEditTable.Enabled = false;
            this.btnDeleteTable.Enabled = false;

            this.btnSaveTable.Enabled = true;
            this.btnCancelTable.Enabled = true;
            this.plTable.Enabled = true;


            this.txtIdTable.Enabled = false;
            this.txtTableName.Focus();
        }

        private void btnSaveTable_Click(object sender, EventArgs e)
        {
            if (Them)
            {
                try
                {
                    if (this.txtIdTable.Text == "" || this.txtTableName.Text == "" || this.txtTableStatus.Text == "" )
                    {
                        MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                    }
                    else
                    {
                        BLTable blTb = new BLTable();
                        blTb.ThemTable(this.txtIdTable.Text, this.txtTableName.Text, this.txtTableStatus.Text, ref err);
                        LoadDataTable();
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
                BLTable blTb = new BLTable();
                blTb.SuaTable(this.txtIdTable.Text, this.txtTableName.Text, this.txtTableStatus.Text, ref err);
                LoadDataTable();
                MessageBox.Show("Đã sửa xong!");
            }
        }

        private void btnCancelTable_Click(object sender, EventArgs e)
        {
            this.txtIdTable.ResetText();
            this.txtTableName.ResetText();
            this.txtTableStatus.ResetText();

            this.btnAddTable.Enabled = true;
            this.btnEditTable.Enabled = true;
            this.btnDeleteTable.Enabled = true;

            this.btnSaveTable.Enabled = false;
            this.btnCancelTable.Enabled = false;
            this.plTable.Enabled = false;
            this.txtIdTable.Enabled = true;

            dtgvTable_CellClick(null, null);
        }

        void LoadDataCategory()
        {
            try
            {
                dtC = new DataTable();
                dtC.Clear();

                dtC = dbC.LayCategory();

                dtgvCategory.DataSource = dtC;
                dtgvCategory.AutoResizeColumns();

                this.txtIdCategory.ResetText();
                this.txtCategoryName.ResetText();

                this.btnAddCategory.Enabled = true;
                this.btnEditCategory.Enabled = true;
                this.btnDeleteCategory.Enabled = true;

                this.btnSaveCategory.Enabled = false;
                this.btnCancelCategory.Enabled = false;
                this.plCategory.Enabled = false;
                this.txtIdCategory.Enabled = true;

            }
            catch
            {
                MessageBox.Show("Không lấy được nội dung trong bảng CategoryFood. Lỗi rồi!!!");
            }
        }

        private void dtgvCategory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dtgvCategory.CurrentCell.RowIndex;

            this.txtIdCategory.Text = dtgvCategory.Rows[r].Cells[0].Value.ToString();
            this.txtCategoryName.Text = dtgvCategory.Rows[r].Cells[1].Value.ToString();
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            Them = true;

            this.txtIdCategory.ResetText();
            this.txtCategoryName.ResetText();

            this.btnAddCategory.Enabled = false;
            this.btnEditCategory.Enabled = false;
            this.btnDeleteCategory.Enabled = false;

            this.btnSaveCategory.Enabled = true;
            this.btnCancelCategory.Enabled = true;
            this.plCategory.Enabled = true;

            this.txtIdCategory.Focus();
        }

        private void btnDeleteCategory_Click(object sender, EventArgs e)
        {
            int r = dtgvCategory.CurrentCell.RowIndex;
            string strCategory = dtgvCategory.Rows[r].Cells[0].Value.ToString();

            DialogResult traloi;
            traloi = MessageBox.Show("Chắc xóa mẫu tin này không?", "Trả lời",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (traloi == DialogResult.Yes)
            {
                dbC.XoaCategory(strCategory, ref err);
                LoadDataCategory();
                MessageBox.Show("Đã xóa xong!");
            }
            else
            {
                MessageBox.Show("Không thực hiện việc xóa mẫu tin!");
            }
        }

        private void btnEditCategory_Click(object sender, EventArgs e)
        {
            Them = false;
            dtgvCategory_CellClick(null, null);

            this.btnAddCategory.Enabled = false;
            this.btnEditCategory.Enabled = false;
            this.btnDeleteCategory.Enabled = false;

            this.btnSaveCategory.Enabled = true;
            this.btnCancelCategory.Enabled = true;
            this.plCategory.Enabled = true;

            this.txtIdCategory.Enabled = false;
            this.txtCategoryName.Focus();
        }

        private void btnSaveCategory_Click(object sender, EventArgs e)
        {
            if (Them)
            {
                try
                {
                    if (this.txtIdCategory.Text == "" || this.txtCategoryName.Text == "")
                    {
                        MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                    }
                    else
                    {
                        BLCategory blC = new BLCategory();
                        blC.ThemCategory(this.txtIdCategory.Text, this.txtCategoryName.Text, ref err);
                        LoadDataCategory();
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
                BLCategory blC = new BLCategory();
                blC.SuaCategory(this.txtIdCategory.Text, this.txtCategoryName.Text, ref err);
                LoadDataCategory();
                MessageBox.Show("Đã sửa xong!");
            }
        }

        private void btnCancelCategory_Click(object sender, EventArgs e)
        {
            dtgvCategory.DataSource = dtC;
            dtgvCategory.AutoResizeColumns();

            this.txtIdCategory.ResetText();
            this.txtCategoryName.ResetText();

            this.btnAddCategory.Enabled = true;
            this.btnEditCategory.Enabled = true;
            this.btnDeleteCategory.Enabled = true;

            this.btnSaveCategory.Enabled = false;
            this.btnCancelCategory.Enabled = false;
            this.plCategory.Enabled = false;
            this.txtIdCategory.Enabled = true;

            dtgvCategory_CellClick(null, null);
        }

        void LoadDataFood()
        {
            try
            {
                dtF = new DataTable();
                dtF.Clear();

                dtF = dbF.LayFood();

                dtgvFood.DataSource = dtF;
                dtgvFood.AutoResizeColumns();

                this.txtIdFood.ResetText();
                this.txtFoodName.ResetText();
                this.txtCategoryFood.ResetText();
                this.nmPriceFood.ResetText();

                this.btnAddFood.Enabled = true;
                this.btnEditFood.Enabled = true;
                this.btnDeleteFood.Enabled = true;

                this.btnSaveFood.Enabled = false;
                this.btnCancelFood.Enabled = false;
                this.plFood.Enabled = false;
                this.txtIdFood.Enabled = true;

            }
            catch
            {
                MessageBox.Show("Không lấy được nội dung trong bảng Food. Lỗi rồi!!!");
            }
        }

        private void dtgvFood_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dtgvFood.CurrentCell.RowIndex;

            this.txtIdFood.Text = dtgvFood.Rows[r].Cells[0].Value.ToString();
            this.txtFoodName.Text = dtgvFood.Rows[r].Cells[1].Value.ToString();
            this.txtCategoryFood.Text = dtgvFood.Rows[r].Cells[2].Value.ToString();
            this.nmPriceFood.Text = dtgvFood.Rows[r].Cells[3].Value.ToString();
        }

        private void btnAddFood_Click(object sender, EventArgs e)
        {
            Them = true;

            this.txtIdFood.ResetText();
            this.txtFoodName.ResetText();
            this.txtCategoryFood.ResetText();
            this.nmPriceFood.ResetText();

            this.btnAddFood.Enabled = false;
            this.btnEditFood.Enabled = false;
            this.btnDeleteFood.Enabled = false;

            this.btnSaveFood.Enabled = true;
            this.btnCancelFood.Enabled = true;
            this.plFood.Enabled = true;

            this.txtIdFood.Focus();
        }

        private void btnDeleteFood_Click(object sender, EventArgs e)
        {
            int r = dtgvFood.CurrentCell.RowIndex;
            string strFood = dtgvFood.Rows[r].Cells[0].Value.ToString();

            DialogResult traloi;
            traloi = MessageBox.Show("Chắc xóa mẫu tin này không?", "Trả lời",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (traloi == DialogResult.Yes)
            {
                dbF.XoaFood(strFood, ref err);
                LoadDataFood();
                MessageBox.Show("Đã xóa xong!");
            }
            else
            {
                MessageBox.Show("Không thực hiện việc xóa mẫu tin!");
            }
        }

        private void btnEditFood_Click(object sender, EventArgs e)
        {
            Them = false;
            dtgvFood_CellClick(null, null);

            this.btnAddFood.Enabled = false;
            this.btnEditFood.Enabled = false;
            this.btnDeleteFood.Enabled = false;

            this.btnSaveFood.Enabled = true;
            this.btnCancelFood.Enabled = true;
            this.plFood.Enabled = true;

            this.txtIdFood.Enabled = false;
            this.txtFoodName.Focus();
        }

        private void btnSaveFood_Click(object sender, EventArgs e)
        {
            if (Them)
            {
                try
                {
                    if (this.txtIdFood.Text == "" || this.txtFoodName.Text == "" || this.txtCategoryFood.Text == "" || this.nmPriceFood.Text == "")
                    {
                        MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                    }
                    else
                    {
                        BLFood blF = new BLFood();
                        blF.ThemFood(this.txtIdFood.Text, this.txtFoodName.Text, this.txtCategoryFood.Text, ((int)this.nmPriceFood.Value), ref err);
                        LoadDataFood();
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
                BLFood blF = new BLFood();
                blF.SuaFood(this.txtIdFood.Text, this.txtFoodName.Text, this.txtCategoryFood.Text, ((int)this.nmPriceFood.Value), ref err);
                LoadDataFood();
                MessageBox.Show("Đã sửa xong!");
            }
        }

        private void btnCancelFood_Click(object sender, EventArgs e)
        {
            this.txtIdFood.ResetText();
            this.txtFoodName.ResetText();
            this.txtCategoryFood.ResetText();
            this.nmPriceFood.ResetText();

            this.btnAddFood.Enabled = true;
            this.btnEditFood.Enabled = true;
            this.btnDeleteFood.Enabled = true;

            this.btnSaveFood.Enabled = false;
            this.btnCancelFood.Enabled = false;
            this.plFood.Enabled = false;
            this.txtIdFood.Enabled = true;

            dtgvFood_CellClick(null, null);
        }

        private void btnBillview_Click(object sender, EventArgs e)
        {
            DateTime DateFrom = this.dtpkFromDate.Value;
            DateTime DateTo = this.dtpkToDate.Value;
            DataTable dt = new DataTable();
            dt = dbB.ThongKeBill(DateFrom, DateTo, ref err);

            dtgvBill.DataSource = dt;
            dtgvBill.AutoResizeColumns();
        }

        private void btnSearchFood_Click(object sender, EventArgs e)
        {
            string tk = this.txtSearchFood.Text;
            try
            {
                dtF = new DataTable();
                dtF.Clear();

                dtF = dbF.TimKiemFood(tk);

                dtgvFood.DataSource = dtF;
                dtgvFood.AutoResizeColumns();

                this.txtIdFood.ResetText();
                this.txtFoodName.ResetText();
                this.txtCategoryFood.ResetText();
                this.nmPriceFood.ResetText();

                this.btnAddFood.Enabled = true;
                this.btnEditFood.Enabled = true;
                this.btnDeleteFood.Enabled = true;

                this.btnSaveFood.Enabled = false;
                this.btnCancelFood.Enabled = false;
                this.plFood.Enabled = false;

            }
            catch
            {
                MessageBox.Show("Không lấy được nội dung trong bảng Food. Lỗi rồi!!!");
            }
        }
    }
}
