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
    public partial class frmNhanVien : Form
    {
        public frmNhanVien()
        {
            InitializeComponent();
        }

        NhanVien nv = new NhanVien();
        string Ma_nv;
        public void LoadData()
        {
            DataTable dt = new DataTable();
            dt = nv.ShowNV();
            dtgvNV.DataSource = dt;
        }
        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dtgvNV_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            for (int i = 0; i < dtgvNV.RowCount; i++)
            {
                dtgvNV.Rows[i].Cells[0].Value = i + 1;
            }
        }

        private void dtgvNV_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int dong;
            dong = e.RowIndex;
            Ma_nv = dtgvNV.Rows[dong].Cells[1].Value.ToString();
            this.txtMaNV.Text = dtgvNV.Rows[dong].Cells[1].Value.ToString();
            this.txtTenNV.Text = dtgvNV.Rows[dong].Cells[2].Value.ToString();
            this.dateNSNV.Text = dtgvNV.Rows[dong].Cells[3].Value.ToString();
            if (rdbtnNam.Checked)
            {
                this.rdbtnNam.Text = dtgvNV.Rows[dong].Cells[4].Value.ToString();
            }
            else
                this.rdbtnNu.Text = dtgvNV.Rows[dong].Cells[4].Value.ToString();
            this.txtDiaChiNV.Text = dtgvNV.Rows[dong].Cells[5].Value.ToString();
            this.txtSDTNV.Text = dtgvNV.Rows[dong].Cells[6].Value.ToString();
            this.dateNgayVaoLmNV.Text = dtgvNV.Rows[dong].Cells[7].Value.ToString();
            //this.dateNSNV.Text = dtgvNV.Rows[dong].Cells[6].Value.ToString();
            //this.dateNgayVaoLmNV.Text = dtgvNV.Rows[dong].Cells[7].Value.ToString();
        }

        private void btnThemNV_Click(object sender, EventArgs e)
        {
            frmThemNV frmthemnv = new frmThemNV();
            frmthemnv.FormClosed += Frmthemnv_FormClosed;
            frmthemnv.Show();
        }

        private void Frmthemnv_FormClosed(object sender, FormClosedEventArgs e)
        {
            //LoadData();
        }

        private void btnSuaNV_Click(object sender, EventArgs e)
        {
            string gioitinh;
            if (this.txtMaNV.TextLength == 0)
                MessageBox.Show("Bạn cần nhập mã nhân viên để sửa!");
            else
                if (this.txtMaNV.TextLength > 5)
                MessageBox.Show("Mã nhân viên không được dài quá 5 kí tự!");
            else
                if (this.txtTenNV.TextLength == 0)
                MessageBox.Show("Bạn cần nhập tên nhân viên cần sửa!");
            else
            {
                if (rdbtnNam.Checked == true) gioitinh = "Nam";
                else gioitinh = "Nữ";
                nv.SuaNV(
                    Ma_nv,
                    txtMaNV.Text,
                    txtTenNV.Text,
                    dateNSNV.Value,
                    gioitinh,
                    txtDiaChiNV.Text,
                    txtSDTNV.Text,
                    dateNgayVaoLmNV.Value
                    );
                MessageBox.Show("Đã sửa thành công!");
                LoadData();
            }
        }

        private void btnXoaNV_Click(object sender, EventArgs e)
        {
            if (this.txtMaNV.TextLength == 0)
                MessageBox.Show("Bạn cần chọn nhân viên để xóa");
            else
            {
                nv.XoaNV(Ma_nv);
                MessageBox.Show("Đã xóa thành công!");
                frmNhanVien_Load(sender, e);
            }
        }

        private void btnThoatNV_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát?", "Thông Báo !", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                frmChinh frmchinh = new frmChinh();
                frmchinh.Show();
                this.Hide();
            }
        }
    }
}
