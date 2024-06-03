using System.ComponentModel.DataAnnotations;

namespace VerssClub.Models
{
    public class Voucher
    {
        [Key]
        public int MaVoucher { get; set; }

        [Required]
        [MaxLength(100)]
        public string TenVoucher { get; set; }

        public DateTime NgayTao { get; set; }

        public DateTime NgayBatDau { get; set; }

        public DateTime NgayKetThuc { get; set; }

        public bool TrangThai { get; set; }

        public float PhanTramGiam { get; set; }

        public virtual ICollection<HoaDon> HoaDons { get; set; }
    }
}
