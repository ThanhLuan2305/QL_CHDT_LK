using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace QL_DT_LK.DataAcsess
{
    public class DSDonHangDAL
    {
        QLPKDTEntities db = new QLPKDTEntities();
        public dynamic GetAllDonHang()
        {

            var returnKQ = from dh in db.DonHangs
                           join ctdh in db.ChiTietDonHangs on dh.MaDH equals ctdh.MaDH
                           group new { dh, ctdh } by new { dh.MaDH, dh.TenKH, dh.DiaChi, dh.NgayMua, dh.MaNV } into g
                           select new
                           {
                               g.Key.MaDH,
                               g.Key.TenKH,
                               g.Key.DiaChi,
                               g.Key.NgayMua,
                               g.Key.MaNV,
                               tongtien = g.Sum(x => x.ctdh.DonGia)
                           };

            return returnKQ.ToList();
        }

        public dynamic GetRecentDonHang()
        {
            var returnKQ = from dh in db.DonHangs
                           join ctdh in db.ChiTietDonHangs on dh.MaDH equals ctdh.MaDH
                           group new { dh, ctdh } by new { NgayMua = DbFunctions.TruncateTime(dh.NgayMua), dh.MaDH, dh.TenKH, dh.DiaChi, dh.MaNV } into g
                           select new
                           {
                               g.Key.MaDH,
                               g.Key.TenKH,
                               g.Key.DiaChi,
                               NgayMua = g.Key.NgayMua,
                               g.Key.MaNV,
                               tongtien = g.Sum(x => x.ctdh.DonGia)
                           };

            return returnKQ.ToList();
        }

        public double SumDonGia()
        {
            return (double)db.ChiTietDonHangs.Sum(ctdh => ctdh.DonGia);
        }
        public dynamic Timkiem(string keyword)
        {
            var listTK = GetAllDonHang();

            var searchResult = new List<dynamic>();

            foreach (var item in listTK)
            {
                if (item.TenKH.Contains(keyword) || item.MaDH.Contains(keyword)) // Kiểm tra điều kiện tìm kiếm
                {
                    searchResult.Add(item);
                }
            }

            return searchResult.ToList();
        }
        public DonHang GetThongTin1Donhang(string MaDH)
        {
            DonHang DHTG = db.DonHangs.FirstOrDefault(s => s.MaDH == MaDH);
            return DHTG;
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
