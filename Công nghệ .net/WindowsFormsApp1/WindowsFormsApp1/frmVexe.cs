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
    public partial class frmVexe : Form
    {
        
        public frmVexe()
        {
            InitializeComponent();            
        }
           
        private void btnDongVX_Click(object sender, EventArgs e)
        {
            this.Close();
            frmMain main = new frmMain();
            main.Show();
        }       

        private void frmVexe_Load(object sender, EventArgs e)
        {
            load_cboCX();
            load_DataVX();            
        }
        private void load_DataVX()
        {
            using (BanVeXeDataContext db = new BanVeXeDataContext())
            {
                var vx = db.VeXes.Where(v=>v.MaChuyen==cboCX.SelectedValue.ToString()).Select(v => new
                {
                    MAVE = v.MaVe,
                    MAKH = v.MaKH,
                    TENKH=v.KhachHang.TenKH,
                    CHUYENXE = v.ChuyenXe.TenChuyen,
                    NGAYDI = v.NgayDi,
                    SOXE = v.ChuyenXe.Xe.TTXe,
                    VITRI = v.ViTri,
                    GIAVE= v.ChuyenXe.TuyenXe.GiaVe
                });
                dgvVexe.DataSource = vx;
            }
        }        

        private void load_cboCX()
        {
            using (BanVeXeDataContext db = new BanVeXeDataContext())
            {
                var cx = db.ChuyenXes.Select(c => c);
                cboCX.DataSource = cx;
                cboCX.DisplayMember = "TenChuyen";
                cboCX.ValueMember = "MaChuyen";
            }
        }
        private void cboCX_SelectedIndexChanged(object sender, EventArgs e)
        {
            load_DataVX();        
        }

        private void btnTimVX_Click(object sender, EventArgs e)
        {
            using (BanVeXeDataContext db = new BanVeXeDataContext())
            {
                if (txtMAVE.Text == "" && txtMAKH.Text == "")
                {
                    var tmve = db.VeXes.Where(v => v.NgayDi.Equals(dtpNgaydi.Value.Date) 
                    && v.MaChuyen.Equals(cboCX.SelectedValue.ToString()))
                        .Select(v => new
                    {
                        MAVE = v.MaVe,
                        MAKH = v.MaKH,
                        TENKH = v.KhachHang.TenKH,
                        CHUYENXE = v.ChuyenXe.TenChuyen,
                        NGAYDI = v.NgayDi,
                        SOXE = v.ChuyenXe.Xe.TTXe,
                        VITRI = v.ViTri
                    });
                    dgvVexe.DataSource = tmve;
                }
                if (txtMAVE.Text != "" && txtMAKH.Text=="")
                {
                    var tmve = db.VeXes.Where(v => v.MaVe.Equals(txtMAVE.Text)).Select(v => new
                    {
                        MAVE = v.MaVe,
                        MAKH = v.MaKH,
                        TENKH = v.KhachHang.TenKH,
                        CHUYENXE = v.ChuyenXe.TenChuyen,
                        NGAYDI = v.NgayDi,
                        SOXE = v.ChuyenXe.Xe.TTXe,
                        VITRI = v.ViTri
                    });
                    dgvVexe.DataSource = tmve;
                }
                if (txtMAKH.Text != "" && txtMAVE.Text=="")
                {
                    var tmkh = db.VeXes.Where(v => v.MaKH.Equals(txtMAKH.Text)).Select(v => new {
                        MAVE = v.MaVe,
                        MAKH = v.MaKH,
                        TENKH = v.KhachHang.TenKH,
                        CHUYENXE = v.ChuyenXe.TenChuyen,
                        NGAYDI = v.NgayDi,
                        SOXE = v.ChuyenXe.Xe.TTXe,
                        VITRI = v.ViTri
                    });
                    dgvVexe.DataSource = tmkh;
                }
                if (txtMAKH.Text != "" && txtMAVE.Text != "")
                {
                    var tmkh = db.VeXes.Where(v => v.MaKH.Equals(txtMAKH.Text))
                        .Where(v => v.MaVe.Equals(txtMAVE.Text))
                        .Select(v => new {
                        MAVE = v.MaVe,
                        MAKH = v.MaKH,
                        TENKH = v.KhachHang.TenKH,
                        CHUYENXE = v.ChuyenXe.TenChuyen,
                        NGAYDI = v.NgayDi,
                        SOXE = v.ChuyenXe.Xe.TTXe,
                        VITRI = v.ViTri
                    });
                    dgvVexe.DataSource = tmkh;
                }               
                
            }
        }
        private void btnDatve_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDatve fdv = new frmDatve();
            fdv.ShowDialog();
        }
        private void btnXoaVX_Click(object sender, EventArgs e)
        {
            string mave = txtMAVE.Text;
            string makh = txtMAKH.Text;
            using(BanVeXeDataContext db = new BanVeXeDataContext())
            {
                VeXe existsVe = db.VeXes.Where(v => v.MaVe.Equals(mave)).FirstOrDefault();
                VeXe existsKH = db.VeXes.Where(v => v.MaKH.Equals(makh)).FirstOrDefault();
                if (existsVe == null)
                {
                    MessageBox.Show("Không có vé này trên hệ thống");
                    return;
                }                
                if (existsKH == null)
                {
                    MessageBox.Show("Khách hàng không có thông tin vé trên hệ thống");
                    return;
                }                
                db.VeXes.DeleteOnSubmit(existsKH);                                
                db.SubmitChanges();
            }
            load_DataVX();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            load_DataVX();
        }
    }
}
