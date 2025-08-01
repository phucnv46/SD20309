using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SD20309.Migrations
{
    /// <inheritdoc />
    public partial class KhoiTao : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SanPham_LoaiSanPham_LoaiSanPhamMaLoai",
                table: "SanPham");

            migrationBuilder.DropIndex(
                name: "IX_SanPham_LoaiSanPhamMaLoai",
                table: "SanPham");

            migrationBuilder.DropColumn(
                name: "LoaiSanPhamMaLoai",
                table: "SanPham");

            migrationBuilder.AddColumn<string>(
                name: "AnhSP",
                table: "SanPhamChiTiet",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MatKhau",
                table: "NhanVien",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TaiKhoan",
                table: "NhanVien",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "VaiTro",
                table: "NhanVien",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "KhachHang",
                columns: new[] { "MaKhachHang", "DiaChi", "Email", "HoTen", "SoDienThoai" },
                values: new object[,]
                {
                    { 1L, "123 Nguyễn Trãi, Thanh Xuân, Hà Nội", "nguyenvana@example.com", "Nguyễn Văn A", "0901112233" },
                    { 2L, "456 Lê Lợi, Quận 1, TP. Hồ Chí Minh", "tranb@example.com", "Trần Thị B", "0987654321" }
                });

            migrationBuilder.InsertData(
                table: "LoaiSanPham",
                columns: new[] { "MaLoai", "MoTa", "TenLoai" },
                values: new object[,]
                {
                    { 1L, "Các loại máy tính xách tay đa dụng và chuyên dụng.", "Laptop" },
                    { 2L, "Máy tính để bàn chuyên chơi game hiệu năng cao.", "PC Gaming" },
                    { 3L, "Các loại màn hình máy tính từ phổ thông đến chuyên nghiệp.", "Màn Hình" },
                    { 4L, "Bàn phím cơ, giả cơ và văn phòng.", "Bàn Phím" },
                    { 5L, "Chuột gaming, văn phòng và không dây.", "Chuột" }
                });

            migrationBuilder.InsertData(
                table: "NhanVien",
                columns: new[] { "MaNhanVien", "DiaChi", "Email", "GioiTinh", "MatKhau", "SoDienThoai", "TaiKhoan", "TenNhanVien", "VaiTro" },
                values: new object[,]
                {
                    { 1L, null, "thunt@example.com", false, "123456", "0909123456", "thu_ql", "Nguyễn Thị Thu", 1 },
                    { 2L, null, "anhl@example.com", true, "123456", "0978901234", "anh_nv", "Lê Đức Anh", 0 }
                });

            migrationBuilder.InsertData(
                table: "ThuocTinh",
                columns: new[] { "Ma", "TenThuocTinh" },
                values: new object[,]
                {
                    { 1L, "Màu Sắc" },
                    { 2L, "Bộ Vi Xử Lý" },
                    { 3L, "RAM" },
                    { 4L, "Ổ Cứng" }
                });

            migrationBuilder.InsertData(
                table: "Voucher",
                columns: new[] { "MaVoucher", "GiaTriApDung", "GiaTriGiam", "GiaTriGiamToiDa", "HanSuDung", "LoaiGiam", "TenVouCher", "TrangThai" },
                values: new object[,]
                {
                    { "FREESHIP", 1000000.00m, 30000.00m, 0.00m, new DateOnly(2025, 12, 31), 1, "Miễn phí vận chuyển", true },
                    { "SUMMER25", 5000000.00m, 0.25m, 1000000.00m, new DateOnly(2025, 8, 31), 0, "Ưu đãi hè 25%", true }
                });

            migrationBuilder.InsertData(
                table: "HoaDon",
                columns: new[] { "MaHoaDon", "MaKhachHang", "MaNhanVien", "MaVoucher", "ThanhTien", "ThoiGianTao", "TongHoaDon", "TongTienGiam" },
                values: new object[,]
                {
                    { "HD001", 1L, 1L, null, 25000000.00m, new DateTime(2025, 8, 1, 18, 48, 53, 94, DateTimeKind.Local).AddTicks(7246), 25000000.00m, 0m },
                    { "HD002", 2L, 2L, "SUMMER25", 34000000.00m, new DateTime(2025, 8, 1, 18, 48, 53, 95, DateTimeKind.Local).AddTicks(54), 35000000.00m, 1000000.00m }
                });

            migrationBuilder.InsertData(
                table: "SanPham",
                columns: new[] { "MaSanPham", "MaLoaiSanPham", "MoTa", "SoLuong", "TenSanPham" },
                values: new object[,]
                {
                    { "LT001", 1L, "Laptop gaming mạnh mẽ với CPU Intel Core i7 và GPU RTX 3050.", 50L, "Laptop Gaming Acer Nitro 5" },
                    { "LT002", 1L, "Laptop cao cấp cho công việc và thiết kế.", 30L, "Laptop Dell XPS 15" },
                    { "MH001", 3L, "Màn hình 4K IPS chuyên đồ họa.", 40L, "Màn Hình Dell UltraSharp U2723QE" }
                });

            migrationBuilder.InsertData(
                table: "HoaDonChiTiet",
                columns: new[] { "MaHoaDon", "MaSanPham", "DonGia", "SoLuong" },
                values: new object[,]
                {
                    { "HD001", "LT001", 25000000.00m, 1L },
                    { "HD002", "LT002", 35000000.00m, 1L }
                });

            migrationBuilder.InsertData(
                table: "SanPhamChiTiet",
                columns: new[] { "Ma", "AnhSP", "Gia", "MaSanPham", "SoLuong" },
                values: new object[,]
                {
                    { "LT001_1", "https://example.com/images/acer-nitro-5-1.jpg", 25000000.00m, "LT001", 20L },
                    { "LT001_2", "https://example.com/images/acer-nitro-5-2.jpg", 28500000.00m, "LT001", 30L },
                    { "MH001_B", "https://example.com/images/dell-monitor-b.jpg", 12000000.00m, "MH001", 40L }
                });

            migrationBuilder.InsertData(
                table: "SanPhamChiTiet_ThuocTinh",
                columns: new[] { "MaSanPhamChiTiet", "MaThuocTinh", "GiaTri", "KieuDuLieu", "SanPhamChiTiet_ThuocTinhMaSanPhamChiTiet", "SanPhamChiTiet_ThuocTinhMaThuocTinh" },
                values: new object[,]
                {
                    { "LT001_1", 1L, "Đen", null, null, null },
                    { "LT001_1", 2L, "Intel Core i7-12700H", null, null, null },
                    { "LT001_1", 3L, "16GB DDR4", null, null, null },
                    { "MH001_B", 1L, "Đen", null, null, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_SanPham_MaLoaiSanPham",
                table: "SanPham",
                column: "MaLoaiSanPham");

            migrationBuilder.AddForeignKey(
                name: "FK_SanPham_LoaiSanPham_MaLoaiSanPham",
                table: "SanPham",
                column: "MaLoaiSanPham",
                principalTable: "LoaiSanPham",
                principalColumn: "MaLoai",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SanPham_LoaiSanPham_MaLoaiSanPham",
                table: "SanPham");

            migrationBuilder.DropIndex(
                name: "IX_SanPham_MaLoaiSanPham",
                table: "SanPham");

            migrationBuilder.DeleteData(
                table: "HoaDonChiTiet",
                keyColumns: new[] { "MaHoaDon", "MaSanPham" },
                keyValues: new object[] { "HD001", "LT001" });

            migrationBuilder.DeleteData(
                table: "HoaDonChiTiet",
                keyColumns: new[] { "MaHoaDon", "MaSanPham" },
                keyValues: new object[] { "HD002", "LT002" });

            migrationBuilder.DeleteData(
                table: "LoaiSanPham",
                keyColumn: "MaLoai",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "LoaiSanPham",
                keyColumn: "MaLoai",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "LoaiSanPham",
                keyColumn: "MaLoai",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "SanPhamChiTiet",
                keyColumn: "Ma",
                keyValue: "LT001_2");

            migrationBuilder.DeleteData(
                table: "SanPhamChiTiet_ThuocTinh",
                keyColumns: new[] { "MaSanPhamChiTiet", "MaThuocTinh" },
                keyValues: new object[] { "LT001_1", 1L });

            migrationBuilder.DeleteData(
                table: "SanPhamChiTiet_ThuocTinh",
                keyColumns: new[] { "MaSanPhamChiTiet", "MaThuocTinh" },
                keyValues: new object[] { "LT001_1", 2L });

            migrationBuilder.DeleteData(
                table: "SanPhamChiTiet_ThuocTinh",
                keyColumns: new[] { "MaSanPhamChiTiet", "MaThuocTinh" },
                keyValues: new object[] { "LT001_1", 3L });

            migrationBuilder.DeleteData(
                table: "SanPhamChiTiet_ThuocTinh",
                keyColumns: new[] { "MaSanPhamChiTiet", "MaThuocTinh" },
                keyValues: new object[] { "MH001_B", 1L });

            migrationBuilder.DeleteData(
                table: "ThuocTinh",
                keyColumn: "Ma",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Voucher",
                keyColumn: "MaVoucher",
                keyValue: "FREESHIP");

            migrationBuilder.DeleteData(
                table: "HoaDon",
                keyColumn: "MaHoaDon",
                keyValue: "HD001");

            migrationBuilder.DeleteData(
                table: "HoaDon",
                keyColumn: "MaHoaDon",
                keyValue: "HD002");

            migrationBuilder.DeleteData(
                table: "SanPham",
                keyColumn: "MaSanPham",
                keyValue: "LT002");

            migrationBuilder.DeleteData(
                table: "SanPhamChiTiet",
                keyColumn: "Ma",
                keyValue: "LT001_1");

            migrationBuilder.DeleteData(
                table: "SanPhamChiTiet",
                keyColumn: "Ma",
                keyValue: "MH001_B");

            migrationBuilder.DeleteData(
                table: "ThuocTinh",
                keyColumn: "Ma",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "ThuocTinh",
                keyColumn: "Ma",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "ThuocTinh",
                keyColumn: "Ma",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "KhachHang",
                keyColumn: "MaKhachHang",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "KhachHang",
                keyColumn: "MaKhachHang",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "NhanVien",
                keyColumn: "MaNhanVien",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "NhanVien",
                keyColumn: "MaNhanVien",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "SanPham",
                keyColumn: "MaSanPham",
                keyValue: "LT001");

            migrationBuilder.DeleteData(
                table: "SanPham",
                keyColumn: "MaSanPham",
                keyValue: "MH001");

            migrationBuilder.DeleteData(
                table: "Voucher",
                keyColumn: "MaVoucher",
                keyValue: "SUMMER25");

            migrationBuilder.DeleteData(
                table: "LoaiSanPham",
                keyColumn: "MaLoai",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "LoaiSanPham",
                keyColumn: "MaLoai",
                keyValue: 3L);

            migrationBuilder.DropColumn(
                name: "AnhSP",
                table: "SanPhamChiTiet");

            migrationBuilder.DropColumn(
                name: "MatKhau",
                table: "NhanVien");

            migrationBuilder.DropColumn(
                name: "TaiKhoan",
                table: "NhanVien");

            migrationBuilder.DropColumn(
                name: "VaiTro",
                table: "NhanVien");

            migrationBuilder.AddColumn<long>(
                name: "LoaiSanPhamMaLoai",
                table: "SanPham",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateIndex(
                name: "IX_SanPham_LoaiSanPhamMaLoai",
                table: "SanPham",
                column: "LoaiSanPhamMaLoai");

            migrationBuilder.AddForeignKey(
                name: "FK_SanPham_LoaiSanPham_LoaiSanPhamMaLoai",
                table: "SanPham",
                column: "LoaiSanPhamMaLoai",
                principalTable: "LoaiSanPham",
                principalColumn: "MaLoai",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
