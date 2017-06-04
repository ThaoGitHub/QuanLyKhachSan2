using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;

namespace BTThucTapNhom
{
    public partial class frmThietBi : Form
    {
        public frmThietBi()
        {
            InitializeComponent();
        }

        ThietBi tb = new ThietBi();
        string ma_tb;

        public void LoadData()
        {
            DataTable dt = new DataTable();
            dt = tb.ShowTB();
            dtgvTB.DataSource = dt;
        }

        private void frmThietBi_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dtgvTB_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            for (int i = 0; i < dtgvTB.RowCount; i++)
            {
                dtgvTB.Rows[i].Cells[0].Value = i + 1;
            }
        }

        private void dtgvTB_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int dong;
            dong = e.RowIndex;
            ma_tb = dtgvTB.Rows[dong].Cells[1].Value.ToString();
            this.txtMaTB.Text = dtgvTB.Rows[dong].Cells[1].Value.ToString();
            this.txtMaPhongTB.Text = dtgvTB.Rows[dong].Cells[2].Value.ToString();
            this.txtTenTB.Text = dtgvTB.Rows[dong].Cells[3].Value.ToString();
            this.txtSoLuongTB.Text = dtgvTB.Rows[dong].Cells[3].Value.ToString();
        }

        private void frmThietBi_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void btnThemTB_Click(object sender, EventArgs e)
        {
            frmThemTB frmthemtb = new frmThemTB();
            frmthemtb.FormClosed += frmThietBi_FormClosed;
            frmthemtb.Show();
        }

        private void btnSuaTB_Click(object sender, EventArgs e)
        {
            if (txtMaTB.Text.Length == 0)
                MessageBox.Show("Bạn chưa chọn mã thiết bị để sửa!");
            else
                if (txtMaTB.Text.Length > 5)
                MessageBox.Show("Mã phòng không được dài quá 5 kí tự!");
            else
                if (txtMaPhongTB.Text.Length == 0)
                MessageBox.Show("Tên loại phòng không được bỏ trống!");
            else
            {
                tb.SuaTB(
                ma_tb,
                txtMaTB.Text,
                txtMaPhongTB.Text,
                txtTenTB.Text,
                txtSoLuongTB.Text);
                MessageBox.Show("Sửa thành công!");
                LoadData();
            }
        }

        private void btnXoaTB_Click(object sender, EventArgs e)
        {
            if (this.txtMaTB.TextLength == 0)
                MessageBox.Show("Bạn cần chọn nhân viên để xóa");
            else
            {
                tb.XoaTB(ma_tb);
                MessageBox.Show("Đã xóa thành công!");
                frmThietBi_Load(sender, e);
            }
        }

        private void btnThoatTB_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Thông Báo !", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                frmChinh frmchinh = new frmChinh();
                frmchinh.Show();
                this.Hide();
            }
        }
    }
}
