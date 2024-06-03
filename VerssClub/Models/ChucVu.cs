using System.ComponentModel.DataAnnotations;

namespace VerssClub.Models
{
    public class ChucVu
    {
        [Key]
        public int MaChucVu { get; set; }

        [Required]
        [MaxLength(50)]
        public string VaiTro { get; set; }

        public virtual ICollection<NhanVien> NhanViens { get; set; }
    }
}
