//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QL_DT_LK
{
    using System;
    using System.Collections.Generic;
    
    public partial class KhoHang
    {
        public string MaSP { get; set; }
        public Nullable<int> Soluong { get; set; }
        public Nullable<System.DateTime> NgayNhap { get; set; }
        public string TenSP { get; set; }
    
        public virtual SanPham SanPham { get; set; }
        public virtual SanPham SanPham1 { get; set; }
    }
}
