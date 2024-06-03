using System.ComponentModel.DataAnnotations;

namespace VerssClub.Models
{
    public class LoaiMau
    {
        public int MaMau { get; set; }

        [Required]
        [MaxLength(50)]
        public string TenMau { get; set; }

        public virtual ICollection<SanPhamCT> SanPhamCTs { get; set; }
    }
}
