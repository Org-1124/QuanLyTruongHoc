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
   public class LopDAO
    {
       public static SqlConnection con;
       // load dữ liệu, hiển thị theo yêu cầu, thêm sửa xóa
       // Load dữ liệu
       public static DataTable LoadDataLop()
       {
           string sTruyVan = "select * from tblLop";
           con = DataProvider.KetNoi();
           DataTable dt = DataProvider.LayDataTable(sTruyVan, con);
           DataProvider.DongKetNoi(con);
           return dt;
       }

       //hiển thị theo yêu cầu
       public static DataTable HienThiYeuCau(LopDTO lop)
       {
           string sTruyVan = string.Format("select * from tblLop where IDLop={0}", lop.IDLop);
           con = DataProvider.KetNoi();
           DataTable dt = DataProvider.LayDataTable(sTruyVan, con);
           DataProvider.DongKetNoi(con);
           return dt;
       }

       //thêm lớp
       public static bool ThemLop(LopDTO lop)
       {
           try
           {
               string sTruyVan = string.Format("insert into tblLop values({0},N'{1}',{2},{3},{4})", lop.IDLop,
                                                                                                    lop.TenLop,
                                                                                                    lop.SoLuong,
                                                                                                    lop.IDLopTruong,
                                                                                                    lop.IDChuNhiem);
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

       // sửa lớp
       public static bool SuaLop(LopDTO lop)
       {
           try
           {
               string sTruyVan = string.Format("update tblLop set TenLop=N'{0}', SoLuong={1}, IDLopTruong={2}, IDChuNhiem={3} where IDLop={4} ", lop.TenLop,
                                                                                                                                                 lop.SoLuong,
                                                                                                                                                 lop.IDLopTruong,
                                                                                                                                                 lop.IDChuNhiem,
                                                                                                                                                 lop.IDLop);                             
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

       // xóa lớp
       public static bool XoaLop( LopDTO lop)
       {
           try
           {
               string sTruyVan = string.Format("delete from tblLop where IDLop = {0}", lop.IDLop);
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
