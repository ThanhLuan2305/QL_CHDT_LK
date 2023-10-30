using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_DT_LK.DataAcsess
{
    public class KhoHangDAL
    {
        QLPKDTEntities1 db = new QLPKDTEntities1();
        public List<KhoHang> GetDataKhoHang()
        {
            return db.KhoHangs.ToList<KhoHang>();
        }
        public void AddSP(KhoHang sanpham)
        {
            db.KhoHangs.Add(sanpham);
            db.SaveChanges();
        }
        public void DeleteSP(KhoHang sanpham)
        {
            db.KhoHangs.Remove(sanpham);
            db.SaveChanges();

        }
        public void UpdateSP(KhoHang sanphamnew)
        {
            KhoHang sanphamOld = db.KhoHangs.FirstOrDefault(p => p.MaSP == sanphamnew.MaSP);
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
