using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;

namespace BUS
{
    public class ThietBi
    {
        Data da = new Data();
        public DataTable ShowTB()
        {
            string sql = "select *from ThietBi";
            DataTable dt = new DataTable();
            dt = da.GetTable(sql);
            return dt;
        }

        public void InsertTB(string MaTB, string MaPhong, string TenTB, int SoLuong)
        {
            string sql = "insert into ThietBi values ('" + MaTB + "', '" + MaPhong + "', N'" + TenTB + "', '" + SoLuong + "')";
            da.NonQuery(sql);
        }

        public void SuaTB(string ma_tb, string MaTB, string MaPhong, string TenTB, string SoLuong)
        {
            string sql = "update ThietBi set MaTB='" + MaTB + "', TenTB=N'" + TenTB + "', SoLuong='" + SoLuong + "' where MaTB='" + ma_tb + "'";
            da.NonQuery(sql);
        }

        public void XoaTB(string MaTB)
        {
            string sql = "delete ThietBi where MaTB='" + MaTB + "'";
            da.NonQuery(sql);
        }
    }
}
