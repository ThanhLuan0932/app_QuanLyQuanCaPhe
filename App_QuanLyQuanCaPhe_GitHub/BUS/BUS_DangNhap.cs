using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;


namespace BUS
{
    public class BUS_DangNhap
    {
        DAO_KetNoi xl = new DAO_KetNoi();
        DTO_DangNhap dl = new DTO_DangNhap();
        public DataTable DangNhap_Select(DTO_DangNhap dl)
        {
            return xl.table_Select("select * from MayChu");
        }
        public DataTable TK_Check(DTO_DangNhap dl)
        {
            return xl.table_Select("select * from MayChu where TaiKhoan_admin=N'" + dl.TaiKhoan + "' and MatKhau_admin=N'" + dl.MatKhau + "'");
        }
    }
}
