﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapWindowsFrom
{
    internal class TinhToan
    {
        public static void CongHaiSo(int a, int b,int s)
        {
            s = a + b;
        }

        public static int TongDaySo(int n)
        {
            int tong = 0;
            for (int i = 1; i < n; i++)
            {
                tong += i;
            }
            return tong;
        }
    }
}
