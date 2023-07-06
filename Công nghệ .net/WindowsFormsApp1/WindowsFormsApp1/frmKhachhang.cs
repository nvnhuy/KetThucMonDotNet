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
    public partial class frmKhachhang : Form
    {
        public frmKhachhang()
        {
            InitializeComponent();
        }

        
        private void frmKhachhang_Load(object sender, EventArgs e)
        {
            load_DataKH();
        }

        private void btnTimKH_Click(object sender, EventArgs e)
        {
            using (BanVeXeDataContext db = new BanVeXeDataContext())
            {
                if (txtMAKH.Text != "")
                {
                    var timkh = db.KhachHangs.Where(k => k.MaKH == txtMAKH.Text)
                            .Select(k => new
                            {
                                MAKH = k.MaKH,
                                TENKH = k.TenKH,
                                NGSINH = k.NgaySinh,
                                DIACHI = k.DiaChi
                            });
                    dgvTTKH.DataSource = timkh;
                }
                else
                {
                    load_DataKH();
                }
                
            }
        }

        private void btnCapnhatKH_Click(object sender, EventArgs e)
        {
            using (BanVeXeDataContext db = new BanVeXeDataContext())
            {
                if(txtMAKH.Text==null)
                {
                    MessageBox.Show("Bạn chưa nhập mã khách hàng!");
                    return;
                }
                else
                {
                    KhachHang capnhatKH = db.KhachHangs.Single(k => k.MaKH == txtMAKH.Text);
                    capnhatKH.TenKH = txtTENKH.Text;
                    capnhatKH.NgaySinh = dtpNgaysinh.Value.Date;
                    capnhatKH.DiaChi = txtDIACHI.Text;
                }
                db.SubmitChanges();
                load_DataKH();
            }
        }

        private void btnThemKH_Click(object sender, EventArgs e)
        {
            using (BanVeXeDataContext db = new BanVeXeDataContext())
            {
                bool existKH = db.KhachHangs.Where(k => k.MaKH == txtMAKH.Text).Count() > 0;
                if(existKH)
                {
                    MessageBox.Show("Khách hàng này đã tồn tại");
                    return;
                }    
                else
                {
                    KhachHang newKH = new KhachHang();
                    newKH.MaKH = txtMAKH.Text;
                    newKH.TenKH = txtTENKH.Text;
                    newKH.NgaySinh = dtpNgaysinh.Value.Date;
                    newKH.DiaChi = txtDIACHI.Text;
                    db.KhachHangs.InsertOnSubmit(newKH);
                    db.SubmitChanges();
                }
                load_DataKH();
            }
        }

        private void btnXoaKH_Click(object sender, EventArgs e)
        {
            using (BanVeXeDataContext db = new BanVeXeDataContext())
            {
                KhachHang existKH = db.KhachHangs.Where(k => k.MaKH.Equals(txtMAKH.Text)).FirstOrDefault();
                if(existKH==null)
                {
                    MessageBox.Show("Không có thông tin khách hàng này!");
                    return;
                }
                else
                {
                    VeXe vx = db.VeXes.Where(v => v.MaKH.Equals(txtMAKH.Text)).FirstOrDefault();
                    if(vx!=null)
                    {
                        MessageBox.Show("Không thể xóa khách hàng này!");
                        return;
                    }
                    else
                    {
                        db.KhachHangs.DeleteOnSubmit(existKH);
                        db.SubmitChanges();
                    }
                }
                load_DataKH();
            }
        }

        private void btnDongKH_Click(object sender, EventArgs e)
        {
            this.Close();
            frmMain main = new frmMain();
            main.Show();
        }
        private void load_DataKH()
        {
            using (BanVeXeDataContext db= new BanVeXeDataContext())
            {
                var data = db.KhachHangs.Select(k => new
                {
                    MAKH = k.MaKH,
                    TENKH = k.TenKH,
                    NGSINH = k.NgaySinh,
                    DIACHI = k.DiaChi
                });
                dgvTTKH.DataSource = data;
            }    
        }    
    }
}
