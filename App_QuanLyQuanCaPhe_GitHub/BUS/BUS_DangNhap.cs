﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAO;
using DTO;

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
    }
}
