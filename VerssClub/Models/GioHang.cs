using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VerssClub.Models
{
    public class GioHang
    {
        [Key]
        public int MaGioHang { get; set; }
        
        public int MaKhachHang { get; set; }
        [ForeignKey("MaKhachHang")]
        public virtual KhachHang KhachHang { get; set; }
        public virtual ICollection<GioHangCT> GioHangCTs { get; set; }
    }
}
