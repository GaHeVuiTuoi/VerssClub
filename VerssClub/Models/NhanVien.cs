using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VerssClub.Models
{
    public class NhanVien
    {
        public int MaNhanVien { get; set; }

        [Required]
        [MaxLength(50)]
        public string TenNhanVien { get; set; }

        [Required]
        [MaxLength(15)]
        public string SDT { get; set; }

        [Required]
        [MaxLength(100)]
        public string Email { get; set; }

        [Required]
        [MaxLength(50)]
        public string MatKhau { get; set; }

        public int NamSinh { get; set; }

        public bool TrangThai { get; set; }
        
        public int MaChucVu { get; set; }
        [ForeignKey("MaChucVu")]

        public virtual List<ChucVu> ChucVu { get; set; }
        public virtual ICollection<HoaDon> HoaDons { get; set; }
    }
}
