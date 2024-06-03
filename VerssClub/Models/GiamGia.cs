using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VerssClub.Models
{
    public class GiamGia
    {
        [Key]
        public int MaGiamGia { get; set; }

        [Required]
        [MaxLength(50)]
        public string TenGiamGia { get; set; }
        
        public int MaSanPhamCT { get; set; }
        [ForeignKey("MaSanPhamCT")]

        public DateTime NgayTao { get; set; }

        public DateTime NgayBatDau { get; set; }

        public DateTime NgayKetThuc { get; set; }

        public bool TrangThai { get; set; }

        public float TiLeGiamGia { get; set; }

        public virtual SanPhamCT SanPhamCT { get; set; }
    }
}
