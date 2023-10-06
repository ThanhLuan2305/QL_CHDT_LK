using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_DT_LK.DataAcsess
{
    public class TaiKhoanDAL
    {
        QLPKDTEntities db = new QLPKDTEntities();
        public void AddTaiKhoan(TaiKhoan taiKhoan)
        {
            db.TaiKhoans.Add(taiKhoan);
            db.SaveChanges();
        }

        public void DeleteTaiKhoan(TaiKhoan taiKhoan)
        {
            db.TaiKhoans.Remove(taiKhoan);
            db.SaveChanges();
        }
        public void Doimatkhau(TaiKhoan taiKhoan, string mknew)
        {
            taiKhoan.MatKhau = mknew;
            db.SaveChanges();
        }
        public TaiKhoan TimkiemTK(string tentk)
        {
            return db.TaiKhoans.FirstOrDefault(s => s.TaiKhoan1 == tentk);
        }

    }
}
