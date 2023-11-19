namespace QLNhanVien.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v3 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.NHANVIEN",
                c => new
                    {
                        MaNV = c.String(nullable: false, maxLength: 3),
                        HoTen = c.String(maxLength: 50),
                        MaPhong = c.String(),
                        ChucVu = c.String(),
                        Luong = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MaNV);
            
            CreateTable(
                "dbo.PHONGBAN",
                c => new
                    {
                        MaPhong = c.String(nullable: false, maxLength: 3),
                        TenPH = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.MaPhong);
            
            CreateTable(
                "dbo.PHONGBANNHANVIENs",
                c => new
                    {
                        PHONGBAN_MaPhong = c.String(nullable: false, maxLength: 3),
                        NHANVIEN_MaNV = c.String(nullable: false, maxLength: 3),
                    })
                .PrimaryKey(t => new { t.PHONGBAN_MaPhong, t.NHANVIEN_MaNV })
                .ForeignKey("dbo.PHONGBAN", t => t.PHONGBAN_MaPhong, cascadeDelete: true)
                .ForeignKey("dbo.NHANVIEN", t => t.NHANVIEN_MaNV, cascadeDelete: true)
                .Index(t => t.PHONGBAN_MaPhong)
                .Index(t => t.NHANVIEN_MaNV);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PHONGBANNHANVIENs", "NHANVIEN_MaNV", "dbo.NHANVIEN");
            DropForeignKey("dbo.PHONGBANNHANVIENs", "PHONGBAN_MaPhong", "dbo.PHONGBAN");
            DropIndex("dbo.PHONGBANNHANVIENs", new[] { "NHANVIEN_MaNV" });
            DropIndex("dbo.PHONGBANNHANVIENs", new[] { "PHONGBAN_MaPhong" });
            DropTable("dbo.PHONGBANNHANVIENs");
            DropTable("dbo.PHONGBAN");
            DropTable("dbo.NHANVIEN");
        }
    }
}
