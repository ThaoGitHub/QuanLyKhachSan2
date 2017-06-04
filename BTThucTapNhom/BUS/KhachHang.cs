using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;

namespace BUS
{
    public class KhachHang
    {
        Data da = new Data();
        public DataTable ShowKH()
        {
            string sql = "select *from KhachHang";
            DataTable dt = new DataTable();
            dt = da.GetTable(sql);
            return dt;
        }

        public void InsertKH(string MaKH, string TenKH, string GioiTinh, string DiaChi, string CMND, string SoDT, string QuocTich)
        {
            string sql = "insert into KhachHang values ('" + MaKH + "',N'" + TenKH + "',N'" + GioiTinh + "',N'" + DiaChi + "','"+CMND+"','"+SoDT+"',N'"+QuocTich+"')";
            da.NonQuery(sql);
        }

        public void SuaTTKH(string ma_kh, string MaKH, string TenKH, string GioiTinh, string DiaChi, string CMND, string SoDT, string QuocTich)
        {
            string sql = "update KhachHang set MaKH='" + MaKH + "', TenKH=N'" + TenKH + "', GioiTinh=N'" + GioiTinh + "', DiaChi=N'" + DiaChi + "', CMND='" + CMND + "', SoDT='" + SoDT + "'  where MaKH='" + ma_kh + "'";
            da.NonQuery(sql);
        }

        public void XoaKH(string MaKH)
        {
            string sql = "delete KhachHang where MaKH='" + MaKH + "'";
            da.NonQuery(sql);
        }
    }
}
