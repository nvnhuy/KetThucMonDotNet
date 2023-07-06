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
    public partial class frmNhanvien : Form
    {
        public frmNhanvien()
        {
            InitializeComponent();
        }

        private void frmNhanvien_Load(object sender, EventArgs e)
        {
            load_CBOCV();
            load_DataNV();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            using (BanVeXeDataContext db = new BanVeXeDataContext())
            {
                    var timnv = db.Nhanviens.Where(nv => nv.MaNV == txtIDNV.Text)
                    .Select(nv => new
                    {
                        TENNV = nv.TenNV,
                        NGSINH = nv.NgaySinhNV,
                        DCHI = nv.DiaChiNV,
                        CV = nv.ChucVu.TenCV,
                        ID = nv.MaNV,
                        MK = nv.MatKhau
                    });
                    dgvNV.DataSource = timnv;             
            }    
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            using (BanVeXeDataContext db = new BanVeXeDataContext())
            {
                bool existsNV = db.Nhanviens.Where(nv => nv.MaNV == txtIDNV.Text).Count() > 0;
                bool ktadmin = db.Nhanviens.Where(n => n.MaNV.Equals(txtIDNV.Text) && n.MaCV == "ADMIN").Count() > 0;
                bool ktnv = db.Nhanviens.Where(n => n.MaNV.Equals(txtIDNV.Text))
                    .Where(n => n.MaCV == "NV").Count() > 0;
                if (existsNV)
                {
                    MessageBox.Show("Mã này đã tồn tại");
                    return;
                }
                else
                {
                    Nhanvien newNV = new Nhanvien();
                    if(ktadmin || ktnv)
                    {
                        newNV.MaNV = txtIDNV.Text;
                        newNV.MatKhau = txtMK.Text;
                        newNV.DiaChiNV = txtDiachi.Text;
                        newNV.NgaySinhNV = dtpNgaysinh.Value.Date;
                        newNV.MaCV = cboCV.SelectedValue.ToString();                        
                    }
                    else
                    {
                        newNV.MaNV = txtIDNV.Text;
                        newNV.TenNV = txtTenNV.Text;
                        newNV.DiaChiNV = txtDiachi.Text;
                        newNV.NgaySinhNV = dtpNgaysinh.Value.Date;
                        newNV.MaCV = cboCV.SelectedValue.ToString();
                    }
                    db.Nhanviens.InsertOnSubmit(newNV);
                    db.SubmitChanges();
                    load_DataNV();
                }
            }    
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            using (BanVeXeDataContext db = new BanVeXeDataContext())
            {
                Nhanvien existsNV = db.Nhanviens.Where(nv=>nv.MaNV.Equals(txtIDNV.Text)).FirstOrDefault();
                if (existsNV==null)
                {
                    MessageBox.Show("Nhân viên này không tồn tại");
                    return;
                }
                else
                {
                    bool ktnv = db.Nhanviens.Where(n => n.MaNV.Equals(txtIDNV.Text) && n.MaCV == "NV").Count() > 0;
                    bool kttx = db.Nhanviens.Where(n => n.MaNV.Equals(txtIDNV.Text) && n.MaCV == "TX").Count() > 0;
                    bool ktadmin = db.Nhanviens.Where(n => n.MaNV.Equals(txtIDNV.Text))
                        .Where(n => n.MaCV == "ADMIN").Count() > 0;
                    if (ktnv)
                    {
                        db.Nhanviens.DeleteOnSubmit(existsNV);
                        
                    }
                    if(kttx)
                    {
                        Xe tx = db.Xes.Where(x => x.MaTX.Equals(txtIDNV.Text)).FirstOrDefault();
                        if(tx!=null)
                        {
                            MessageBox.Show("Bạn không thể xóa tài xế này!");
                            return;
                        }
                        else
                        {
                            db.Nhanviens.DeleteOnSubmit(existsNV);
                            
                        }
                    }
                    if(ktadmin)
                    {
                        int ktAdmin = db.Nhanviens.Where(nv => nv.MaCV == "ADMIN").Count();
                        if(ktAdmin==1)
                        {
                            MessageBox.Show("Bạn không thể xóa tất cả ADMIN");
                            return;
                        }
                        else
                        {
                            db.Nhanviens.DeleteOnSubmit(existsNV);
                            
                        }
                    }
                }
                db.SubmitChanges();
                load_DataNV();
            }    
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            using (BanVeXeDataContext db = new BanVeXeDataContext())
            {
                if(txtIDNV.Text==null)
                {
                    MessageBox.Show("Bạn chưa nhập mã nhân viên");
                    return;
                }
                else
                {
                    Nhanvien capnhatNV = db.Nhanviens.Single(nv => nv.MaNV == txtIDNV.Text);
                    capnhatNV.TenNV = txtTenNV.Text;
                    capnhatNV.DiaChiNV = txtDiachi.Text;
                    capnhatNV.NgaySinhNV = dtpNgaysinh.Value.Date;
                    capnhatNV.MaCV = cboCV.SelectedValue.ToString();
                }
                db.SubmitChanges();
                load_DataNV();
            }    
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
            frmMain main = new frmMain();
            main.Show();
        }

        private void load_CBOCV()
        {
            using (BanVeXeDataContext db = new BanVeXeDataContext())
            {
                var data = db.ChucVus.Select(t => t);
                cboCV.DataSource = data;
                cboCV.DisplayMember = "TenCV";
                cboCV.ValueMember = "MaCV";
            }    
        }
        private void load_DataNV()
        {
            using (BanVeXeDataContext db = new BanVeXeDataContext())
            {
                var data = db.Nhanviens.Where(nv => nv.MaCV == cboCV.SelectedValue.ToString())
                    .Select(nv => new
                    {
                        TENNV = nv.TenNV,
                        NGSINH = nv.NgaySinhNV,
                        DCHI = nv.DiaChiNV,
                        CV = nv.ChucVu.TenCV,
                        ID = nv.MaNV,
                        MK = nv.MatKhau
                    });
                dgvNV.DataSource = data;
            }
        }
        private void cboCV_SelectedIndexChanged(object sender, EventArgs e)
        {
            load_DataNV();
        }

        private void btnDoiMK_Click(object sender, EventArgs e)
        {
            using (BanVeXeDataContext db = new BanVeXeDataContext())
            {
                if (txtIDNV.Text == null )
                {
                    MessageBox.Show("Bạn chưa nhập mã nhân viên");
                    return;
                }
                else
                {
                    bool ktadmin = db.Nhanviens.Where(n => n.MaNV.Equals(txtIDNV.Text) && n.MaCV == "ADMIN").Count() > 0;
                    bool ktnv = db.Nhanviens.Where(n => n.MaNV.Equals(txtIDNV.Text) && n.MaCV == "NV").Count() > 0;
                    if (ktadmin || ktnv)
                    {
                        Nhanvien capnhatMK = db.Nhanviens.Single(n => n.MaNV == txtIDNV.Text);
                        if (txtMK.Text != txtNLMK.Text)
                        {
                            MessageBox.Show("Mật khẩu không trùng khớp");
                            return;
                        }
                        else
                        {
                            capnhatMK.MatKhau = txtNLMK.Text;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Tài xế không có tài khoản");
                        return;
                    }
                    db.SubmitChanges();
                    load_DataNV();
                }
            }
        }       
    }
}
