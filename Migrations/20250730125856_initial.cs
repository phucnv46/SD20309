using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SD20309.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "KhachHangs",
                columns: table => new
                {
                    MaKhachHang = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HoTen = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SoDienThoai = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DiaChi = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhachHangs", x => x.MaKhachHang);
                });

            migrationBuilder.CreateTable(
                name: "LoaiSanPham",
                columns: table => new
                {
                    MaLoai = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenLoai = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MoTa = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoaiSanPham", x => x.MaLoai);
                });

            migrationBuilder.CreateTable(
                name: "NhanViens",
                columns: table => new
                {
                    MaNhanVien = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenNhanVien = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SoDienThoai = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DiaChi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GioiTinh = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhanViens", x => x.MaNhanVien);
                });

            migrationBuilder.CreateTable(
                name: "ThuocTinh",
                columns: table => new
                {
                    Ma = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenThuocTinh = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThuocTinh", x => x.Ma);
                });

            migrationBuilder.CreateTable(
                name: "Vouchers",
                columns: table => new
                {
                    MaVoucher = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TenVouCher = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LoaiGiam = table.Column<int>(type: "int", nullable: false),
                    GiaTriGiam = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    HanSuDung = table.Column<DateOnly>(type: "date", nullable: false),
                    GiaTriApDung = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    GiaTriGiamToiDa = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    TrangThai = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vouchers", x => x.MaVoucher);
                });

            migrationBuilder.CreateTable(
                name: "SanPhams",
                columns: table => new
                {
                    MaSanPham = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TenSanPham = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MoTa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SoLuong = table.Column<long>(type: "bigint", nullable: false),
                    MaLoaiSanPham = table.Column<long>(type: "bigint", nullable: false),
                    LoaiSanPhamMaLoai = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SanPhams", x => x.MaSanPham);
                    table.ForeignKey(
                        name: "FK_SanPhams_LoaiSanPham_LoaiSanPhamMaLoai",
                        column: x => x.LoaiSanPhamMaLoai,
                        principalTable: "LoaiSanPham",
                        principalColumn: "MaLoai",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HoaDon",
                columns: table => new
                {
                    MaHoaDon = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ThoiGianTao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TongHoaDon = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TongTienGiam = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ThanhTien = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MaNhanVien = table.Column<long>(type: "bigint", nullable: false),
                    MaKhachHang = table.Column<long>(type: "bigint", nullable: true),
                    MaVoucher = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoaDon", x => x.MaHoaDon);
                    table.ForeignKey(
                        name: "FK_HoaDon_KhachHangs_MaKhachHang",
                        column: x => x.MaKhachHang,
                        principalTable: "KhachHangs",
                        principalColumn: "MaKhachHang");
                    table.ForeignKey(
                        name: "FK_HoaDon_NhanViens_MaNhanVien",
                        column: x => x.MaNhanVien,
                        principalTable: "NhanViens",
                        principalColumn: "MaNhanVien",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HoaDon_Vouchers_MaVoucher",
                        column: x => x.MaVoucher,
                        principalTable: "Vouchers",
                        principalColumn: "MaVoucher");
                });

            migrationBuilder.CreateTable(
                name: "SanPhamChiTiets",
                columns: table => new
                {
                    Ma = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MaSanPham = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Gia = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SoLuong = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SanPhamChiTiets", x => x.Ma);
                    table.ForeignKey(
                        name: "FK_SanPhamChiTiets_SanPhams_MaSanPham",
                        column: x => x.MaSanPham,
                        principalTable: "SanPhams",
                        principalColumn: "MaSanPham",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HoaDonChiTiet",
                columns: table => new
                {
                    MaHoaDon = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MaSanPham = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SoLuong = table.Column<long>(type: "bigint", nullable: false),
                    DonGia = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoaDonChiTiet", x => new { x.MaHoaDon, x.MaSanPham });
                    table.ForeignKey(
                        name: "FK_HoaDonChiTiet_HoaDon_MaHoaDon",
                        column: x => x.MaHoaDon,
                        principalTable: "HoaDon",
                        principalColumn: "MaHoaDon",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HoaDonChiTiet_SanPhams_MaSanPham",
                        column: x => x.MaSanPham,
                        principalTable: "SanPhams",
                        principalColumn: "MaSanPham",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SanPhamChiTiet_ThuocTinh",
                columns: table => new
                {
                    MaSanPhamChiTiet = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MaThuocTinh = table.Column<long>(type: "bigint", nullable: false),
                    GiaTri = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KieuDuLieu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SanPhamChiTiet_ThuocTinhMaSanPhamChiTiet = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    SanPhamChiTiet_ThuocTinhMaThuocTinh = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SanPhamChiTiet_ThuocTinh", x => new { x.MaSanPhamChiTiet, x.MaThuocTinh });
                    table.ForeignKey(
                        name: "FK_SanPhamChiTiet_ThuocTinh_SanPhamChiTiet_ThuocTinh_SanPhamChiTiet_ThuocTinhMaSanPhamChiTiet_SanPhamChiTiet_ThuocTinhMaThuocTi~",
                        columns: x => new { x.SanPhamChiTiet_ThuocTinhMaSanPhamChiTiet, x.SanPhamChiTiet_ThuocTinhMaThuocTinh },
                        principalTable: "SanPhamChiTiet_ThuocTinh",
                        principalColumns: new[] { "MaSanPhamChiTiet", "MaThuocTinh" });
                    table.ForeignKey(
                        name: "FK_SanPhamChiTiet_ThuocTinh_SanPhamChiTiets_MaSanPhamChiTiet",
                        column: x => x.MaSanPhamChiTiet,
                        principalTable: "SanPhamChiTiets",
                        principalColumn: "Ma",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SanPhamChiTiet_ThuocTinh_ThuocTinh_MaThuocTinh",
                        column: x => x.MaThuocTinh,
                        principalTable: "ThuocTinh",
                        principalColumn: "Ma",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_HoaDon_MaKhachHang",
                table: "HoaDon",
                column: "MaKhachHang");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDon_MaNhanVien",
                table: "HoaDon",
                column: "MaNhanVien");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDon_MaVoucher",
                table: "HoaDon",
                column: "MaVoucher");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDonChiTiet_MaSanPham",
                table: "HoaDonChiTiet",
                column: "MaSanPham");

            migrationBuilder.CreateIndex(
                name: "IX_SanPhamChiTiet_ThuocTinh_MaThuocTinh",
                table: "SanPhamChiTiet_ThuocTinh",
                column: "MaThuocTinh");

            migrationBuilder.CreateIndex(
                name: "IX_SanPhamChiTiet_ThuocTinh_SanPhamChiTiet_ThuocTinhMaSanPhamChiTiet_SanPhamChiTiet_ThuocTinhMaThuocTinh",
                table: "SanPhamChiTiet_ThuocTinh",
                columns: new[] { "SanPhamChiTiet_ThuocTinhMaSanPhamChiTiet", "SanPhamChiTiet_ThuocTinhMaThuocTinh" });

            migrationBuilder.CreateIndex(
                name: "IX_SanPhamChiTiets_MaSanPham",
                table: "SanPhamChiTiets",
                column: "MaSanPham");

            migrationBuilder.CreateIndex(
                name: "IX_SanPhams_LoaiSanPhamMaLoai",
                table: "SanPhams",
                column: "LoaiSanPhamMaLoai");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HoaDonChiTiet");

            migrationBuilder.DropTable(
                name: "SanPhamChiTiet_ThuocTinh");

            migrationBuilder.DropTable(
                name: "HoaDon");

            migrationBuilder.DropTable(
                name: "SanPhamChiTiets");

            migrationBuilder.DropTable(
                name: "ThuocTinh");

            migrationBuilder.DropTable(
                name: "KhachHangs");

            migrationBuilder.DropTable(
                name: "NhanViens");

            migrationBuilder.DropTable(
                name: "Vouchers");

            migrationBuilder.DropTable(
                name: "SanPhams");

            migrationBuilder.DropTable(
                name: "LoaiSanPham");
        }
    }
}
