﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class QLPKDTEntities : DbContext
    {
        public QLPKDTEntities()
            : base("name=QLPKDTEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ChiTietDonHang> ChiTietDonHangs { get; set; }
        public virtual DbSet<DonHang> DonHangs { get; set; }
        public virtual DbSet<KhoHang> KhoHangs { get; set; }
        public virtual DbSet<NhaCC> NhaCCs { get; set; }
        public virtual DbSet<NhanVien> NhanViens { get; set; }
        public virtual DbSet<SanPham> SanPhams { get; set; }
        public virtual DbSet<TaiKhoan> TaiKhoans { get; set; }
    
        public virtual ObjectResult<GetEmployeeOrderStatistics_Result> GetEmployeeOrderStatistics()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetEmployeeOrderStatistics_Result>("GetEmployeeOrderStatistics");
        }
    
        public virtual ObjectResult<GetLast7DaysOrderTotal_Result> GetLast7DaysOrderTotal()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetLast7DaysOrderTotal_Result>("GetLast7DaysOrderTotal");
        }
    }
}
