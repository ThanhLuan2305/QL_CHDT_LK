﻿using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_DT_LK.DataAcsess
{
    public class DonHangDAL
    {
        QLPKDTEntities1 db = new QLPKDTEntities1();
        public List<DonHang> GetDonHangs()
        {
            return db.DonHangs.ToList<DonHang>();
        }
        public bool KiemTraKhoaNgoai(string maDH)
        {
            bool KetQua = db.ChiTietDonHangs.Any(o => o.MaDH == maDH);
            return KetQua;
        }
        public DonHang GetThongTin1Donhang(string MaDH)
        {
            DonHang DHTG = db.DonHangs.FirstOrDefault(s => s.MaDH == MaDH);
            return DHTG;
        }

        public void AddDH(DonHang dh)
        {
            db.DonHangs.Add(dh);
            db.SaveChanges();
        }
        public void DeleteDH(DonHang dh)
        {
            db.DonHangs.Remove(dh);
            db.SaveChanges();
        }

        //Thao tác với Chitietdonhang
        public void AddCTDH(ChiTietDonHang dh)
        {
            db.ChiTietDonHangs.Add(dh);
            db.SaveChanges();
        }
        public void DeleteCTDH(string Madh)
        {
            var ctdhList = db.ChiTietDonHangs.Where(ctdh => ctdh.MaDH == Madh).ToList();
            db.ChiTietDonHangs.RemoveRange(ctdhList);
            db.SaveChanges();
        }

        public List<DonHang> GetDonHangss()
        {
            return db.DonHangs.ToList<DonHang>();
        }

        public List<ObjectSP> GetListSPmua(string MaDH)
            {
            var Ketqua = from dhct in db.ChiTietDonHangs
                         join sp in db.SanPhams on dhct.MaSP equals sp.MaSP
            where dhct.MaDH == MaDH
                         select new ObjectSP
                         {
                             MaSP = dhct.MaSP,
                             TenSP = sp.TenSP,
                             Soluong = (int)dhct.SoLuong,
                             Giaban = (double)sp.Giaban,
                             Thanhtien = (double)dhct.DonGia,

                         };
            return Ketqua.ToList();
        }


    }
}
