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
    public partial class frmTuyenxe : Form
    {
        public frmTuyenxe()
        {
            InitializeComponent();
        }

        private void btnDongTX_Click(object sender, EventArgs e)
        {
            this.Close();
            frmMain main = new frmMain();
            main.Show();
        }

        private void frmTuyenxe_Load(object sender, EventArgs e)
        {
            load_DataTX();
        }
        private void btnTimTX_Click(object sender, EventArgs e)
        {
            using (BanVeXeDataContext db = new BanVeXeDataContext())
            {
                if (txtMaTuyen.Text != "")
                {
                    var timkh = db.TuyenXes.Where(t=>t.MaTuyen == txtMaTuyen.Text)
                            .Select(t => new
                            {
                                MATUYEN = t.MaTuyen,
                                TENTUYEN = t.TenTuyen,
                                GIAVE = t.GiaVe
                            });
                    dgvTX.DataSource = timkh;
                }
                else
                {
                    load_DataTX();
                }

            }
        }
        private void btnCapnhatTX_Click(object sender, EventArgs e)
        {
            using (BanVeXeDataContext db = new BanVeXeDataContext())
            {
                if (txtMaTuyen.Text == null)
                {
                    MessageBox.Show("Bạn chưa nhập mã tuyến!");
                    return;
                }
                else
                {
                    TuyenXe capnhatTX = db.TuyenXes.Single(t=>t.MaTuyen == txtMaTuyen.Text);
                    capnhatTX.TenTuyen = txtTenTuyen.Text;
                    capnhatTX.GiaVe = int.Parse(txtGiaVe.Text);                    
                }
                db.SubmitChanges();
                load_DataTX();
            }
        }

        private void btnXoaTX_Click(object sender, EventArgs e)
        {
            using (BanVeXeDataContext db = new BanVeXeDataContext())
            {
                TuyenXe existTX = db.TuyenXes.Where(t=>t.MaTuyen.Equals(txtMaTuyen.Text)).FirstOrDefault();
                if (existTX == null)
                {
                    MessageBox.Show("Không có thông tin chuyến xe này!");
                    return;
                }
                else
                {
                    ChuyenXe cx = db.ChuyenXes.Where(c => c.MaTuyen.Equals(txtMaTuyen.Text)).FirstOrDefault();
                    if (cx != null)
                    {
                        MessageBox.Show("Không thể xóa tuyến xe này!");
                        return;
                    }
                    else
                    {
                        db.TuyenXes.DeleteOnSubmit(existTX);
                        db.SubmitChanges();
                    }
                }
                load_DataTX();
            }
        }

        private void btnThemTX_Click(object sender, EventArgs e)
        {
            using (BanVeXeDataContext db = new BanVeXeDataContext())
            {
                bool existTX = db.TuyenXes.Where(k => k.MaTuyen == txtMaTuyen.Text).Count() > 0;
                if (existTX)
                {
                    MessageBox.Show("Tuyến xe này đã tồn tại");
                    return;
                }
                else
                {
                    TuyenXe newTX = new TuyenXe();
                    newTX.MaTuyen = txtMaTuyen.Text;
                    newTX.TenTuyen = txtTenTuyen.Text;
                    newTX.GiaVe = int.Parse(txtGiaVe.Text);
                    db.TuyenXes.InsertOnSubmit(newTX);
                    db.SubmitChanges();
                }
                load_DataTX();
            }
        }
        private void load_DataTX()
        {
            using (BanVeXeDataContext db = new BanVeXeDataContext())
            {
                var data = db.TuyenXes.Select(t => new
                {
                    MATUYEN= t.MaTuyen,
                    TENTUYEN=t.TenTuyen,
                    GIAVE=t.GiaVe
                });
                dgvTX.DataSource = data;
            }
        }

        
    }
}
