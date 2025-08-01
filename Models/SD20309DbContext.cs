using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO.Pipelines;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SD20309.Models
{
    public class SD20309DbContext : DbContext
    {
        public virtual DbSet<HoaDon> HoaDon { get; set; }
        public virtual DbSet<HoaDonChiTiet> HoaDonChiTiet { get; set; }
        public virtual DbSet<KhachHang> KhachHang { get; set; }
        public virtual DbSet<NhanVien> NhanVien { get; set; }
        public virtual DbSet<SanPham> SanPham { get; set; }
        public virtual DbSet<SanPhamChiTiet> SanPhamChiTiet { get; set; }
        public virtual DbSet<SanPhamChiTiet_ThuocTinh> SanPhamChiTiet_ThuocTinh { get; set; }
        public virtual DbSet<ThuocTinh> ThuocTinh { get; set; }
        public virtual DbSet<LoaiSanPham> LoaiSanPham { get; set; }
        public virtual DbSet<Voucher> Voucher { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder opt)
        {
            opt.UseSqlServer("Server = \np:\\\\.\\pipe\\LOCALDB#FF3190D6\\tsql\\query;Database=\"SD20309\";");
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Seeding dữ liệu
            // Cần đảm bảo thứ tự seeding để không vi phạm ràng buộc khóa ngoại (foreign key)

            #region Seeding LoaiSanPham
            modelBuilder.Entity<LoaiSanPham>().HasData(
                new LoaiSanPham { MaLoai = 1, TenLoai = "Laptop", MoTa = "Các loại máy tính xách tay đa dụng và chuyên dụng." },
                new LoaiSanPham { MaLoai = 2, TenLoai = "PC Gaming", MoTa = "Máy tính để bàn chuyên chơi game hiệu năng cao." },
                new LoaiSanPham { MaLoai = 3, TenLoai = "Màn Hình", MoTa = "Các loại màn hình máy tính từ phổ thông đến chuyên nghiệp." },
                new LoaiSanPham { MaLoai = 4, TenLoai = "Bàn Phím", MoTa = "Bàn phím cơ, giả cơ và văn phòng." },
                new LoaiSanPham { MaLoai = 5, TenLoai = "Chuột", MoTa = "Chuột gaming, văn phòng và không dây." }
            );
            #endregion

            #region Seeding SanPham
            modelBuilder.Entity<SanPham>().HasData(
                new SanPham { MaSanPham = "LT001", TenSanPham = "Laptop Gaming Acer Nitro 5", MoTa = "Laptop gaming mạnh mẽ với CPU Intel Core i7 và GPU RTX 3050.", SoLuong = 50, MaLoaiSanPham = 1 },
                new SanPham { MaSanPham = "LT002", TenSanPham = "Laptop Dell XPS 15", MoTa = "Laptop cao cấp cho công việc và thiết kế.", SoLuong = 30, MaLoaiSanPham = 1 },
                new SanPham { MaSanPham = "MH001", TenSanPham = "Màn Hình Dell UltraSharp U2723QE", MoTa = "Màn hình 4K IPS chuyên đồ họa.", SoLuong = 40, MaLoaiSanPham = 3 }
            );
            #endregion

            #region Seeding SanPhamChiTiet
            modelBuilder.Entity<SanPhamChiTiet>().HasData(
                new SanPhamChiTiet { Ma = "LT001_1", MaSanPham = "LT001", Gia = 25000000.00m, SoLuong = 20, AnhSP = "https://example.com/images/acer-nitro-5-1.jpg" },
                new SanPhamChiTiet { Ma = "LT001_2", MaSanPham = "LT001", Gia = 28500000.00m, SoLuong = 30, AnhSP = "https://example.com/images/acer-nitro-5-2.jpg" },
                new SanPhamChiTiet { Ma = "MH001_B", MaSanPham = "MH001", Gia = 12000000.00m, SoLuong = 40, AnhSP = "https://example.com/images/dell-monitor-b.jpg" }
            );
            #endregion

            #region Seeding ThuocTinh
            modelBuilder.Entity<ThuocTinh>().HasData(
                new ThuocTinh { Ma = 1, TenThuocTinh = "Màu Sắc" },
                new ThuocTinh { Ma = 2, TenThuocTinh = "Bộ Vi Xử Lý" },
                new ThuocTinh { Ma = 3, TenThuocTinh = "RAM" },
                new ThuocTinh { Ma = 4, TenThuocTinh = "Ổ Cứng" }
            );
            #endregion

            #region Seeding SanPhamChiTiet_ThuocTinh
            modelBuilder.Entity<SanPhamChiTiet_ThuocTinh>().HasData(
                new SanPhamChiTiet_ThuocTinh { MaSanPhamChiTiet = "LT001_1", MaThuocTinh = 1, GiaTri = "Đen" },
                new SanPhamChiTiet_ThuocTinh { MaSanPhamChiTiet = "LT001_1", MaThuocTinh = 2, GiaTri = "Intel Core i7-12700H" },
                new SanPhamChiTiet_ThuocTinh { MaSanPhamChiTiet = "LT001_1", MaThuocTinh = 3, GiaTri = "16GB DDR4" },
                new SanPhamChiTiet_ThuocTinh { MaSanPhamChiTiet = "MH001_B", MaThuocTinh = 1, GiaTri = "Đen" }
            );
            #endregion

            #region Seeding KhachHang
            modelBuilder.Entity<KhachHang>().HasData(
                new KhachHang { MaKhachHang = 1, HoTen = "Nguyễn Văn A", SoDienThoai = "0901112233", Email = "nguyenvana@example.com", DiaChi = "123 Nguyễn Trãi, Thanh Xuân, Hà Nội" },
                new KhachHang { MaKhachHang = 2, HoTen = "Trần Thị B", SoDienThoai = "0987654321", Email = "tranb@example.com", DiaChi = "456 Lê Lợi, Quận 1, TP. Hồ Chí Minh" }
            );
            #endregion

            #region Seeding NhanVien
            // VaiTro là một enum, bạn cần truyền giá trị số tương ứng (0 hoặc 1)
            modelBuilder.Entity<NhanVien>().HasData(
                new NhanVien { MaNhanVien = 1, TenNhanVien = "Nguyễn Thị Thu", SoDienThoai = "0909123456", Email = "thunt@example.com", GioiTinh = false, VaiTro = VaiTro.QuanLy, TaiKhoan = "thu_ql", MatKhau = "123456" },
                new NhanVien { MaNhanVien = 2, TenNhanVien = "Lê Đức Anh", SoDienThoai = "0978901234", Email = "anhl@example.com", GioiTinh = true, VaiTro = VaiTro.NhanVien, TaiKhoan = "anh_nv", MatKhau = "123456" }
            );
            #endregion

            #region Seeding Voucher
            // LoaiGiam là một enum, bạn cần truyền giá trị số tương ứng (0 hoặc 1)
            modelBuilder.Entity<Voucher>().HasData(
                new Voucher { MaVoucher = "SUMMER25", TenVouCher = "Ưu đãi hè 25%", LoaiGiam = LoaiGiam.GiamPhanTram, GiaTriGiam = 0.25m, HanSuDung = DateOnly.Parse("2025-08-31"), GiaTriApDung = 5000000.00m, GiaTriGiamToiDa = 1000000.00m, TrangThai = true },
                new Voucher { MaVoucher = "FREESHIP", TenVouCher = "Miễn phí vận chuyển", LoaiGiam = LoaiGiam.GiamTienCoDinh, GiaTriGiam = 30000.00m, HanSuDung = DateOnly.Parse("2025-12-31"), GiaTriApDung = 1000000.00m, GiaTriGiamToiDa = 0.00m, TrangThai = true }
            );
            #endregion

            #region Seeding HoaDon
            modelBuilder.Entity<HoaDon>().HasData(
                new HoaDon { MaHoaDon = "HD001", ThoiGianTao = DateTime.Now, TongHoaDon = 25000000.00m, TongTienGiam = 0, ThanhTien = 25000000.00m, MaNhanVien = 1, MaKhachHang = 1, MaVoucher = null },
                new HoaDon { MaHoaDon = "HD002", ThoiGianTao = DateTime.Now, TongHoaDon = 35000000.00m, TongTienGiam = 1000000.00m, ThanhTien = 34000000.00m, MaNhanVien = 2, MaKhachHang = 2, MaVoucher = "SUMMER25" }
            );
            #endregion

            #region Seeding HoaDonChiTiet
            modelBuilder.Entity<HoaDonChiTiet>().HasData(
                new HoaDonChiTiet { MaHoaDon = "HD001", MaSanPham = "LT001", SoLuong = 1, DonGia = 25000000.00m },
                new HoaDonChiTiet { MaHoaDon = "HD002", MaSanPham = "LT002", SoLuong = 1, DonGia = 35000000.00m }
            );
            #endregion

            base.OnModelCreating(modelBuilder);
        }
    }
}
