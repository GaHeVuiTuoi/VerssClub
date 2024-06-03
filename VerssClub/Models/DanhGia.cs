using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VerssClub.Models
{
    public class DanhGia
    {
        [Key]
        public int MaDanhGia { get; set; }
        
        public int MaSanPhamCT { get; set; }
        [ForeignKey("MaSanPhamCT")]
        public int MaKhachHang { get; set; }
        [ForeignKey("MaKhachHang")]
        public string MoTa { get; set; }

        public string HinhAnh { get; set; }

        public DateTime NgayDang { get; set; }

        public int SoSao { get; set; }

        public virtual SanPhamCT SanPhamCT { get; set; }
        public virtual KhachHang KhachHang { get; set; }
    }
}
