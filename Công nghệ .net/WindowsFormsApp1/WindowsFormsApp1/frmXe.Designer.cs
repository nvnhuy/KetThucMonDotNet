
namespace WindowsFormsApp1
{
    partial class frmXe
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
            this.dgvXe = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnCapnhat = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.cboTAIXE = new System.Windows.Forms.ComboBox();
            this.txtTTXE = new System.Windows.Forms.TextBox();
            this.txtMAXE = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.MaXee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThongtinXe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenTX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvXe)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvXe
            // 
            this.dgvXe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvXe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaXee,
            this.ThongtinXe,
            this.TenTX});
            this.dgvXe.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvXe.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgvXe.Location = new System.Drawing.Point(0, 0);
            this.dgvXe.Margin = new System.Windows.Forms.Padding(4);
            this.dgvXe.Name = "dgvXe";
            this.dgvXe.RowHeadersWidth = 51;
            this.dgvXe.RowTemplate.Height = 24;
            this.dgvXe.Size = new System.Drawing.Size(578, 200);
            this.dgvXe.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDong);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.btnCapnhat);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.cboTAIXE);
            this.groupBox1.Controls.Add(this.txtTTXE);
            this.groupBox1.Controls.Add(this.txtMAXE);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 208);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(578, 334);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin xe";
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(393, 282);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(150, 40);
            this.btnDong.TabIndex = 3;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(393, 215);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(150, 40);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnCapnhat
            // 
            this.btnCapnhat.Location = new System.Drawing.Point(202, 215);
            this.btnCapnhat.Name = "btnCapnhat";
            this.btnCapnhat.Size = new System.Drawing.Size(150, 40);
            this.btnCapnhat.TabIndex = 3;
            this.btnCapnhat.Text = "Cập nhật";
            this.btnCapnhat.UseVisualStyleBackColor = true;
            this.btnCapnhat.Click += new System.EventHandler(this.btnCapnhat_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(16, 215);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(150, 40);
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // cboTAIXE
            // 
            this.cboTAIXE.FormattingEnabled = true;
            this.cboTAIXE.Location = new System.Drawing.Point(142, 142);
            this.cboTAIXE.Name = "cboTAIXE";
            this.cboTAIXE.Size = new System.Drawing.Size(401, 28);
            this.cboTAIXE.TabIndex = 2;
            // 
            // txtTTXE
            // 
            this.txtTTXE.Location = new System.Drawing.Point(142, 84);
            this.txtTTXE.Name = "txtTTXE";
            this.txtTTXE.Size = new System.Drawing.Size(401, 27);
            this.txtTTXE.TabIndex = 1;
            // 
            // txtMAXE
            // 
            this.txtMAXE.Location = new System.Drawing.Point(142, 41);
            this.txtMAXE.Name = "txtMAXE";
            this.txtMAXE.Size = new System.Drawing.Size(401, 27);
            this.txtMAXE.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tài xế";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Thông tin xe";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã xe";
            // 
            // MaXee
            // 
            this.MaXee.DataPropertyName = "MAXE";
            this.MaXee.HeaderText = "Mã số xe";
            this.MaXee.MinimumWidth = 6;
            this.MaXee.Name = "MaXee";
            this.MaXee.Width = 80;
            // 
            // ThongtinXe
            // 
            this.ThongtinXe.DataPropertyName = "TTXE";
            this.ThongtinXe.HeaderText = "Thông tịn xe";
            this.ThongtinXe.MinimumWidth = 6;
            this.ThongtinXe.Name = "ThongtinXe";
            this.ThongtinXe.Width = 200;
            // 
            // TenTX
            // 
            this.TenTX.DataPropertyName = "TENTX";
            this.TenTX.HeaderText = "Tên Tài xế";
            this.TenTX.MinimumWidth = 6;
            this.TenTX.Name = "TenTX";
            this.TenTX.Width = 200;
            // 
            // frmXe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 542);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvXe);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmXe";
            this.Text = "frmXe";
            this.Load += new System.EventHandler(this.frmXe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvXe)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvXe;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnCapnhat;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.ComboBox cboTAIXE;
        private System.Windows.Forms.TextBox txtTTXE;
        private System.Windows.Forms.TextBox txtMAXE;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaXee;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThongtinXe;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenTX;
    }
}