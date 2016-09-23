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
    public class BoMonDAO
    {
        public static SqlConnection con;
        //  load data, hien thi theo yeu cau, them sua xoa
       
        // Load dữ liệu
        public static DataTable LoadDataBoMon()
        {
            string sTruyVan = "select * from tblBoMon";
            con = DataProvider.KetNoi();
            DataTable dt = DataProvider.LayDataTable(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return dt;
        }
        //hiển thị theo yêu cầu
        public static DataTable HienThiYeuCau(BoMonDTO boMon)
        {
            string sTruyVan = string.Format("select * from tblBoMon where IDMon={0}", boMon.IDMon);
            con = DataProvider.KetNoi();
            DataTable dt = DataProvider.LayDataTable(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return dt;
        }
        // thêm bộ môn
        public static bool ThemBM(BoMonDTO boMon)
        {
            try
            {
                 string sTruyVan = string.Format(@"insert into tblBoMon values({0}, N'{1}',{2}, {3})", boMon.IDMon, 
                                                                                                       boMon.TenMon, 
                                                                                                       boMon.SoLuong, 
                                                                                                       boMon.IDTruongBoMon);
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
        // sửa bộ môn
        public static bool SuaBM(BoMonDTO boMon)
        {
            try
            {
                string sTruyVan = string.Format("update tblBoMon set TenMon=N'{0}', SoLuong={1}, IDTruongBoMon={2} where IDMon={3}", boMon.TenMon, 
                                                                                                                                    boMon.SoLuong,
                                                                                                                                    boMon.IDTruongBoMon, 
                                                                                                                                    boMon.IDMon);
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
        // xóa bộ môn
        public static bool XoaBM(BoMonDTO boMon)
        {
            try
            {
                string sTruyVan = string.Format("delete from tblBoMon where IDMon = {0}", boMon.IDMon);
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
