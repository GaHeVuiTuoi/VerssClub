using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VerssClub.Models
{
    public class Order
    {
        [Key]
        public int MaOrder { get; set; }
        
        public int MaGioHangCT { get; set; }
        [ForeignKey("MaGioHangCT")]

        public int MaNhanVien { get; set; }
        [ForeignKey("MaNhanVien")]
        public DateTime NgayDatHang { get; set; }

        public decimal TongTien { get; set; }

        public bool TrangThai { get; set; }

        public virtual GioHangCT GioHangCT { get; set; }
        public virtual NhanVien NhanVien { get; set; }
    }
}
