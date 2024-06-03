using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VerssClub.Models
{
    public class HoaDonCT
    {
        [Key]
        public int MaHoaDonCT { get; set; }
        
        public int MaHoaDon { get; set; }
        [ForeignKey("MaHoaDon")]
        
        public int MaSanPhamCT { get; set; }
        [ForeignKey("MaSanPhamCT")]

        public int SoLuong { get; set; }

        public decimal TongTien { get; set; }

        public bool TrangThai { get; set; }

        public virtual HoaDon HoaDon { get; set; }
        public virtual SanPhamCT SanPhamCT { get; set; }
    }
}
