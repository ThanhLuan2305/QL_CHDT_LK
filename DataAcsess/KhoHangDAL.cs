﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_DT_LK.DataAcsess
{
    public class KhoHangDAL
    {
        QLPKDTEntities db = new QLPKDTEntities();
        public List<KhoHang> GetDataKhoHang()
        {
            return db.KhoHang.ToList<KhoHang>();
        }
        public void AddSP(KhoHang sanpham)
        {
            db.KhoHang.Add(sanpham);
            db.SaveChanges();
        }
        public void DeleteSP(KhoHang sanpham)
        {
            db.KhoHang.Remove(sanpham);
            db.SaveChanges();

        }
        public void UpdateSP(KhoHang sanphamnew)
        {
            KhoHang sanphamOld = db.KhoHang.FirstOrDefault(p => p.MaSP == sanphamnew.MaSP);
            if (sanphamOld != null)
            {
                sanphamOld.Soluong = sanphamnew.Soluong + sanphamOld.Soluong;
                sanphamOld.NgayNhap = sanphamnew.NgayNhap;
                db.SaveChanges();
            }
        }
        public void GiamSoLuong(KhoHang sp, int x)
        {
            sp.Soluong = sp.Soluong - x;
            db.SaveChanges();

        }
        public void TangSoLuong(KhoHang sp, int x)
        {
            sp.Soluong = sp.Soluong + x;
            db.SaveChanges();

        }
    }
}
