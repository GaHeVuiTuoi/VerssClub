using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace VerssClub.Models
{
    public class KhachHangVoucher
    {
        [Key, Column(Order = 0)]
        public int MaKhachHang { get; set; }

        [Key, Column(Order = 1)]
        public int MaVoucher { get; set; }

        public virtual KhachHang KhachHang { get; set; }

        public virtual Voucher Voucher { get; set; }
    }
}
