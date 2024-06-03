using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VerssClub.Models
{
    public class ThanhToan
    {
        [Key]
        public int MaThanhToan { get; set; }        
        public int MaHoaDon { get; set; }
        [ForeignKey("MaHoaDon")]
        public string PhuongThucThanhToan { get; set; } 

        public DateTime NgayThanhToan { get; set; }

        public bool TrangThai { get; set; }

        public decimal TongTien { get; set; }

        public virtual HoaDon HoaDon { get; set; }
    }
}
