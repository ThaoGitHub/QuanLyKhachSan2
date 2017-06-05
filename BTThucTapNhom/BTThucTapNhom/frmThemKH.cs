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
    public partial class frmThemKH : Form
    {
        public frmThemKH()
        {
            InitializeComponent();
        }

        private void frmThemKH_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        KhachHang kh = new KhachHang();
        private void btnGhiNhanThemKH_Click(object sender, EventArgs e)
        {
            string gioitinh;
            if (txtMaKHThemKH.Text.Length == 0)
                MessageBox.Show("Mã khách hàng không được để trống!");
            else
                if (txtMaKHThemKH.Text.Length > 5)
                MessageBox.Show("Mã khách hàng không được dài quá 5 kí tự!");
            else
                if (txtTenKHThemKH.Text.Length == 0)
                MessageBox.Show("Tên khách hàng không được để trống!");
                else
                {
                    try
                    {
                    if (rdbtnNamThemKH.Checked == true)
                        gioitinh = "Nam";
                    else
                        gioitinh = "Nữ";
                    kh.InsertKH(
                    txtMaKHThemKH.Text,
                    txtTenKHThemKH.Text,
                    gioitinh,
                    txtDCKHThemKH.Text,
                    txtSoCMNDKHThemKH.Text,
                    txtSDTKHThemKH.Text,
                    cbbQTKHThemKH.Text
                    );
                    MessageBox.Show("Them thanh cong!");
                    }
                    catch 
                    {
                    MessageBox.Show("Them that bai!");
                    }
                }
        }

        private void btnHuyThemKH_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
