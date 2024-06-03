using Microsoft.EntityFrameworkCore;

namespace VerssClub.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext()
        {
            
        }

        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=VGiap;IDESKTOP-77H263D\\SQLEXPRESSitial Catalog=VerssClubDB;Trusted_Connection=True;Integrated Security=True;TrustServerCertificate=True");

        }
        public DbSet<ChucVu> ChucVus { get; set; }
        public DbSet<ThuongHieu> ThuongHieus { get; set; }
        public DbSet<LoaiSanPham> LoaiSanPhams { get; set; }
        public DbSet<ChatLieu> ChatLieus { get; set; }
        public DbSet<XuatXu> XuatXus { get; set; }
        public DbSet<Size> Sizes { get; set; }
        public DbSet<LoaiMau> LoaiMaus { get; set; }
        public DbSet<NhanVien> NhanViens { get; set; }
        public DbSet<KhachHang> KhachHangs { get; set; }
        public DbSet<GioHang> GioHangs { get; set; }
        public DbSet<GioHangCT> GioHangCTs { get; set; }
        public DbSet<Voucher> Vouchers { get; set; }
        public DbSet<KhachHangVoucher> KhachHangVouchers { get; set; }
        public DbSet<HoaDon> HoaDons { get; set; }
        public DbSet<ThanhToan> ThanhToans { get; set; }
        public DbSet<SanPham> SanPhams { get; set; }
        public DbSet<SanPhamCT> SanPhamCTs { get; set; }
        public DbSet<GiamGia> GiamGias { get; set; }
        public DbSet<HoaDonCT> HoaDonCTs { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<DanhGia> DanhGias { get; set; }
    }
}
