namespace BTThucTapNhom
{
    partial class frmThuePhong
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
            this.dateNgayTraPhong = new System.Windows.Forms.DateTimePicker();
            this.dateNgayNhanPhong = new System.Windows.Forms.DateTimePicker();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.txtMaNhanPhong = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgvThueP = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnthemThuePhong = new System.Windows.Forms.Button();
            this.btnSuaThuePhong = new System.Windows.Forms.Button();
            this.btnXoaThuePhong = new System.Windows.Forms.Button();
            this.btnThoatThuePhong = new System.Windows.Forms.Button();
            this.btnCapNhatThueP = new System.Windows.Forms.Button();
            this.cbxMaPhong = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvThueP)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbxMaPhong);
            this.groupBox1.Controls.Add(this.dateNgayTraPhong);
            this.groupBox1.Controls.Add(this.dateNgayNhanPhong);
            this.groupBox1.Controls.Add(this.txtMaKH);
            this.groupBox1.Controls.Add(this.txtMaNhanPhong);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(2, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(453, 273);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin thuê phòng";
            // 
            // dateNgayTraPhong
            // 
            this.dateNgayTraPhong.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateNgayTraPhong.Location = new System.Drawing.Point(118, 244);
            this.dateNgayTraPhong.Name = "dateNgayTraPhong";
            this.dateNgayTraPhong.Size = new System.Drawing.Size(200, 20);
            this.dateNgayTraPhong.TabIndex = 9;
            // 
            // dateNgayNhanPhong
            // 
            this.dateNgayNhanPhong.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateNgayNhanPhong.Location = new System.Drawing.Point(118, 190);
            this.dateNgayNhanPhong.Name = "dateNgayNhanPhong";
            this.dateNgayNhanPhong.Size = new System.Drawing.Size(200, 20);
            this.dateNgayNhanPhong.TabIndex = 8;
            // 
            // txtMaKH
            // 
            this.txtMaKH.Location = new System.Drawing.Point(118, 135);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(326, 20);
            this.txtMaKH.TabIndex = 7;
            // 
            // txtMaNhanPhong
            // 
            this.txtMaNhanPhong.Location = new System.Drawing.Point(118, 32);
            this.txtMaNhanPhong.Name = "txtMaNhanPhong";
            this.txtMaNhanPhong.Size = new System.Drawing.Size(326, 20);
            this.txtMaNhanPhong.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 250);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Ngày trả phòng:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Ngày nhận phòng:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Mã khách hàng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mã phòng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã nhận phòng:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(187, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "QUẢN LÝ THUÊ PHÒNG";
            // 
            // dtgvThueP
            // 
            this.dtgvThueP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvThueP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT});
            this.dtgvThueP.Location = new System.Drawing.Point(2, 355);
            this.dtgvThueP.Name = "dtgvThueP";
            this.dtgvThueP.Size = new System.Drawing.Size(605, 224);
            this.dtgvThueP.TabIndex = 2;
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            // 
            // btnthemThuePhong
            // 
            this.btnthemThuePhong.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnthemThuePhong.Location = new System.Drawing.Point(480, 145);
            this.btnthemThuePhong.Name = "btnthemThuePhong";
            this.btnthemThuePhong.Size = new System.Drawing.Size(90, 32);
            this.btnthemThuePhong.TabIndex = 3;
            this.btnthemThuePhong.Text = "THÊM";
            this.btnthemThuePhong.UseVisualStyleBackColor = true;
            // 
            // btnSuaThuePhong
            // 
            this.btnSuaThuePhong.Location = new System.Drawing.Point(480, 201);
            this.btnSuaThuePhong.Name = "btnSuaThuePhong";
            this.btnSuaThuePhong.Size = new System.Drawing.Size(90, 30);
            this.btnSuaThuePhong.TabIndex = 4;
            this.btnSuaThuePhong.Text = "SỬA";
            this.btnSuaThuePhong.UseVisualStyleBackColor = true;
            // 
            // btnXoaThuePhong
            // 
            this.btnXoaThuePhong.Location = new System.Drawing.Point(480, 256);
            this.btnXoaThuePhong.Name = "btnXoaThuePhong";
            this.btnXoaThuePhong.Size = new System.Drawing.Size(90, 32);
            this.btnXoaThuePhong.TabIndex = 5;
            this.btnXoaThuePhong.Text = "XÓA";
            this.btnXoaThuePhong.UseVisualStyleBackColor = true;
            // 
            // btnThoatThuePhong
            // 
            this.btnThoatThuePhong.Location = new System.Drawing.Point(480, 305);
            this.btnThoatThuePhong.Name = "btnThoatThuePhong";
            this.btnThoatThuePhong.Size = new System.Drawing.Size(90, 34);
            this.btnThoatThuePhong.TabIndex = 6;
            this.btnThoatThuePhong.Text = "THOÁT";
            this.btnThoatThuePhong.UseVisualStyleBackColor = true;
            this.btnThoatThuePhong.Click += new System.EventHandler(this.btnThoatThuePhong_Click);
            // 
            // btnCapNhatThueP
            // 
            this.btnCapNhatThueP.Location = new System.Drawing.Point(480, 83);
            this.btnCapNhatThueP.Name = "btnCapNhatThueP";
            this.btnCapNhatThueP.Size = new System.Drawing.Size(90, 35);
            this.btnCapNhatThueP.TabIndex = 7;
            this.btnCapNhatThueP.Text = "CẬP NHẬT";
            this.btnCapNhatThueP.UseVisualStyleBackColor = true;
            this.btnCapNhatThueP.Click += new System.EventHandler(this.btnCapNhatThueP_Click);
            // 
            // cbxMaPhong
            // 
            this.cbxMaPhong.FormattingEnabled = true;
            this.cbxMaPhong.Location = new System.Drawing.Point(118, 81);
            this.cbxMaPhong.Name = "cbxMaPhong";
            this.cbxMaPhong.Size = new System.Drawing.Size(326, 21);
            this.cbxMaPhong.TabIndex = 10;
            // 
            // frmThuePhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 585);
            this.Controls.Add(this.btnCapNhatThueP);
            this.Controls.Add(this.btnThoatThuePhong);
            this.Controls.Add(this.btnXoaThuePhong);
            this.Controls.Add(this.btnSuaThuePhong);
            this.Controls.Add(this.btnthemThuePhong);
            this.Controls.Add(this.dtgvThueP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmThuePhong";
            this.Text = "frmThuePhong";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvThueP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateNgayTraPhong;
        private System.Windows.Forms.DateTimePicker dateNgayNhanPhong;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.TextBox txtMaNhanPhong;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgvThueP;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.Button btnthemThuePhong;
        private System.Windows.Forms.Button btnSuaThuePhong;
        private System.Windows.Forms.Button btnXoaThuePhong;
        private System.Windows.Forms.Button btnThoatThuePhong;
        private System.Windows.Forms.Button btnCapNhatThueP;
        private System.Windows.Forms.ComboBox cbxMaPhong;
    }
}