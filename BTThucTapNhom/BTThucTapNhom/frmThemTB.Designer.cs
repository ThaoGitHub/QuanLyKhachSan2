namespace BTThucTapNhom
{
    partial class frmThemTB
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnGhiNhanTB = new System.Windows.Forms.Button();
            this.btnHuyTB = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txtTenTBfrmThemTB = new System.Windows.Forms.TextBox();
            this.txtSLTBfrmThemTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã thiết bị:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã phòng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên thiết bị:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Số lượng:";
            // 
            // btnGhiNhanTB
            // 
            this.btnGhiNhanTB.Location = new System.Drawing.Point(75, 260);
            this.btnGhiNhanTB.Name = "btnGhiNhanTB";
            this.btnGhiNhanTB.Size = new System.Drawing.Size(94, 35);
            this.btnGhiNhanTB.TabIndex = 4;
            this.btnGhiNhanTB.Text = "GHI NHẬN";
            this.btnGhiNhanTB.UseVisualStyleBackColor = true;
            this.btnGhiNhanTB.Click += new System.EventHandler(this.btnGhiNhanTB_Click);
            // 
            // btnHuyTB
            // 
            this.btnHuyTB.Location = new System.Drawing.Point(256, 260);
            this.btnHuyTB.Name = "btnHuyTB";
            this.btnHuyTB.Size = new System.Drawing.Size(87, 35);
            this.btnHuyTB.TabIndex = 5;
            this.btnHuyTB.Text = "HỦY";
            this.btnHuyTB.UseVisualStyleBackColor = true;
            this.btnHuyTB.Click += new System.EventHandler(this.btnHuyTB_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(106, 42);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(276, 20);
            this.textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(106, 89);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(276, 20);
            this.textBox2.TabIndex = 7;
            // 
            // txtTenTBfrmThemTB
            // 
            this.txtTenTBfrmThemTB.Location = new System.Drawing.Point(106, 142);
            this.txtTenTBfrmThemTB.Name = "txtTenTBfrmThemTB";
            this.txtTenTBfrmThemTB.Size = new System.Drawing.Size(276, 20);
            this.txtTenTBfrmThemTB.TabIndex = 8;
            // 
            // txtSLTBfrmThemTB
            // 
            this.txtSLTBfrmThemTB.Location = new System.Drawing.Point(106, 194);
            this.txtSLTBfrmThemTB.Name = "txtSLTBfrmThemTB";
            this.txtSLTBfrmThemTB.Size = new System.Drawing.Size(276, 20);
            this.txtSLTBfrmThemTB.TabIndex = 9;
            // 
            // frmThemTB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 311);
            this.Controls.Add(this.txtSLTBfrmThemTB);
            this.Controls.Add(this.txtTenTBfrmThemTB);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnHuyTB);
            this.Controls.Add(this.btnGhiNhanTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmThemTB";
            this.Text = "frmThemTB";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnGhiNhanTB;
        private System.Windows.Forms.Button btnHuyTB;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox txtTenTBfrmThemTB;
        private System.Windows.Forms.TextBox txtSLTBfrmThemTB;
    }
}