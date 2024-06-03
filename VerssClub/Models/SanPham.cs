using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VerssClub.Models
{
    public class SanPham
    {
        [Key]
        public int MaSanPham { get; set; }

        public int MaGioHangCT { get; set; }
        [ForeignKey("MaGioHangCT")]
        [Required]
        [MaxLength(50)]
        public string TenSanPham { get; set; }

        public int MaChatLieu { get; set; }
        [ForeignKey("MaChatLieu")]
        public int MaXuatXu { get; set; }
        [ForeignKey("MaXuatXu")]
        public int MaThuongHieu { get; set; }
        [ForeignKey("MaThuongHieu")]
        public int MaLoaiSanPham { get; set; }
        [ForeignKey("MaLoaiSanPham")]
        public bool TrangThai { get; set; }

        public virtual GioHangCT GioHangCT { get; set; }
        public virtual ChatLieu ChatLieu { get; set; }
        public virtual XuatXu XuatXu { get; set; }
        public virtual ThuongHieu ThuongHieu { get; set; }
        public virtual LoaiSanPham LoaiSanPham { get; set; }
        public virtual ICollection<SanPhamCT> SanPhamCTs { get; set; }
    }
}
