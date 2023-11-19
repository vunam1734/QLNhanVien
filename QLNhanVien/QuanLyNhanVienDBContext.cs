using System;
using System.Data.Entity;
using System.Linq;

namespace QLNhanVien
{
    public class QuanLyNhanVienDBContext : DbContext
    {
        public DbSet<NHANVIEN> NHANVIENs { get; set; }
        public DbSet<PHONGBAN> PHONGBANs { get; set; }
        public QuanLyNhanVienDBContext()
            : base("name=QuanLyNhanVienDBContext")
        {
        }

    }
}