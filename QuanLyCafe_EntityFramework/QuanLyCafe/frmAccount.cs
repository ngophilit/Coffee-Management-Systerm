using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyCafe.BS_Layer;

namespace QuanLyCafe
{
    public partial class frmAccount : Form
    {
        string username;
        BLAccount db = new BLAccount();
        List<string> acc  = null;
        string err;
        public frmAccount(string user)
        {
            username = user;
            InitializeComponent();
        }

        private void btnExitAccount_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAccount_Load(object sender, EventArgs e)
        {
            LoadAccount();
        }
        void LoadAccount()
        {
            try
            {
                this.txtUserAcc.Text = username;
                this.txtUserAcc.Enabled = false;
                this.txtUserAcc.BackColor = Color.White;
                acc = db.LayInfoAcc(username);
                this.txtDisplaynameAcc.Text = acc[1];

            }
            catch
            {
                MessageBox.Show("Không lấy được dữ liệu người dùng. Lỗi rồi!!!");
            }
        }

        private void btnUpdateAcc_Click(object sender, EventArgs e)
        {
            if(this.txtDisplaynameAcc.Text == "" || this.txtPasswordAcc.Text == "" || this.txtNewPasswordAcc.Text == "" || this.txtRetypeNewPasswordAcc.Text =="")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
            else
            {
                if(this.txtPasswordAcc.Text != acc[2])
                {
                    MessageBox.Show("Sai mật khẩu hiện tại");
                }
                else
                {
                    if(this.txtNewPasswordAcc.Text !=  this.txtRetypeNewPasswordAcc.Text)
                    {
                        MessageBox.Show("Mật khẩu mới vừa nhập không trùng nhau!");
                    }
                    else
                    {
                        BLAccount bl = new BLAccount();
                        string type = acc[3];
                        bl.SuaAccount(this.txtUserAcc.Text, this.txtDisplaynameAcc.Text, this.txtNewPasswordAcc.Text, type, ref err);
                        LoadAccount();
                        this.Close();
                        MessageBox.Show("Đã sửa xong!");
                    }    
                }    
            }
        }
    }
}
