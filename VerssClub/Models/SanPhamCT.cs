using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VerssClub.Models
{
    public class SanPhamCT
    {
        [Key]
        public int MaSanPhamCT { get; set; }

        [Required]
        [MaxLength(50)]
        public string TenSanPhamCT { get; set; }

        public int MaChatLieu { get; set; }
        [ForeignKey("MaChatLieu")]
        public int MaMau { get; set; }
        [ForeignKey("MaMau")]
        public int MaSanPham { get; set; }
        [ForeignKey("MaSanPham")]
        public int MaXuatXu { get; set; }
        [ForeignKey("MaXuatXu")]
        public int MaThuongHieu { get; set; }
        [ForeignKey("MaThuongHieu")]
        public int MaLoaiSanPham { get; set; }
        [ForeignKey("MaLoaiSanPham")]
        public int MaSize { get; set; }
        [ForeignKey("MaSize")]
        public int SoLuong { get; set; }

        public bool TrangThai { get; set; }

        public string ImgUrl { get; set; }

        public decimal Gia { get; set; }

        public virtual ChatLieu ChatLieu { get; set; }
        public virtual LoaiMau LoaiMau { get; set; }
        public virtual SanPham SanPham { get; set; }
        public virtual XuatXu XuatXu { get; set; }
        public virtual ThuongHieu ThuongHieu { get; set; }
        public virtual LoaiSanPham LoaiSanPham { get; set; }
        public virtual Size Size { get; set; }
        public virtual ICollection<GiamGia> GiamGias { get; set; }
    }
}
