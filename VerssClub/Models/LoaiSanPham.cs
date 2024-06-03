using System.ComponentModel.DataAnnotations;

namespace VerssClub.Models
{
    public class LoaiSanPham
    {
        [Key]
        public int MaLoaiSanPham { get; set; }

        [Required]
        [MaxLength(50)]
        public string TenLoai { get; set; }

        public virtual ICollection<SanPham> SanPhams { get; set; }
    }
}
