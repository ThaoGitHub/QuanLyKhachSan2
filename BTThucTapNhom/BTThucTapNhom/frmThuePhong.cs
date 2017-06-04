using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;

namespace BTThucTapNhom
{
    public partial class frmThuePhong : Form
    {
        public frmThuePhong()
        {
            InitializeComponent();
        }

        QLThuePhong qltp = new QLThuePhong();
        string ma_np;

        private void btnCapNhatThueP_Click(object sender, EventArgs e)
        {
            txtMaNhanPhong.Clear();
            txtMaKH.Clear();
        }

        private void btnThoatThuePhong_Click(object sender, EventArgs e)
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
