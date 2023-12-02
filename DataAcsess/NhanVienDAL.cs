﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_DT_LK.DataAcsess
{
    public class NhanVienDAL
    {
        QLPKDTEntities db = new QLPKDTEntities();
        public List<NhanVien> list()
        {
            return db.NhanVien.ToList<NhanVien>();
        }
        public bool KiemTraKhoaNgoai(string maNV)
        {
            bool KetQua = db.DonHang.Any(o => o.MaNV == maNV);
            return KetQua;
        }
        public NhanVien SearchNhanVien(string tenTK)
        {
            return db.NhanVien.FirstOrDefault(nv => nv.Tentk == tenTK);
        }
        public string GetNhanVien(string maNV)
        {

            return db.NhanVien.FirstOrDefault(s => s.MaNV == maNV).Tentk;

        }
        public void AddNV(NhanVien nv)
        {

            db.NhanVien.Add(nv);
            db.SaveChanges();

        }
        public void DeleteNV(NhanVien nv)
        {

            db.NhanVien.Remove(nv);
            db.SaveChanges();

        }
        public void Replace(NhanVien nvNew)
        {
            NhanVien nvTG = db.NhanVien.FirstOrDefault(p => p.MaNV == nvNew.MaNV);
            if (nvTG != null)
            {
                nvTG.MaNV = nvNew.MaNV;
                nvTG.TenNV = nvNew.TenNV;
                nvTG.SDT = nvNew.SDT;
                nvTG.QueQuan = nvTG.QueQuan;
                nvTG.Email = nvTG.Email;
                db.SaveChanges();
            }
        }
        public List<NhanVien> InsertNV(string Keyword)
        {
            List<NhanVien> listTG = db.NhanVien.Where(s => s.MaNV.Contains(Keyword) || s.TenNV.Contains(Keyword) || s.QueQuan.Contains(Keyword) || s.Email.Contains(Keyword) || s.SDT.Contains(Keyword)).ToList();
            return listTG;

        }
    }
}
