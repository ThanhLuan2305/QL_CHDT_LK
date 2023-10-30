using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_DT_LK.DataAcsess
{
    public class NhacungcapDAL
    {
        QLPKDTEntities1 db = new QLPKDTEntities1();
        public List<NhaCC> list()
        {
            return db.NhaCCs.ToList<NhaCC>();
        }
        public bool KiemTraKhoaNgoai(string maNCC)
        {
            bool KetQua = db.SanPhams.Any(o => o.MaNCC == maNCC);
            return KetQua;
        }
        public void Add(NhaCC nv)
        {

            db.NhaCCs.Add(nv);
            db.SaveChanges();

        }
        public void Delete(NhaCC nv)
        {

            db.NhaCCs.Remove(nv);
            db.SaveChanges();

        }
        public void Replace(NhaCC NhaCCNew)
        {
            NhaCC nccTG = db.NhaCCs.FirstOrDefault(p => p.MaNCC == NhaCCNew.MaNCC);
            if (nccTG != null)
            {
                nccTG.MaNCC = NhaCCNew.MaNCC;
                nccTG.TenNCC = NhaCCNew.TenNCC;
                nccTG.SDTLH = NhaCCNew.SDTLH;
                nccTG.Email = NhaCCNew.Email;
                db.SaveChanges();
            }
        }
        public List<NhaCC> InsertNhaCC(string Keyword)
        {
            List<NhaCC> listTG = db.NhaCCs.Where(s => s.MaNCC.Contains(Keyword) || s.TenNCC.Contains(Keyword) || s.Email.Contains(Keyword) || s.SDTLH.Contains(Keyword)).ToList();
            return listTG;
        }
    }

}
