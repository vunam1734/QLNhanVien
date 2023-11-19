
using QLNhanVien;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("NHANVIEN")]
public class NHANVIEN
{
    [Key]
    [StringLength(3)]
    public string MaNV { get; set; }
    [StringLength(50)]
    public string HoTen { get; set; }
    public string MaPhong { get; set; }
    public string ChucVu { get; set; }
    public int Luong { get; set; }
    public List<PHONGBAN> PHONGBAN { get; set; }
}
