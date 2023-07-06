using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            var a = MessageBox.Show("Bạn có muốn thoát?", "Thông báo",
                                    MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Question);
            if(a==DialogResult.Yes)
            {
                Application.Exit();
            }    
        }

        private void btnDN_Click(object sender, EventArgs e)
        {
            using (BanVeXeDataContext db = new BanVeXeDataContext())
            {
                string tk = txtUsername.Text;
                string mk = txtPassword.Text;
                var DN = db.Nhanviens.Where(nv => nv.MaNV == tk && nv.MatKhau == mk).Select(nv => nv);
                    
                if(DN.Any())
                {
                    this.Hide();
                    frmMain main = new frmMain();
                    main.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Sai tên tài khoản hoặc mật khẩu!");
                    return;                        
                }
                                        
            }    
        }
    }
}
