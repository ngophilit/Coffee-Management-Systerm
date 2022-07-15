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
    public partial class frmLogin : Form
    {
        BLAccount blAcc = new BLAccount();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn chắc chắn muốn thoát chương trình?", "Trả lời",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
                Close();
        }

        private void txtUsername_Click(object sender, EventArgs e)
        {
            txtUsername.BackColor = Color.White;
            plUsername.BackColor = Color.White;
            txtPassword.BackColor = SystemColors.Control;
            plPassword.BackColor = SystemColors.Control;
        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            txtPassword.BackColor = Color.White;
            plPassword.BackColor = Color.White;
            txtUsername.BackColor = SystemColors.Control;
            plUsername.BackColor = SystemColors.Control;
        }

        private void ptbLock_MouseDown(object sender, MouseEventArgs e)
        {
            txtPassword.UseSystemPasswordChar = false;
        }

        private void ptbLock_MouseUp(object sender, MouseEventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string User = txtUsername.Text.Trim();
            string Pass = txtPassword.Text.Trim();

            bool kt = blAcc.KiemTra(User, Pass);
            
            if(kt == true)
            {
                frmTableManage f = new frmTableManage(User);
                this.Hide();    // Ẩn form đăng nhập
                f.ShowDialog(); // Dùng ShowDialog để khi đóng file f thì nó mới chạy các câu lệnh tiếp theo
                this.Show();
            }
            else
            {
                MessageBox.Show("Không đúng tên người dùng / mật khẩu !!!", "Thông báo");
                txtPassword.Focus();
            }
            
        }
    }
}
