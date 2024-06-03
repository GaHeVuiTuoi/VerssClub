using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VerssClub.Models
{
    public class HoaDon
    {
        [Key]
        public int MaHoaDon { get; set; }
        
        public int MaKhachHang { get; set; }
        [ForeignKey("MaKhachHang")]
        
        public int MaVoucher { get; set; }
        [ForeignKey("MaVoucher")]
        
        public int MaNhanVien { get; set; }
        [ForeignKey("MaNhanVien")]

        public DateTime NgayTao { get; set; }

        public bool TrangThai { get; set; }

        public string GhiChu { get; set; }

        public decimal TongTien { get; set; }

        public virtual KhachHang KhachHang { get; set; }
        public virtual Voucher Voucher { get; set; }
        public virtual NhanVien NhanVien { get; set; }
        public virtual ICollection<HoaDonCT> HoaDonCTs{ get; set; }
    }
}
