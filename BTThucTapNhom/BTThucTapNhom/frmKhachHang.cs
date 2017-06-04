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
    public partial class frmKhachHang : Form
    {
        public frmKhachHang()
        {
            InitializeComponent();
        }

        KhachHang kh = new KhachHang();
        string ma_kh;
        public void LoadData()
        {
            DataTable dt = new DataTable();
            dt = kh.ShowKH();
            dtgvKH.DataSource = dt;
        }

        private void dtgvKH_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            string quoctich;
            quoctich = cbboxQuocTichKH.Text;
            var qt = cbboxQuocTichKH.GetItemText(cbboxQuocTichKH.SelectedItem);
            
            int dong;
            dong = e.RowIndex;
            ma_kh = dtgvKH.Rows[dong].Cells[1].Value.ToString();
            this.txtMaKH.Text = dtgvKH.Rows[dong].Cells[1].Value.ToString();
            this.txtTenKH.Text = dtgvKH.Rows[dong].Cells[2].Value.ToString();
            if(rdbtnNamKH.Checked)
            {
                this.rdbtnNamKH.Text = dtgvKH.Rows[dong].Cells[3].Value.ToString();
            }
            else
                this.rdbtnNuKH.Text = dtgvKH.Rows[dong].Cells[3].Value.ToString();
            this.txtDiaChiKH.Text = dtgvKH.Rows[dong].Cells[4].Value.ToString();
            this.txtSoCMNDKH.Text = dtgvKH.Rows[dong].Cells[5].Value.ToString();
            this.txtSoDTKH.Text = dtgvKH.Rows[dong].Cells[6].Value.ToString();
            qt = dtgvKH.Rows[dong].Cells[7].Value.ToString();
        }

        private void dtgvKH_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            for (int i = 0; i < dtgvKH.RowCount; i++)
            {
                dtgvKH.Rows[i].Cells[0].Value = i + 1;
            }
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnThemKH_Click(object sender, EventArgs e)
        {
            frmThemKH frmthemkh = new frmThemKH();
            frmthemkh.FormClosed += frmThemKH_FormClosed;
            frmthemkh.Show();
        }
        private void frmThemKH_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void btnSuaKH_Click(object sender, EventArgs e)
        {
            string gioitinh;
            if (txtMaKH.Text.Length == 0)
                MessageBox.Show("Bạn chưa chọn mã khách hàng để sửa!");
            else
                if (txtMaKH.Text.Length > 5)
                MessageBox.Show("Mã khách hàng không được dài quá 5 kí tự!");
            else
                if (txtTenKH.Text.Length == 0)
                MessageBox.Show("Tên khách hàng không được để trống!");
            else
            {
                    if (rdbtnNamKH.Checked == true)
                        gioitinh = "Nam";
                    else
                        gioitinh = "Nữ";
                    kh.SuaTTKH(
                    ma_kh,
                    txtMaKH.Text,
                    txtTenKH.Text,
                    gioitinh,
                    txtDiaChiKH.Text,
                    txtSoCMNDKH.Text,
                    txtSoDTKH.Text,
                    cbboxQuocTichKH.Text
                    );
                    MessageBox.Show("Sửa thành công!");
                    LoadData();
            }
        }

        private void btnXoaKH_Click(object sender, EventArgs e)
        {
            if (this.txtMaKH.TextLength == 0)
                MessageBox.Show("Bạn cần chọn khách hàng để xóa");
            else
            {
                kh.XoaKH(ma_kh);
                MessageBox.Show("Đã xóa thành công!");
                frmKhachHang_Load(sender, e);
            }
        }

        private void btnThoatKH_Click(object sender, EventArgs e)
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
