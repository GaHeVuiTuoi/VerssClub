    using System.ComponentModel.DataAnnotations;

namespace VerssClub.Models
{
    public class KhachHang
    {
        [Key]
        public int MaKhachHang { get; set; }

        [Required]
        [MaxLength(50)]
        public string TenKhachHang { get; set; }

        public bool GioiTinh { get; set; }

        [Required]
        [MaxLength(15)]
        public string SDT { get; set; }

        [Required]
        [MaxLength(100)]
        public string Email { get; set; }

        public string DiaChi { get; set; }

        [Required]
        [MaxLength(50)]
        public string MatKhau { get; set; }

        public DateTime NgaySinh { get; set; }

        public virtual ICollection<GioHang> GioHangs { get; set; }
        public virtual ICollection<HoaDon> HoaDons { get; set; }
        public virtual ICollection<KhachHangVoucher> KhachHangVouchers { get; set; }

    }
}

