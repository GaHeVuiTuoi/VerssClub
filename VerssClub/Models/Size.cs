using System.ComponentModel.DataAnnotations;

namespace VerssClub.Models
{
    public class Size
    {
        [Key]
        public int MaSize { get; set; }

        [Required]
        public int SizeValue { get; set; }

        public virtual ICollection<SanPhamCT> SanPhamCTs { get; set; }
    }
}
