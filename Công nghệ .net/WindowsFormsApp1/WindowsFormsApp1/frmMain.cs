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
    public partial class frmMain : Form
    {
        
        public frmMain()
        {
            InitializeComponent();
            
        }

        private void btnKH_Click(object sender, EventArgs e)
        {            
            this.Hide();
            frmKhachhang fkh = new frmKhachhang();
            fkh.ShowDialog();
        }

        private void btnTX_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmTuyenxe ftx = new frmTuyenxe();
            ftx.ShowDialog();
        }

        private void btnCX_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmChuyenxe fcx = new frmChuyenxe();
            fcx.ShowDialog();
        }

        private void btnVX_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmVexe fvx = new frmVexe();
            fvx.ShowDialog();
        }

        private void btnBanve_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDatve fdv = new frmDatve();
            fdv.ShowDialog();
        }

        

        private void btnNV_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmNhanvien fnv = new frmNhanvien();
            fnv.ShowDialog();
        }

        private void btnXe_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmXe fxe = new frmXe();
            fxe.ShowDialog();
        }

        private void btnDangxuat_Click(object sender, EventArgs e)
        {
            var thoat = MessageBox.Show("Bạn có muốn thoát?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (thoat == DialogResult.Yes)
            {
                this.Hide();
                frmLogin flogin = new frmLogin();
                flogin.ShowDialog();
            }
            
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            
        }
    }
}
