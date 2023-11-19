using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
[Table("PHONGBAN")]
public class PHONGBAN
{
    [Key]
    [StringLength(3)]
    public string MaPhong { get; set; }
    [StringLength(50)]
    public string TenPH { get; set; }
    public List<NHANVIEN> NHANVIENs { get; set; }
}