﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapWindowsFrom
{
    internal class HangHoa
    {

        public string MaHang { get; set; }

        public string TenHang { get; set;}

        public string DVT { get; set; }

        public int SoLuong { get; set; }

        public int DonGia { get; set; }

        
        //Hàm khởi tạo không có tham số
        public HangHoa()
        {

        }

        public string HienThi()
        {
            return string.Format("{0}, {1}, {2}, {3}, {4}", MaHang, TenHang, DVT, SoLuong, DonGia);
        }
    }
}
