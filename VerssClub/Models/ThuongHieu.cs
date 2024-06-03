using System.ComponentModel.DataAnnotations;

namespace VerssClub.Models
{
    public class ThuongHieu
    {
        [Key]
        public int MaThuongHieu { get; set; }

        [Required]
        [MaxLength(50)]
        public string TenThuongHieu { get; set; }

        public virtual ICollection<SanPham> SanPhams { get; set; }
    }
}
