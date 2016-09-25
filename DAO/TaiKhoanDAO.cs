using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DTO;
namespace DAO
{
   public class TaiKhoanDAO
    {
        public static SqlConnection con;
        // thêm tài khoản, xóa tài khoản
        public static bool ThemTK(TaiKhoanDTO tk)
        {
            try
            {
                string sTruyVan = string.Format("insert into tblTaiKhoan values({0},{1})", tk.TaiKhoan, tk.MatKhau);
                con = DataProvider.KetNoi();
                DataProvider.ThucThiTruyVan(sTruyVan, con);
                DataProvider.DongKetNoi(con);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static bool XoaTk(TaiKhoanDTO tk)
        {
            try
            {
                string sTruyVan = string.Format("delete from tblTaiKhoan where TaiKhoan={0}", tk.TaiKhoan);
                con = DataProvider.KetNoi();
                DataProvider.ThucThiTruyVan(sTruyVan, con);
                DataProvider.DongKetNoi(con);
                return true;
            }
            catch
            {
                return false;
            }
        }
   }
}
