namespace QLNhanVien.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<QLNhanVien.QuanLyNhanVienDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(QLNhanVien.QuanLyNhanVienDBContext context)
        {
            context.PHONGBANs.Add(new PHONGBAN { MaPhong = "CG", TenPH = "Chuyên gia" });
            context.PHONGBANs.Add(new PHONGBAN { MaPhong = "TCHC", TenPH = "Tổ chức hành chính" });
            context.PHONGBANs.Add(new PHONGBAN { MaPhong = "KT", TenPH = "Kế toán" });
            context.PHONGBANs.Add(new PHONGBAN { MaPhong = "QLVT", TenPH = "Quản lý vật tư" });
            context.PHONGBANs.Add(new PHONGBAN { MaPhong = "KTH", TenPH = "Kỹ thuật" });
            context.PHONGBANs.Add(new PHONGBAN { MaPhong = "DA", TenPH = "Dự án" });
            context.PHONGBANs.Add(new PHONGBAN { MaPhong = "KD", TenPH = "Kinh Doanh" });
            context.PHONGBANs.Add(new PHONGBAN { MaPhong = "KTD", TenPH = "Kỹ thuật điện" });
            context.PHONGBANs.Add(new PHONGBAN { MaPhong = "TCC", TenPH = "Thi công cơ" });
            context.PHONGBANs.Add(new PHONGBAN { MaPhong = "XNK", TenPH = "Xuất nhập khẩu" });
            context.PHONGBANs.Add(new PHONGBAN { MaPhong = "BPSX", TenPH = "Bộ phận sản xuất" });



            context.NHANVIENs.Add(new NHANVIEN { MaNV = "A01", HoTen = "Liu Jin He", ChucVu = "Kỹ Sư", MaPhong = "CG", Luong = 28000000 });
            context.NHANVIENs.Add(new NHANVIEN { MaNV = "A02", HoTen = "Feng Meng Xiong", ChucVu = "Kỹ Sư", MaPhong = "CG", Luong = 30000000 });
            context.NHANVIENs.Add(new NHANVIEN { MaNV = "A03", HoTen = "Ji Liu", ChucVu = "Kỹ Sư", MaPhong = "CG", Luong = 23000000 });
            context.NHANVIENs.Add(new NHANVIEN { MaNV = "A04", HoTen = "Đặng Thành Côn", ChucVu = "Phiên dịch viên", MaPhong = "KT", Luong = 18000000 });
            context.NHANVIENs.Add(new NHANVIEN { MaNV = "A05", HoTen = "Doãn Cường", ChucVu = "Kỹ Sư", MaPhong = "LG", Luong = 25000000 });

            context.NHANVIENs.Add(new NHANVIEN { MaNV = "B01", HoTen = "Trần Thị Thu Hương", ChucVu = "Trưởng phòng", MaPhong = "TCHC", Luong = 22000000 });
            context.NHANVIENs.Add(new NHANVIEN { MaNV = "B02", HoTen = "Nguyễn Thị Nhàn ", ChucVu = "Nhân viên", MaPhong = "TCHC", Luong = 17000000 });
            context.NHANVIENs.Add(new NHANVIEN { MaNV = "B03", HoTen = "Nguyễn Ngọc Minh", ChucVu = "Nhân viên", MaPhong = "TCHC", Luong = 16000000 });
            context.NHANVIENs.Add(new NHANVIEN { MaNV = "B04", HoTen = "Nguyễn Minh Hiệp", ChucVu = "Nhân viên", MaPhong = "TCHC", Luong = 15000000 });

            context.NHANVIENs.Add(new NHANVIEN { MaNV = "C01", HoTen = "Bùi Thị Hồng Sen", ChucVu = "Kế toán trưởng", MaPhong = "KT", Luong = 26000000 });
            context.NHANVIENs.Add(new NHANVIEN { MaNV = "C02", HoTen = "Nguyễn Thị Thúy Hằng", ChucVu = "Kế toán viên", MaPhong = "KT", Luong = 23000000 });
            context.NHANVIENs.Add(new NHANVIEN { MaNV = "C03", HoTen = "Nguyễn Thị Ngọc Diễm", ChucVu = "Kế toán viên", MaPhong = "KT", Luong = 21000000 });
            context.NHANVIENs.Add(new NHANVIEN { MaNV = "C04", HoTen = "Trần Thị Thắm", ChucVu = "Kế toán viên", MaPhong = "KT", Luong = 22000000 });

            context.NHANVIENs.Add(new NHANVIEN { MaNV = "D01", HoTen = "Nguyễn Văn Tùng", ChucVu = "Trưởng phòng", MaPhong = "QLVT", Luong = 28000000 });
            context.NHANVIENs.Add(new NHANVIEN { MaNV = "D02", HoTen = "Nguyễn Ngọc Thanh", ChucVu = "Trưởng kho 1", MaPhong = "QLVT", Luong = 28000000 });
            context.NHANVIENs.Add(new NHANVIEN { MaNV = "D03", HoTen = "Nguyễn Huy Hiệp", ChucVu = "Trưởng kho 2", MaPhong = "QLVT", Luong = 28000000 });

            context.NHANVIENs.Add(new NHANVIEN { MaNV = "E01", HoTen = "Vũ Tuyên Khôi", ChucVu = "Trưởng phòng", MaPhong = "KTH", Luong = 24000000 });
            context.NHANVIENs.Add(new NHANVIEN { MaNV = "E02", HoTen = "Trần Xuân Tú", ChucVu = "Phó phòng", MaPhong = "KTH", Luong = 23000000 });
            context.NHANVIENs.Add(new NHANVIEN { MaNV = "E03", HoTen = "Thiều Lê Thanh Tâm", ChucVu = "Nhân viên", MaPhong = "KTH", Luong = 21000000 });
            context.NHANVIENs.Add(new NHANVIEN { MaNV = "E04", HoTen = "Trần Công Lập", ChucVu = "Nhân viên", MaPhong = "KTH", Luong = 20000000 });

            context.NHANVIENs.Add(new NHANVIEN { MaNV = "F01", HoTen = "Đào Thanh Quang", ChucVu = "Trưởng phòng", MaPhong = "DA", Luong = 21000000 });
            context.NHANVIENs.Add(new NHANVIEN { MaNV = "F02", HoTen = "Lê Đức Trường", ChucVu = "Nhân viên", MaPhong = "DA", Luong = 16000000 });
            context.NHANVIENs.Add(new NHANVIEN { MaNV = "F03", HoTen = "Đỗ Văn Hà", ChucVu = "Nhân viên", MaPhong = "DA", Luong = 17000000 });
            context.NHANVIENs.Add(new NHANVIEN { MaNV = "F04", HoTen = "Trần Thanh Tùng", ChucVu = "Nhân viên", MaPhong = "DA", Luong = 18000000 });
            context.NHANVIENs.Add(new NHANVIEN { MaNV = "F05", HoTen = "Nguyễn Duy Lợi", ChucVu = "Nhân viên", MaPhong = "DA", Luong = 16000000 });

            context.NHANVIENs.Add(new NHANVIEN { MaNV = "K01", HoTen = "Đỗ Văn Thịnh", ChucVu = "Trưởng phòng ", MaPhong = "BPSX", Luong = 21000000 });
            context.NHANVIENs.Add(new NHANVIEN { MaNV = "K02", HoTen = "Phan Công Anh", ChucVu = "Phó phòng", MaPhong = "BPSX", Luong = 18000000 });
            context.NHANVIENs.Add(new NHANVIEN { MaNV = "K03", HoTen = "Lê Khắc Tùng", ChucVu = "Công nhân", MaPhong = "BPSX", Luong = 16000000 });
            context.NHANVIENs.Add(new NHANVIEN { MaNV = "K04", HoTen = "Phạm Hoàng Nhân", ChucVu = "Công nhân", MaPhong = "BPSX", Luong = 16000000 });
            context.NHANVIENs.Add(new NHANVIEN { MaNV = "K05", HoTen = "Huỳnh Anh Nguyên", ChucVu = "Công nhân", MaPhong = "BPSX", Luong = 15000000 });
            context.NHANVIENs.Add(new NHANVIEN { MaNV = "K06", HoTen = "Trần Văn Đức", ChucVu = "Công nhân", MaPhong = "BPSX", Luong = 15000000 });
            context.NHANVIENs.Add(new NHANVIEN { MaNV = "K07", HoTen = "Phạm Văn Hồng Phúc", ChucVu = "Công nhân", MaPhong = "BPSX", Luong = 12000000 });
            context.NHANVIENs.Add(new NHANVIEN { MaNV = "K08", HoTen = "Phan Đặng Huệ", ChucVu = "Công nhân", MaPhong = "BPSX", Luong = 15000000 });
            context.NHANVIENs.Add(new NHANVIEN { MaNV = "K09", HoTen = "Nguyễn Chờ Anh", ChucVu = "Công nhân", MaPhong = "BPSX", Luong = 14000000 });
            context.NHANVIENs.Add(new NHANVIEN { MaNV = "K10", HoTen = "Hồ Văn Thiền", ChucVu = "Công nhân", MaPhong = "BPSX", Luong = 13000000 });

            context.NHANVIENs.Add(new NHANVIEN { MaNV = "J01", HoTen = "Nguyễn Lê Thuận", ChucVu = "Trưởng phòng", MaPhong = "XNK", Luong = 24000000 });
            context.NHANVIENs.Add(new NHANVIEN { MaNV = "J02", HoTen = "Nguyễn Tiến Hùng", ChucVu = "Phó phòng", MaPhong = "XNK", Luong = 22000000 });
            context.NHANVIENs.Add(new NHANVIEN { MaNV = "J03", HoTen = "Lê Mạnh Trường", ChucVu = "Nhân viên", MaPhong = "XNK", Luong = 20000000 });

            context.NHANVIENs.Add(new NHANVIEN { MaNV = "I01", HoTen = "Đỗ Cao Sơn", ChucVu = "Trưởng phòng", MaPhong = "TCC", Luong = 25000000 });
            context.NHANVIENs.Add(new NHANVIEN { MaNV = "I02", HoTen = "Hoàng Giang Nam", ChucVu = "Phó phòng", MaPhong = "TCC", Luong = 23000000 });
            context.NHANVIENs.Add(new NHANVIEN { MaNV = "I03", HoTen = "Trần Thanh Tâm", ChucVu = "Nhân viên", MaPhong = "TCC", Luong = 21000000 });
            context.NHANVIENs.Add(new NHANVIEN { MaNV = "I04", HoTen = "Phan Anh Tuấn", ChucVu = "Nhân viên", MaPhong = "TCC", Luong = 17000000 });
            context.NHANVIENs.Add(new NHANVIEN { MaNV = "I05", HoTen = "Lê Xuân Huy", ChucVu = "Nhân viên", MaPhong = "TCC", Luong = 16000000 });
            context.NHANVIENs.Add(new NHANVIEN { MaNV = "I06", HoTen = "Bùi Hữu Phước", ChucVu = "Nhân viên", MaPhong = "TCC", Luong = 19000000 });

            context.NHANVIENs.Add(new NHANVIEN { MaNV = "H01", HoTen = "Lâm Quang Minh", ChucVu = "Trưởng phòng", MaPhong = "KTD", Luong = 23000000 });
            context.NHANVIENs.Add(new NHANVIEN { MaNV = "H02", HoTen = "Trương Quang Viên", ChucVu = "Phó phòng", MaPhong = "KTD", Luong = 20000000 });
            context.NHANVIENs.Add(new NHANVIEN { MaNV = "H03", HoTen = "Huỳnh Tấn Thành", ChucVu = "Nhân viên", MaPhong = "KTD", Luong = 16000000 });
            context.NHANVIENs.Add(new NHANVIEN { MaNV = "H04", HoTen = "Nguyễn Trung Kiên", ChucVu = "Nhân viên", MaPhong = "KTD", Luong = 17000000 });
            context.NHANVIENs.Add(new NHANVIEN { MaNV = "H05", HoTen = "Huỳnh Tấn Linh Vỹ", ChucVu = "Nhân viên", MaPhong = "KTD", Luong = 14000000 });
            context.NHANVIENs.Add(new NHANVIEN { MaNV = "H06", HoTen = "Phạm Đình Hiệp", ChucVu = "Nhân viên", MaPhong = "KTD", Luong = 15000000 });
            context.NHANVIENs.Add(new NHANVIEN { MaNV = "H07", HoTen = "Hồ Văn Thiền", ChucVu = "Nhân viên", MaPhong = "KTD", Luong = 16000000 });

            context.NHANVIENs.Add(new NHANVIEN { MaNV = "G01", HoTen = "Nguyễn Mạnh Hùng", ChucVu = "Trưởng phòng", MaPhong = "KD", Luong = 24000000 });
            context.NHANVIENs.Add(new NHANVIEN { MaNV = "G02", HoTen = "Đặng Thanh Hoàng", ChucVu = "Nhân viên", MaPhong = "KD", Luong = 20000000 });
            context.NHANVIENs.Add(new NHANVIEN { MaNV = "G03", HoTen = "Lê Thành Hưng", ChucVu = "Nhân viên", MaPhong = "KD", Luong = 19000000 });
            context.NHANVIENs.Add(new NHANVIEN { MaNV = "G04", HoTen = "Phan Thế Hùng", ChucVu = "Nhân viên", MaPhong = "KD", Luong = 20000000 });
            context.NHANVIENs.Add(new NHANVIEN { MaNV = "G05", HoTen = "Lê Văn Nam", ChucVu = "Nhân viên", MaPhong = "KD", Luong = 18000000 });
            context.NHANVIENs.Add(new NHANVIEN { MaNV = "G06", HoTen = "Lê Thanh Bình", ChucVu = "Nhân viên", MaPhong = "KD", Luong = 17000000 });
            context.NHANVIENs.Add(new NHANVIEN { MaNV = "G07", HoTen = "Đoàn Bách Khoa", ChucVu = "Nhân viên", MaPhong = "KD", Luong = 21000000 });
        }
    }
}
