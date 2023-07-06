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
    public partial class frmXe : Form
    {
        public frmXe()
        {
            InitializeComponent();
        }

        private void frmXe_Load(object sender, EventArgs e)
        {
            load_CBOTX();
            load_DataXe();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            using (BanVeXeDataContext db= new BanVeXeDataContext())
            {
                bool existsXe = db.Xes.Where(x => x.MaXe.Equals(txtMAXE.Text)).Count() > 0;
                bool ktTaixe = db.Xes.Where(x => x.MaTX.Equals(cboTAIXE.SelectedValue)).Count() == 1;
                if(existsXe)
                {
                    MessageBox.Show("Mã xe này đã tồn tại");
                    return;
                }
                else
                {
                    Xe newXe = new Xe();
                    newXe.MaXe = txtMAXE.Text;
                    newXe.TTXe = txtTTXE.Text;
                    if(!ktTaixe)
                    {
                        newXe.MaTX = cboTAIXE.SelectedValue.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Tài xế này đã nhận xe");
                        return;                        
                    }
                    db.Xes.InsertOnSubmit(newXe);
                    db.SubmitChanges();
                }
                
                load_DataXe();
            }    
        }

        private void btnCapnhat_Click(object sender, EventArgs e)
        {
            using (BanVeXeDataContext db = new BanVeXeDataContext())
            {
                bool ktTaixe = db.Xes.Where(x => x.MaTX.Equals(cboTAIXE.SelectedValue)).Count() == 1;
                if (txtMAXE.Text==null)
                {
                    MessageBox.Show("Bạn chưa nhập mã xe");
                    return;
                }
                else
                {
                    Xe capnhatXe = db.Xes.Single(x => x.MaXe.Equals(txtMAXE.Text));
                    capnhatXe.TTXe = txtTTXE.Text;  
                    if(!ktTaixe)
                    {
                        capnhatXe.MaTX = cboTAIXE.SelectedValue.ToString();
                    }
                    else {
                        MessageBox.Show("Tài xế này đã nhận xe");
                            }
                }
                db.SubmitChanges();
                load_DataXe();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maxe = txtMAXE.Text;
            using (BanVeXeDataContext db = new BanVeXeDataContext())
            {
                Xe existXe = db.Xes.Where(x => x.MaXe.Equals(maxe)).FirstOrDefault();
                if (existXe == null)
                {
                    MessageBox.Show("Không có chuyến xe này");
                    return;
                }
                else
                {
                    ChuyenXe cx = db.ChuyenXes.Where(c => c.MaXe.Equals(maxe)).FirstOrDefault();
                    if(cx!=null)
                    {
                        MessageBox.Show("Xe này đang chạy trong 1 chuyến xe\nBạn không thể xóa",
                                            "Thông báo");
                        return;
                    }
                    else
                    {
                        db.Xes.DeleteOnSubmit(existXe);
                        db.SubmitChanges();
                    }
                    load_DataXe();
                }
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
            frmMain main = new frmMain();
            main.Show();

        }
        private void load_CBOTX()
        {
            using (BanVeXeDataContext db= new BanVeXeDataContext())
            {
                var txe = db.Nhanviens.Where(t=>t.MaCV=="TX").Select(t=>t);
                cboTAIXE.DataSource = txe;
                cboTAIXE.DisplayMember = "TenNV";
                cboTAIXE.ValueMember = "MaNV";
            }    
        }
        private void load_DataXe()
        {
            using (BanVeXeDataContext db = new BanVeXeDataContext())
            {
                var data = db.Xes.Select(x => new { 
                    MAXE= x.MaXe,
                    TTXE= x.TTXe,
                    TENTX= x.Nhanvien.TenNV
                });
                dgvXe.DataSource= data;
            }    
        }
    }
}
