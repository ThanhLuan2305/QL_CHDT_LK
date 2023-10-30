using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_DT_LK.DataAcsess
{
    public class SanPhamDAL
    {
        QLPKDTEntities1 db = new QLPKDTEntities1();
        public List<SanPham> GetListSP()
        {
            return db.SanPhams.ToList<SanPham>();
        }
        public bool KiemTraKhoaNgoai(string sanPhamId)
        {
            bool KetQua = db.KhoHangs.Any(o => o.MaSP == sanPhamId) || db.ChiTietDonHangs.Any(o => o.MaSP == sanPhamId);
            return KetQua;
        }
        public void Add(SanPham sp)
        {
            db.SanPhams.Add(sp);
            db.SaveChanges();
        }
        public void Delete(SanPham sp)
        {
            db.SanPhams.Remove(sp);
            db.SaveChanges();
        }
        public void Replace(SanPham spnew)
        {
            SanPham spOld = db.SanPhams.FirstOrDefault(s => s.MaSP == spnew.MaSP);
            if (spOld != null)
            {
                spOld.MaSP = spnew.MaSP;
                spOld.MaNCC = spnew.MaNCC;
                spOld.TenSP = spnew.TenSP;
                spOld.TheLoai = spnew.TheLoai;
                spOld.HangSP = spnew.HangSP;
                spOld.XuatXu = spnew.XuatXu;
                spOld.Giaban = spnew.Giaban;
                db.SaveChanges();
            }
        }
        public List<SanPham> InsertSP(string Keyword)
        {
            List<SanPham> Inserts = db.SanPhams.Where(s => s.MaSP.Contains(Keyword) || s.MaNCC.Contains(Keyword) || s.TenSP.Contains(Keyword) || s.XuatXu.Contains(Keyword) || s.HangSP.Contains(Keyword) || s.Giaban.ToString().Contains(Keyword)).ToList();
            return Inserts;
        }

    }
}
