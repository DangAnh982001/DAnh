using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace BTVN.Models;
public class Sinhvien
{
    [Key]
    public string Masinhvien { get; set; }
    public string HoTen { get; set; }
    public int MaLop { get; set; }
    [ForeignKey("MaLop")]
    public LopHoc? LopHoc { get; set; }
}