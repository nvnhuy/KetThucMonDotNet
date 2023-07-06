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
    public partial class frmDatve : Form
    {
        public frmDatve()
        {
            InitializeComponent();
        }
        String[] vitri = { "A1", "A2", "A3", "A4", "A5", "B1", "B2", "B3", "B4", "B5", "C1", "C2", "C3", "C4", "C5" };
        private void btnVexe_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmVexe fvx = new frmVexe();
            fvx.Show();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
            frmMain main = new frmMain();
            main.Show();
        }

        private void frmDatve_Load(object sender, EventArgs e)
        {
            load_cboCX();
            load_cbo_Vitri();
        }
                
        private void btnKiemtra_Click(object sender, EventArgs e)
        {
            using (BanVeXeDataContext db= new BanVeXeDataContext())
            {
                var data = from v in db.VeXes
                           where v.MaChuyen == cboCX.SelectedValue.ToString()
                                    && v.NgayDi == dateTimePicker1.Value.Date
                           select new
                           {
                               MAKH = v.MaKH,
                               CH = v.ChuyenXe.TenChuyen,
                               NGDI = v.NgayDi,
                               VITRI = v.ViTri
                           };
                dgvVe.DataSource = data;
            }    
        }
        private void btnDatve_Click(object sender, EventArgs e)
        {
            string cbovt = cboVitri.SelectedValue.ToString();
            string cbocx = cboCX.SelectedValue.ToString();
            using (BanVeXeDataContext db = new BanVeXeDataContext())
            {
                bool exitsVitri = db.VeXes.Where(v => v.MaChuyen.Equals(cbocx) 
                                && v.NgayDi.Equals(dateTimePicker1.Value.Date)
                                && v.ViTri.Equals(cbovt))
                                .Count() > 0;
                if (exitsVitri)
                {
                    MessageBox.Show("Vị trí này đã được mua");
                    return;
                }
                else
                {
                    bool existKH = db.KhachHangs.Where(v => v.MaKH.Equals(txtMaKH.Text)).Count() == 0;
                    bool existKH_VE = db.VeXes.Where(v => v.MaChuyen.Equals(cbocx) 
                                  && v.NgayDi.Equals(dateTimePicker1.Value.Date)                    
                                  && v.MaKH.Equals(txtMaKH.Text))
                                    .Count() > 0;
                    if (existKH)
                    {
                        MessageBox.Show("Khách hàng không tồn tại");
                        return;
                    }
                    else if(existKH_VE)
                    {
                        MessageBox.Show("Khách hàng này đã mua vé rồi");
                        return;
                    }    
                    else
                    {
                        if(dateTimePicker1.Value.Date < DateTime.Today)
                        {
                            MessageBox.Show("Ngay di khong hop le");
                            return;
                        }
                        else
                        {
                            var xacnhan = MessageBox.Show("Thông tin vé xe:\n" +
                       cboCX.Text + "\n" +
                       dateTimePicker1.Value.Date.ToString() + "\n" +
                       cboVitri.Text,
                       "Xác nhận thông tin vé", MessageBoxButtons.YesNo);
                            if (xacnhan == DialogResult.Yes)
                            {
                                VeXe newVe = new VeXe();
                                newVe.MaKH = txtMaKH.Text;
                                newVe.MaChuyen = cbocx;
                                newVe.NgayDi = dateTimePicker1.Value.Date;
                                newVe.ViTri = cbovt;
                                db.VeXes.InsertOnSubmit(newVe);
                                db.SubmitChanges();
                            }
                        }
                        
                    }
                     
                }
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
        private void load_cbo_Vitri()
        {            
            var data = vitri.ToArray();
            cboVitri.DataSource = data;
        }

        private void btnSuave_Click(object sender, EventArgs e)
        {
            string makh = txtMaKH.Text;
            string cbovt = cboVitri.SelectedValue.ToString();
            string cbocx = cboCX.SelectedValue.ToString();
            using (BanVeXeDataContext db = new BanVeXeDataContext())
            {
                bool existKH = db.KhachHangs.Where(v => v.MaKH.Equals(txtMaKH.Text)).Count() == 0;
                bool existKH_VE = db.VeXes.Where(v => v.MaChuyen.Equals(cbocx)
                && v.MaKH.Equals(txtMaKH.Text)
                && v.NgayDi.Equals(dateTimePicker1.Value.Date))
                .Count() == 0;
                if (makh=="")
                {
                    MessageBox.Show("Bạn chưa nhập mã khách hàng");
                    return;
                }    
                else if(existKH)
                {
                    MessageBox.Show("Khách hàng không tồn tại");
                    return;
                }    
                else if(existKH_VE)
                {
                    MessageBox.Show("Khách hàng chưa mua vé");
                    return;
                }
                else
                {
                    bool exitsVitri = db.VeXes.Where(v => v.MaChuyen.Equals(cbocx))
                    .Where(v => v.NgayDi.Equals(dateTimePicker1.Value.Date)&& v.ViTri.Equals(cbovt))
                    .Count() > 0;
                    if (exitsVitri)
                    {
                        MessageBox.Show("Vị trí nãy đã đưuọc mua");
                        return;
                    }    
                    else 
                    {
                        VeXe capNhatVe = db.VeXes.Single(v => v.MaKH == makh);
                        capNhatVe.MaChuyen = cbocx;
                        capNhatVe.NgayDi = dateTimePicker1.Value.Date;
                        capNhatVe.ViTri = cbovt;                        
                        db.SubmitChanges();
                    }                    
                }
            }    
        }
    }
        
}
