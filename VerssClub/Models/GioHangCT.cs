using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VerssClub.Models
{
    public class GioHangCT
    {
        [Key]
        public int MaGioHangCT { get; set; }
        
        public int MaKhachHang { get; set; }
        [ForeignKey("MaKhachHang")]
        
        public int MaGioHang { get; set; }
        [ForeignKey("MaGioHang")]

        public int SoLuong { get; set; }

        public decimal TongTien { get; set; }

        public virtual GioHang GioHang { get; set; }
    }
}
