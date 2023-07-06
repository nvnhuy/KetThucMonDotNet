﻿using System;
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
    public partial class frmChuyenxe : Form
    {
        public frmChuyenxe()
        {
            InitializeComponent();
        }

        private void btnDongCX_Click(object sender, EventArgs e)
        {
            this.Close();
            frmMain main = new frmMain();
            main.Show();
        }
        private void loadData_CX()
        {
            using (BanVeXeDataContext db = new BanVeXeDataContext())
            {
                var data = db.ChuyenXes.Where(c=>c.MaTuyen==cboTX.SelectedValue.ToString())
                    .Select(c => new
                {
                    MACH = c.MaChuyen,
                    TENCH = c.TenChuyen,                    
                    TTXE = c.Xe.TTXe,
                    GIOXP = c.GioXuatPhat,
                });
                dgvCX.DataSource = data;
            }
        }
        private void load_TX()
        {
            using (BanVeXeDataContext db = new BanVeXeDataContext())
            {
                var data = db.TuyenXes.Select(t => t);
                cboTX.DataSource = data;
                cboTX.DisplayMember = "TenTuyen";
                cboTX.ValueMember = "MaTuyen";

            }
        }
        private void load_Xe()
        {
            using (BanVeXeDataContext db = new BanVeXeDataContext())
            {
                var data = db.Xes.Select(x => x);
                cboXe.DataSource = data;
                cboXe.DisplayMember = "TTXe";
                cboXe.ValueMember = "MaXe";
            }
        }
        private void load_GioXP()
        {
            String[] time = { "14h", "15h", "16h", "17h", "18h", "19h", "20h" };
            var data = time.ToArray();
            cboGioXP.DataSource = data;
            cboGioXP.DisplayMember = "GioXuatPhat";
        }
        private void frmChuyenxe_Load(object sender, EventArgs e)
        {
            load_TX();
            loadData_CX();
            load_Xe();
            load_GioXP();
        }

        private void cboTX_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadData_CX();
        }

        private void btnThemCX_Click(object sender, EventArgs e)
        {
            String macx = txtMACH.Text;
            using (BanVeXeDataContext db = new BanVeXeDataContext())
            {
                bool existCX = db.ChuyenXes.Where(p => p.MaChuyen.Equals(macx)).Count() > 0;

                if (existCX)
                {
                    MessageBox.Show("Mã chuyến xe này đã tồn tại");
                    return;
                }
                ChuyenXe newChuyen = new ChuyenXe();
                newChuyen.MaChuyen = txtMACH.Text;
                newChuyen.TenChuyen = txtTenCH.Text;
                newChuyen.MaTuyen = cboTX.SelectedValue.ToString();
                newChuyen.MaXe = cboXe.SelectedValue.ToString();
                newChuyen.GioXuatPhat = cboGioXP.SelectedValue.ToString();
                db.ChuyenXes.InsertOnSubmit(newChuyen);
                db.SubmitChanges();
                loadData_CX();
            }
        }

        private void btnXoaCX_Click(object sender, EventArgs e)
        {
            string macx = txtMACH.Text;
            using (BanVeXeDataContext db = new BanVeXeDataContext())
            {
                ChuyenXe existCX = db.ChuyenXes.Where(p => p.MaChuyen.Equals(macx)).FirstOrDefault();
                if (existCX == null)
                {
                    MessageBox.Show("Không có chuyến xe này");
                    return;
                }
                else
                {
                    VeXe vx = db.VeXes.Where(p => p.MaChuyen.Equals(macx)).FirstOrDefault();
                    if (vx != null)
                    {
                        MessageBox.Show("Bạn không thể xóa chuyến này!", "Thông báo", MessageBoxButtons.OK);
                        return;
                    }
                    else
                    {
                        db.ChuyenXes.DeleteOnSubmit(existCX);
                        db.SubmitChanges();
                    }
                }
                loadData_CX();

            }
        }

        private void dgvCX_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //var data = dgvCX.SelectedRows[0].Cells["MACH"].Value;

            var data = dgvCX.SelectedCells[0].OwningRow.Cells["MaChuyen"].Value;
            txtMACH.Text = data.ToString();
            //var data2 = dgvCX.SelectedCells[0].OwningRow.Cells["TenChuyenXe"].Value;
            //txtTenCH.Text = data2.ToString();
        }
    }
}
