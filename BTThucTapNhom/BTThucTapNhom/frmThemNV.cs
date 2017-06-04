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
    public partial class frmThemNV : Form
    {
        public frmThemNV()
        {
            InitializeComponent();
        }

        NhanVien nv = new NhanVien();
        private void btnGhiNhanfrmThemNV_Click(object sender, EventArgs e)
        {
            string gioitinh;
            if (this.txtmaNVfrmThem.TextLength == 0)
                MessageBox.Show("Mã nhân viên không được bỏ trống!");
            else
                if (this.txtmaNVfrmThem.TextLength > 5)
                MessageBox.Show("Mã nhân viên không được dài quá 5 kí tự!");
            else
                if (this.txtTenNVfrmThem.TextLength == 0)
                MessageBox.Show("Tên nhân viên không được bỏ trống!");
                    else
                    {
                        try
                        {
                            if (rdbtnNamNV.Checked == true) gioitinh = "Nam";
                            else gioitinh = "Nữ";
                            nv.InsertNV(
                                txtmaNVfrmThem.Text,
                                txtTenNVfrmThem.Text,
                                dateNSNVfrmThem.Value,
                                gioitinh,
                                txtDCNVfrmThem.Text,
                                txtSDTNVfrmThem.Text,
                                dateNgayVaoLamNVfrmThem.Value
                                );
                                MessageBox.Show("Đã thêm thành công!");
                                //frmNhanVien_Load(sender, e);
                        }
                        catch
                        {
                                 MessageBox.Show("Thêm thất bại!");
                        }

                    }
        }

        private void frmThemNV_Load(object sender, EventArgs e)
        {

        }

        private void btnHuyfrmThemNv_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
