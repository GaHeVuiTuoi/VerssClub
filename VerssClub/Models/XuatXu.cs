using System.ComponentModel.DataAnnotations;

namespace VerssClub.Models
{
    public class XuatXu
    {
        [Key]
        public int MaXuatXu { get; set; }

        [Required]
        public string DiaDiemXuatXu { get; set; }

        public virtual ICollection<SanPham> SanPhams { get; set; }
    }
}
