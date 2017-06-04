using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;

namespace BUS
{
    public class QLThuePhong
    {
        Data da = new Data();
        public DataTable ShowTP()
        {
            string sql = "select *from PhieuNhanPhong";
            DataTable dt = new DataTable();
            dt = da.GetTable(sql);
            return dt;
        }

        public void InsertTP(string MaNP, string MaPhong, string MaKH, DateTime NgayNhanP, DateTime NgayTraP)
        {
            string sql = "insert into PhieuNhanPhong values ('" + MaNP + "','" + MaPhong + "','" + MaKH + "','" + NgayNhanP + "','" + NgayTraP + "')";
            da.NonQuery(sql);
        }

        public void SuaTTTP(string ma_np, string MaNP, string MaPhong, string MaKH, DateTime NgayNhanP, DateTime NgayTraP)
        {
            string sql = "update PhieuNhanPhong set MaNhanPhong='" + MaNP + "', MaPhong='" + MaPhong + "', MaKH='" + MaKH + "', NgayNhan='" + NgayNhanP + "', NgayTra='" + NgayTraP + "' where MaNhanPhong='" + ma_np + "'";
            da.NonQuery(sql);
        }

        public void XoaTP(string MaTP)
        {
            string sql = "delete PhieuNhanPhong where MaNhanPhong='" + MaTP + "'";
            da.NonQuery(sql);
        }

        
    }
}
