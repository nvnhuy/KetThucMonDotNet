
namespace WindowsFormsApp1
{
    partial class frmKhachhang
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
            this.dgvTTKH = new System.Windows.Forms.DataGridView();
            this.MAKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGSINH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIACHI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbTTKH = new System.Windows.Forms.GroupBox();
            this.btnThemKH = new System.Windows.Forms.Button();
            this.btnTimKH = new System.Windows.Forms.Button();
            this.btnXoaKH = new System.Windows.Forms.Button();
            this.btnCapnhatKH = new System.Windows.Forms.Button();
            this.dtpNgaysinh = new System.Windows.Forms.DateTimePicker();
            this.txtDIACHI = new System.Windows.Forms.TextBox();
            this.txtTENKH = new System.Windows.Forms.TextBox();
            this.txtMAKH = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDongKH = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTTKH)).BeginInit();
            this.grbTTKH.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvTTKH
            // 
            this.dgvTTKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTTKH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MAKH,
            this.TENKH,
            this.NGSINH,
            this.DIACHI});
            this.dgvTTKH.Location = new System.Drawing.Point(6, 39);
            this.dgvTTKH.Name = "dgvTTKH";
            this.dgvTTKH.RowHeadersWidth = 51;
            this.dgvTTKH.RowTemplate.Height = 24;
            this.dgvTTKH.Size = new System.Drawing.Size(864, 508);
            this.dgvTTKH.TabIndex = 0;
            // 
            // MAKH
            // 
            this.MAKH.DataPropertyName = "MAKH";
            this.MAKH.HeaderText = "Mã KH";
            this.MAKH.MinimumWidth = 6;
            this.MAKH.Name = "MAKH";
            this.MAKH.Width = 150;
            // 
            // TENKH
            // 
            this.TENKH.DataPropertyName = "TENKH";
            this.TENKH.HeaderText = "Tên KH";
            this.TENKH.MinimumWidth = 6;
            this.TENKH.Name = "TENKH";
            this.TENKH.Width = 200;
            // 
            // NGSINH
            // 
            this.NGSINH.DataPropertyName = "NGSINH";
            this.NGSINH.HeaderText = "Ngày Sinh";
            this.NGSINH.MinimumWidth = 6;
            this.NGSINH.Name = "NGSINH";
            this.NGSINH.Width = 200;
            // 
            // DIACHI
            // 
            this.DIACHI.DataPropertyName = "DIACHI";
            this.DIACHI.HeaderText = "Địa Chỉ";
            this.DIACHI.MinimumWidth = 6;
            this.DIACHI.Name = "DIACHI";
            this.DIACHI.Width = 250;
            // 
            // grbTTKH
            // 
            this.grbTTKH.Controls.Add(this.btnThemKH);
            this.grbTTKH.Controls.Add(this.btnTimKH);
            this.grbTTKH.Controls.Add(this.btnXoaKH);
            this.grbTTKH.Controls.Add(this.btnCapnhatKH);
            this.grbTTKH.Controls.Add(this.dtpNgaysinh);
            this.grbTTKH.Controls.Add(this.txtDIACHI);
            this.grbTTKH.Controls.Add(this.txtTENKH);
            this.grbTTKH.Controls.Add(this.txtMAKH);
            this.grbTTKH.Controls.Add(this.label3);
            this.grbTTKH.Controls.Add(this.label5);
            this.grbTTKH.Controls.Add(this.label4);
            this.grbTTKH.Controls.Add(this.label2);
            this.grbTTKH.Controls.Add(this.label1);
            this.grbTTKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grbTTKH.Location = new System.Drawing.Point(882, 12);
            this.grbTTKH.Name = "grbTTKH";
            this.grbTTKH.Size = new System.Drawing.Size(488, 457);
            this.grbTTKH.TabIndex = 1;
            this.grbTTKH.TabStop = false;
            this.grbTTKH.Text = "Thông tin KH";
            // 
            // btnThemKH
            // 
            this.btnThemKH.Location = new System.Drawing.Point(12, 340);
            this.btnThemKH.Name = "btnThemKH";
            this.btnThemKH.Size = new System.Drawing.Size(136, 36);
            this.btnThemKH.TabIndex = 5;
            this.btnThemKH.Text = "Thêm";
            this.btnThemKH.UseVisualStyleBackColor = true;
            this.btnThemKH.Click += new System.EventHandler(this.btnThemKH_Click);
            // 
            // btnTimKH
            // 
            this.btnTimKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTimKH.Location = new System.Drawing.Point(325, 244);
            this.btnTimKH.Name = "btnTimKH";
            this.btnTimKH.Size = new System.Drawing.Size(136, 36);
            this.btnTimKH.TabIndex = 5;
            this.btnTimKH.Text = "Tìm";
            this.btnTimKH.UseVisualStyleBackColor = true;
            this.btnTimKH.Click += new System.EventHandler(this.btnTimKH_Click);
            // 
            // btnXoaKH
            // 
            this.btnXoaKH.Location = new System.Drawing.Point(325, 340);
            this.btnXoaKH.Name = "btnXoaKH";
            this.btnXoaKH.Size = new System.Drawing.Size(136, 36);
            this.btnXoaKH.TabIndex = 5;
            this.btnXoaKH.Text = "Xóa";
            this.btnXoaKH.UseVisualStyleBackColor = true;
            this.btnXoaKH.Click += new System.EventHandler(this.btnXoaKH_Click);
            // 
            // btnCapnhatKH
            // 
            this.btnCapnhatKH.Location = new System.Drawing.Point(172, 340);
            this.btnCapnhatKH.Name = "btnCapnhatKH";
            this.btnCapnhatKH.Size = new System.Drawing.Size(136, 36);
            this.btnCapnhatKH.TabIndex = 5;
            this.btnCapnhatKH.Text = "Cập nhật";
            this.btnCapnhatKH.UseVisualStyleBackColor = true;
            this.btnCapnhatKH.Click += new System.EventHandler(this.btnCapnhatKH_Click);
            // 
            // dtpNgaysinh
            // 
            this.dtpNgaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaysinh.Location = new System.Drawing.Point(161, 140);
            this.dtpNgaysinh.Name = "dtpNgaysinh";
            this.dtpNgaysinh.Size = new System.Drawing.Size(300, 27);
            this.dtpNgaysinh.TabIndex = 4;
            // 
            // txtDIACHI
            // 
            this.txtDIACHI.Location = new System.Drawing.Point(161, 190);
            this.txtDIACHI.Name = "txtDIACHI";
            this.txtDIACHI.Size = new System.Drawing.Size(300, 27);
            this.txtDIACHI.TabIndex = 3;
            // 
            // txtTENKH
            // 
            this.txtTENKH.Location = new System.Drawing.Point(161, 90);
            this.txtTENKH.Name = "txtTENKH";
            this.txtTENKH.Size = new System.Drawing.Size(300, 27);
            this.txtTENKH.TabIndex = 3;
            // 
            // txtMAKH
            // 
            this.txtMAKH.Location = new System.Drawing.Point(161, 40);
            this.txtMAKH.Name = "txtMAKH";
            this.txtMAKH.Size = new System.Drawing.Size(300, 27);
            this.txtMAKH.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 20);
            this.label3.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Địa chỉ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Ngày sinh";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên khách hàng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã khách hàng";
            // 
            // btnDongKH
            // 
            this.btnDongKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDongKH.Location = new System.Drawing.Point(1207, 505);
            this.btnDongKH.Name = "btnDongKH";
            this.btnDongKH.Size = new System.Drawing.Size(136, 36);
            this.btnDongKH.TabIndex = 5;
            this.btnDongKH.Text = "Đóng";
            this.btnDongKH.UseVisualStyleBackColor = true;
            this.btnDongKH.Click += new System.EventHandler(this.btnDongKH_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvTTKH);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(876, 553);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách khách hàng";
            // 
            // frmKhachhang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1382, 553);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnDongKH);
            this.Controls.Add(this.grbTTKH);
            this.Name = "frmKhachhang";
            this.Text = "frmKhachhang";
            this.Load += new System.EventHandler(this.frmKhachhang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTTKH)).EndInit();
            this.grbTTKH.ResumeLayout(false);
            this.grbTTKH.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTTKH;
        private System.Windows.Forms.GroupBox grbTTKH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMAKH;
        private System.Windows.Forms.TextBox txtTENKH;
        private System.Windows.Forms.Button btnThemKH;
        private System.Windows.Forms.Button btnXoaKH;
        private System.Windows.Forms.Button btnCapnhatKH;
        private System.Windows.Forms.DateTimePicker dtpNgaysinh;
        private System.Windows.Forms.TextBox txtDIACHI;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDongKH;
        private System.Windows.Forms.Button btnTimKH;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGSINH;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIACHI;
    }
}