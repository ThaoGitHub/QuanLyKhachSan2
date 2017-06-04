using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;

namespace BUS
{
    public class NhanVien
    {
        Data da = new Data();
        public DataTable ShowNV()
        {
            string sql = "select *from NhanVien";
            DataTable dt = new DataTable();
            dt = da.GetTable(sql);
            return dt;
        }

        public void InsertNV(string MaNV, string TenNV, DateTime NgaySinh, string GioiTinh, string DiaChi, string SoDT, DateTime NgayVaoLam)
        {
            string sql = "insert into NhanVien values ('" + MaNV + "',N'" + TenNV + "','" + NgaySinh + "',N'" + GioiTinh + "',N'" + DiaChi + "','" + SoDT + "','" + NgayVaoLam + "')";
            da.NonQuery(sql);
        }

        public void SuaNV(string ma_nv, string MaNV, string TenNV, DateTime NgaySinh, string GioiTinh, string DiaChi, string SoDT, DateTime NgayVaoLam)
        {
            string sql = "update NhanVien set MaNV='" + MaNV + "', TenNV=N'" + TenNV + "', NgaySinh='" + NgaySinh + "', GioiTinh=N'" + GioiTinh + "', DiaChi=N'" + DiaChi + "', SoDT='" + SoDT + "', NgayVaoLam='" + NgayVaoLam + "' where MaNV='" + ma_nv + "'";
            da.NonQuery(sql);
        }

        public void XoaNV(string MaNV)
        {
            string sql = "delete NhanVien where MaNV='" + MaNV + "'";
            da.NonQuery(sql);
        }
    }
}
