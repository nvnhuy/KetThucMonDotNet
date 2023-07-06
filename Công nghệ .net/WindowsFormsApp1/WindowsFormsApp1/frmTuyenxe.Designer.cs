
namespace WindowsFormsApp1
{
    partial class frmTuyenxe
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvTX = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnTimTX = new System.Windows.Forms.Button();
            this.btnCapnhatTX = new System.Windows.Forms.Button();
            this.btnXoaTX = new System.Windows.Forms.Button();
            this.btnThemTX = new System.Windows.Forms.Button();
            this.txtGiaVe = new System.Windows.Forms.TextBox();
            this.txtTenTuyen = new System.Windows.Forms.TextBox();
            this.txtMaTuyen = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDongTX = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTX)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvTX);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(737, 259);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách Tuyến xe";
            // 
            // dgvTX
            // 
            this.dgvTX.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTX.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvTX.Location = new System.Drawing.Point(0, 26);
            this.dgvTX.Name = "dgvTX";
            this.dgvTX.RowHeadersWidth = 51;
            this.dgvTX.RowTemplate.Height = 24;
            this.dgvTX.Size = new System.Drawing.Size(722, 232);
            this.dgvTX.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MATUYEN";
            this.Column1.HeaderText = "Mã Tuyến";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TENTUYEN";
            this.Column2.HeaderText = "Tên Tuyến";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 250;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "GIAVE";
            this.Column3.HeaderText = "Giá Vé";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnTimTX);
            this.groupBox2.Controls.Add(this.btnCapnhatTX);
            this.groupBox2.Controls.Add(this.btnXoaTX);
            this.groupBox2.Controls.Add(this.btnThemTX);
            this.groupBox2.Controls.Add(this.txtGiaVe);
            this.groupBox2.Controls.Add(this.txtTenTuyen);
            this.groupBox2.Controls.Add(this.txtMaTuyen);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.Location = new System.Drawing.Point(1, 273);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(721, 209);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin Tuyến xe";
            // 
            // btnTimTX
            // 
            this.btnTimTX.Location = new System.Drawing.Point(15, 160);
            this.btnTimTX.Name = "btnTimTX";
            this.btnTimTX.Size = new System.Drawing.Size(150, 30);
            this.btnTimTX.TabIndex = 2;
            this.btnTimTX.Text = "Tìm";
            this.btnTimTX.UseVisualStyleBackColor = true;
            this.btnTimTX.Click += new System.EventHandler(this.btnTimTX_Click);
            // 
            // btnCapnhatTX
            // 
            this.btnCapnhatTX.Location = new System.Drawing.Point(190, 160);
            this.btnCapnhatTX.Name = "btnCapnhatTX";
            this.btnCapnhatTX.Size = new System.Drawing.Size(150, 30);
            this.btnCapnhatTX.TabIndex = 2;
            this.btnCapnhatTX.Text = "Cập nhật";
            this.btnCapnhatTX.UseVisualStyleBackColor = true;
            this.btnCapnhatTX.Click += new System.EventHandler(this.btnCapnhatTX_Click);
            // 
            // btnXoaTX
            // 
            this.btnXoaTX.Location = new System.Drawing.Point(368, 160);
            this.btnXoaTX.Name = "btnXoaTX";
            this.btnXoaTX.Size = new System.Drawing.Size(150, 30);
            this.btnXoaTX.TabIndex = 2;
            this.btnXoaTX.Text = "Xóa";
            this.btnXoaTX.UseVisualStyleBackColor = true;
            this.btnXoaTX.Click += new System.EventHandler(this.btnXoaTX_Click);
            // 
            // btnThemTX
            // 
            this.btnThemTX.Location = new System.Drawing.Point(550, 160);
            this.btnThemTX.Name = "btnThemTX";
            this.btnThemTX.Size = new System.Drawing.Size(150, 30);
            this.btnThemTX.TabIndex = 2;
            this.btnThemTX.Text = "Thêm";
            this.btnThemTX.UseVisualStyleBackColor = true;
            this.btnThemTX.Click += new System.EventHandler(this.btnThemTX_Click);
            // 
            // txtGiaVe
            // 
            this.txtGiaVe.Location = new System.Drawing.Point(500, 32);
            this.txtGiaVe.Name = "txtGiaVe";
            this.txtGiaVe.Size = new System.Drawing.Size(200, 27);
            this.txtGiaVe.TabIndex = 1;
            // 
            // txtTenTuyen
            // 
            this.txtTenTuyen.Location = new System.Drawing.Point(115, 80);
            this.txtTenTuyen.Name = "txtTenTuyen";
            this.txtTenTuyen.Size = new System.Drawing.Size(250, 27);
            this.txtTenTuyen.TabIndex = 1;
            // 
            // txtMaTuyen
            // 
            this.txtMaTuyen.Location = new System.Drawing.Point(115, 30);
            this.txtMaTuyen.Name = "txtMaTuyen";
            this.txtMaTuyen.Size = new System.Drawing.Size(250, 27);
            this.txtMaTuyen.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(392, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Giá vé";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên Tuyến";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Tuyến";
            // 
            // btnDongTX
            // 
            this.btnDongTX.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDongTX.Location = new System.Drawing.Point(551, 500);
            this.btnDongTX.Name = "btnDongTX";
            this.btnDongTX.Size = new System.Drawing.Size(150, 30);
            this.btnDongTX.TabIndex = 2;
            this.btnDongTX.Text = "Đóng";
            this.btnDongTX.UseVisualStyleBackColor = true;
            this.btnDongTX.Click += new System.EventHandler(this.btnDongTX_Click);
            // 
            // frmTuyenxe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 553);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnDongTX);
            this.Name = "frmTuyenxe";
            this.Text = "frmTuyenxe";
            this.Load += new System.EventHandler(this.frmTuyenxe_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTX)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvTX;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGiaVe;
        private System.Windows.Forms.TextBox txtTenTuyen;
        private System.Windows.Forms.TextBox txtMaTuyen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTimTX;
        private System.Windows.Forms.Button btnCapnhatTX;
        private System.Windows.Forms.Button btnXoaTX;
        private System.Windows.Forms.Button btnThemTX;
        private System.Windows.Forms.Button btnDongTX;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}