
namespace WindowsFormsApp1
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDangxuat = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnBanve = new System.Windows.Forms.Button();
            this.btnNV = new System.Windows.Forms.Button();
            this.btnXe = new System.Windows.Forms.Button();
            this.btnVX = new System.Windows.Forms.Button();
            this.btnCX = new System.Windows.Forms.Button();
            this.btnKH = new System.Windows.Forms.Button();
            this.btnTX = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1186, 73);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(320, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(530, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "ỨNG DỤNG BÁN VÉ XE KHÁCH";
            // 
            // btnDangxuat
            // 
            this.btnDangxuat.Location = new System.Drawing.Point(59, 453);
            this.btnDangxuat.Name = "btnDangxuat";
            this.btnDangxuat.Size = new System.Drawing.Size(150, 40);
            this.btnDangxuat.TabIndex = 2;
            this.btnDangxuat.Text = "Đăng xuất";
            this.btnDangxuat.UseVisualStyleBackColor = true;
            this.btnDangxuat.Click += new System.EventHandler(this.btnDangxuat_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SpringGreen;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.btnDangxuat);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 73);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(270, 510);
            this.panel2.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Beige;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Location = new System.Drawing.Point(35, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // btnBanve
            // 
            this.btnBanve.BackColor = System.Drawing.Color.SpringGreen;
            this.btnBanve.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnBanve.Image = ((System.Drawing.Image)(resources.GetObject("btnBanve.Image")));
            this.btnBanve.Location = new System.Drawing.Point(914, 91);
            this.btnBanve.Name = "btnBanve";
            this.btnBanve.Size = new System.Drawing.Size(260, 200);
            this.btnBanve.TabIndex = 4;
            this.btnBanve.Text = "Đặt vé";
            this.btnBanve.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBanve.UseVisualStyleBackColor = false;
            this.btnBanve.Click += new System.EventHandler(this.btnBanve_Click);
            // 
            // btnNV
            // 
            this.btnNV.BackColor = System.Drawing.Color.SpringGreen;
            this.btnNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnNV.Image = ((System.Drawing.Image)(resources.GetObject("btnNV.Image")));
            this.btnNV.Location = new System.Drawing.Point(614, 91);
            this.btnNV.Name = "btnNV";
            this.btnNV.Size = new System.Drawing.Size(250, 200);
            this.btnNV.TabIndex = 4;
            this.btnNV.Text = "Thông tin Nhân viên";
            this.btnNV.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNV.UseVisualStyleBackColor = false;
            this.btnNV.Click += new System.EventHandler(this.btnNV_Click);
            // 
            // btnXe
            // 
            this.btnXe.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnXe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXe.Image = ((System.Drawing.Image)(resources.GetObject("btnXe.Image")));
            this.btnXe.Location = new System.Drawing.Point(302, 316);
            this.btnXe.Name = "btnXe";
            this.btnXe.Size = new System.Drawing.Size(200, 250);
            this.btnXe.TabIndex = 4;
            this.btnXe.Text = "Quản lý Xe";
            this.btnXe.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnXe.UseVisualStyleBackColor = false;
            this.btnXe.Click += new System.EventHandler(this.btnXe_Click);
            // 
            // btnVX
            // 
            this.btnVX.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnVX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnVX.Image = ((System.Drawing.Image)(resources.GetObject("btnVX.Image")));
            this.btnVX.Location = new System.Drawing.Point(974, 316);
            this.btnVX.Name = "btnVX";
            this.btnVX.Size = new System.Drawing.Size(200, 250);
            this.btnVX.TabIndex = 0;
            this.btnVX.Text = "Thông tin Vé xe";
            this.btnVX.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnVX.UseVisualStyleBackColor = false;
            this.btnVX.Click += new System.EventHandler(this.btnVX_Click);
            // 
            // btnCX
            // 
            this.btnCX.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnCX.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnCX.Image = ((System.Drawing.Image)(resources.GetObject("btnCX.Image")));
            this.btnCX.Location = new System.Drawing.Point(754, 316);
            this.btnCX.Name = "btnCX";
            this.btnCX.Size = new System.Drawing.Size(200, 250);
            this.btnCX.TabIndex = 0;
            this.btnCX.Text = "Thông tin chuyến xe";
            this.btnCX.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCX.UseVisualStyleBackColor = false;
            this.btnCX.Click += new System.EventHandler(this.btnCX_Click);
            // 
            // btnKH
            // 
            this.btnKH.BackColor = System.Drawing.Color.SpringGreen;
            this.btnKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnKH.Image = ((System.Drawing.Image)(resources.GetObject("btnKH.Image")));
            this.btnKH.Location = new System.Drawing.Point(302, 91);
            this.btnKH.Name = "btnKH";
            this.btnKH.Size = new System.Drawing.Size(250, 200);
            this.btnKH.TabIndex = 0;
            this.btnKH.Text = "Thông tin khách hàng";
            this.btnKH.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnKH.UseVisualStyleBackColor = false;
            this.btnKH.Click += new System.EventHandler(this.btnKH_Click);
            // 
            // btnTX
            // 
            this.btnTX.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnTX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTX.Image = ((System.Drawing.Image)(resources.GetObject("btnTX.Image")));
            this.btnTX.Location = new System.Drawing.Point(527, 316);
            this.btnTX.Name = "btnTX";
            this.btnTX.Size = new System.Drawing.Size(200, 250);
            this.btnTX.TabIndex = 0;
            this.btnTX.Text = "Thông tin tuyến xe";
            this.btnTX.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTX.UseVisualStyleBackColor = false;
            this.btnTX.Click += new System.EventHandler(this.btnTX_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1186, 583);
            this.Controls.Add(this.btnBanve);
            this.Controls.Add(this.btnNV);
            this.Controls.Add(this.btnXe);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnVX);
            this.Controls.Add(this.btnCX);
            this.Controls.Add(this.btnKH);
            this.Controls.Add(this.btnTX);
            this.Controls.Add(this.panel1);
            this.Name = "frmMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnTX;
        private System.Windows.Forms.Button btnCX;
        private System.Windows.Forms.Button btnVX;
        private System.Windows.Forms.Button btnKH;
        private System.Windows.Forms.Button btnDangxuat;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnXe;
        private System.Windows.Forms.Button btnNV;
        private System.Windows.Forms.Button btnBanve;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

