using System.ComponentModel.DataAnnotations;
namespace BTVN.Models;
public class LopHoc
{
    [Key]
    [Display(Name = "Mã Lớp")]
    public int MaLop { get; set; }





    [Display(Name = "Tên Lớp")]
    [StringLength(50)]

    public string TenLop { get; set; }
}