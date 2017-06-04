namespace BTThucTapNhom
{
    partial class frmThietBi
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
            this.txtMaPhongTB = new System.Windows.Forms.TextBox();
            this.txtSoLuongTB = new System.Windows.Forms.TextBox();
            this.txtTenTB = new System.Windows.Forms.TextBox();
            this.txtMaTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgvTB = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThemTB = new System.Windows.Forms.Button();
            this.btnSuaTB = new System.Windows.Forms.Button();
            this.btnXoaTB = new System.Windows.Forms.Button();
            this.btnThoatTB = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTB)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMaPhongTB);
            this.groupBox1.Controls.Add(this.txtSoLuongTB);
            this.groupBox1.Controls.Add(this.txtTenTB);
            this.groupBox1.Controls.Add(this.txtMaTB);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(2, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(484, 197);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin thiết bị";
            // 
            // txtMaPhongTB
            // 
            this.txtMaPhongTB.Location = new System.Drawing.Point(116, 75);
            this.txtMaPhongTB.Name = "txtMaPhongTB";
            this.txtMaPhongTB.Size = new System.Drawing.Size(359, 20);
            this.txtMaPhongTB.TabIndex = 8;
            // 
            // txtSoLuongTB
            // 
            this.txtSoLuongTB.Location = new System.Drawing.Point(115, 163);
            this.txtSoLuongTB.Name = "txtSoLuongTB";
            this.txtSoLuongTB.Size = new System.Drawing.Size(360, 20);
            this.txtSoLuongTB.TabIndex = 7;
            // 
            // txtTenTB
            // 
            this.txtTenTB.Location = new System.Drawing.Point(115, 119);
            this.txtTenTB.Name = "txtTenTB";
            this.txtTenTB.Size = new System.Drawing.Size(360, 20);
            this.txtTenTB.TabIndex = 6;
            // 
            // txtMaTB
            // 
            this.txtMaTB.Location = new System.Drawing.Point(116, 28);
            this.txtMaTB.Name = "txtMaTB";
            this.txtMaTB.Size = new System.Drawing.Size(359, 20);
            this.txtMaTB.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Số lượng:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tên thiết bị:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mã phòng;";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã thiết bị:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(232, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "THIẾT BỊ";
            // 
            // dtgvTB
            // 
            this.dtgvTB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvTB.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT});
            this.dtgvTB.Location = new System.Drawing.Point(2, 276);
            this.dtgvTB.Name = "dtgvTB";
            this.dtgvTB.Size = new System.Drawing.Size(608, 229);
            this.dtgvTB.TabIndex = 2;
            this.dtgvTB.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvTB_RowEnter);
            this.dtgvTB.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dtgvTB_RowPrePaint);
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            // 
            // btnThemTB
            // 
            this.btnThemTB.Location = new System.Drawing.Point(515, 72);
            this.btnThemTB.Name = "btnThemTB";
            this.btnThemTB.Size = new System.Drawing.Size(75, 23);
            this.btnThemTB.TabIndex = 3;
            this.btnThemTB.Text = "THÊM";
            this.btnThemTB.UseVisualStyleBackColor = true;
            this.btnThemTB.Click += new System.EventHandler(this.btnThemTB_Click);
            // 
            // btnSuaTB
            // 
            this.btnSuaTB.Location = new System.Drawing.Point(515, 125);
            this.btnSuaTB.Name = "btnSuaTB";
            this.btnSuaTB.Size = new System.Drawing.Size(75, 23);
            this.btnSuaTB.TabIndex = 4;
            this.btnSuaTB.Text = "SỬA";
            this.btnSuaTB.UseVisualStyleBackColor = true;
            this.btnSuaTB.Click += new System.EventHandler(this.btnSuaTB_Click);
            // 
            // btnXoaTB
            // 
            this.btnXoaTB.Location = new System.Drawing.Point(515, 178);
            this.btnXoaTB.Name = "btnXoaTB";
            this.btnXoaTB.Size = new System.Drawing.Size(75, 23);
            this.btnXoaTB.TabIndex = 5;
            this.btnXoaTB.Text = "XÓA";
            this.btnXoaTB.UseVisualStyleBackColor = true;
            this.btnXoaTB.Click += new System.EventHandler(this.btnXoaTB_Click);
            // 
            // btnThoatTB
            // 
            this.btnThoatTB.Location = new System.Drawing.Point(515, 232);
            this.btnThoatTB.Name = "btnThoatTB";
            this.btnThoatTB.Size = new System.Drawing.Size(75, 23);
            this.btnThoatTB.TabIndex = 6;
            this.btnThoatTB.Text = "THOÁT";
            this.btnThoatTB.UseVisualStyleBackColor = true;
            this.btnThoatTB.Click += new System.EventHandler(this.btnThoatTB_Click);
            // 
            // frmThietBi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 506);
            this.Controls.Add(this.btnThoatTB);
            this.Controls.Add(this.btnXoaTB);
            this.Controls.Add(this.btnSuaTB);
            this.Controls.Add(this.btnThemTB);
            this.Controls.Add(this.dtgvTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmThietBi";
            this.Text = "frmThietBi";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmThietBi_FormClosed);
            this.Load += new System.EventHandler(this.frmThietBi_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSoLuongTB;
        private System.Windows.Forms.TextBox txtTenTB;
        private System.Windows.Forms.TextBox txtMaTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgvTB;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.Button btnThemTB;
        private System.Windows.Forms.Button btnSuaTB;
        private System.Windows.Forms.Button btnXoaTB;
        private System.Windows.Forms.Button btnThoatTB;
        private System.Windows.Forms.TextBox txtMaPhongTB;
    }
}