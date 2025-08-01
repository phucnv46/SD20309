using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SD20309.Migrations
{
    /// <inheritdoc />
    public partial class suaTen : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HoaDon_KhachHangs_MaKhachHang",
                table: "HoaDon");

            migrationBuilder.DropForeignKey(
                name: "FK_HoaDon_NhanViens_MaNhanVien",
                table: "HoaDon");

            migrationBuilder.DropForeignKey(
                name: "FK_HoaDon_Vouchers_MaVoucher",
                table: "HoaDon");

            migrationBuilder.DropForeignKey(
                name: "FK_HoaDonChiTiet_SanPhams_MaSanPham",
                table: "HoaDonChiTiet");

            migrationBuilder.DropForeignKey(
                name: "FK_SanPhamChiTiet_ThuocTinh_SanPhamChiTiets_MaSanPhamChiTiet",
                table: "SanPhamChiTiet_ThuocTinh");

            migrationBuilder.DropForeignKey(
                name: "FK_SanPhamChiTiets_SanPhams_MaSanPham",
                table: "SanPhamChiTiets");

            migrationBuilder.DropForeignKey(
                name: "FK_SanPhams_LoaiSanPham_LoaiSanPhamMaLoai",
                table: "SanPhams");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Vouchers",
                table: "Vouchers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SanPhams",
                table: "SanPhams");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SanPhamChiTiets",
                table: "SanPhamChiTiets");

            migrationBuilder.DropPrimaryKey(
                name: "PK_NhanViens",
                table: "NhanViens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_KhachHangs",
                table: "KhachHangs");

            migrationBuilder.RenameTable(
                name: "Vouchers",
                newName: "Voucher");

            migrationBuilder.RenameTable(
                name: "SanPhams",
                newName: "SanPham");

            migrationBuilder.RenameTable(
                name: "SanPhamChiTiets",
                newName: "SanPhamChiTiet");

            migrationBuilder.RenameTable(
                name: "NhanViens",
                newName: "NhanVien");

            migrationBuilder.RenameTable(
                name: "KhachHangs",
                newName: "KhachHang");

            migrationBuilder.RenameIndex(
                name: "IX_SanPhams_LoaiSanPhamMaLoai",
                table: "SanPham",
                newName: "IX_SanPham_LoaiSanPhamMaLoai");

            migrationBuilder.RenameIndex(
                name: "IX_SanPhamChiTiets_MaSanPham",
                table: "SanPhamChiTiet",
                newName: "IX_SanPhamChiTiet_MaSanPham");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Voucher",
                table: "Voucher",
                column: "MaVoucher");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SanPham",
                table: "SanPham",
                column: "MaSanPham");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SanPhamChiTiet",
                table: "SanPhamChiTiet",
                column: "Ma");

            migrationBuilder.AddPrimaryKey(
                name: "PK_NhanVien",
                table: "NhanVien",
                column: "MaNhanVien");

            migrationBuilder.AddPrimaryKey(
                name: "PK_KhachHang",
                table: "KhachHang",
                column: "MaKhachHang");

            migrationBuilder.AddForeignKey(
                name: "FK_HoaDon_KhachHang_MaKhachHang",
                table: "HoaDon",
                column: "MaKhachHang",
                principalTable: "KhachHang",
                principalColumn: "MaKhachHang");

            migrationBuilder.AddForeignKey(
                name: "FK_HoaDon_NhanVien_MaNhanVien",
                table: "HoaDon",
                column: "MaNhanVien",
                principalTable: "NhanVien",
                principalColumn: "MaNhanVien",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HoaDon_Voucher_MaVoucher",
                table: "HoaDon",
                column: "MaVoucher",
                principalTable: "Voucher",
                principalColumn: "MaVoucher");

            migrationBuilder.AddForeignKey(
                name: "FK_HoaDonChiTiet_SanPham_MaSanPham",
                table: "HoaDonChiTiet",
                column: "MaSanPham",
                principalTable: "SanPham",
                principalColumn: "MaSanPham",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SanPham_LoaiSanPham_LoaiSanPhamMaLoai",
                table: "SanPham",
                column: "LoaiSanPhamMaLoai",
                principalTable: "LoaiSanPham",
                principalColumn: "MaLoai",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SanPhamChiTiet_SanPham_MaSanPham",
                table: "SanPhamChiTiet",
                column: "MaSanPham",
                principalTable: "SanPham",
                principalColumn: "MaSanPham",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SanPhamChiTiet_ThuocTinh_SanPhamChiTiet_MaSanPhamChiTiet",
                table: "SanPhamChiTiet_ThuocTinh",
                column: "MaSanPhamChiTiet",
                principalTable: "SanPhamChiTiet",
                principalColumn: "Ma",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HoaDon_KhachHang_MaKhachHang",
                table: "HoaDon");

            migrationBuilder.DropForeignKey(
                name: "FK_HoaDon_NhanVien_MaNhanVien",
                table: "HoaDon");

            migrationBuilder.DropForeignKey(
                name: "FK_HoaDon_Voucher_MaVoucher",
                table: "HoaDon");

            migrationBuilder.DropForeignKey(
                name: "FK_HoaDonChiTiet_SanPham_MaSanPham",
                table: "HoaDonChiTiet");

            migrationBuilder.DropForeignKey(
                name: "FK_SanPham_LoaiSanPham_LoaiSanPhamMaLoai",
                table: "SanPham");

            migrationBuilder.DropForeignKey(
                name: "FK_SanPhamChiTiet_SanPham_MaSanPham",
                table: "SanPhamChiTiet");

            migrationBuilder.DropForeignKey(
                name: "FK_SanPhamChiTiet_ThuocTinh_SanPhamChiTiet_MaSanPhamChiTiet",
                table: "SanPhamChiTiet_ThuocTinh");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Voucher",
                table: "Voucher");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SanPhamChiTiet",
                table: "SanPhamChiTiet");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SanPham",
                table: "SanPham");

            migrationBuilder.DropPrimaryKey(
                name: "PK_NhanVien",
                table: "NhanVien");

            migrationBuilder.DropPrimaryKey(
                name: "PK_KhachHang",
                table: "KhachHang");

            migrationBuilder.RenameTable(
                name: "Voucher",
                newName: "Vouchers");

            migrationBuilder.RenameTable(
                name: "SanPhamChiTiet",
                newName: "SanPhamChiTiets");

            migrationBuilder.RenameTable(
                name: "SanPham",
                newName: "SanPhams");

            migrationBuilder.RenameTable(
                name: "NhanVien",
                newName: "NhanViens");

            migrationBuilder.RenameTable(
                name: "KhachHang",
                newName: "KhachHangs");

            migrationBuilder.RenameIndex(
                name: "IX_SanPhamChiTiet_MaSanPham",
                table: "SanPhamChiTiets",
                newName: "IX_SanPhamChiTiets_MaSanPham");

            migrationBuilder.RenameIndex(
                name: "IX_SanPham_LoaiSanPhamMaLoai",
                table: "SanPhams",
                newName: "IX_SanPhams_LoaiSanPhamMaLoai");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Vouchers",
                table: "Vouchers",
                column: "MaVoucher");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SanPhamChiTiets",
                table: "SanPhamChiTiets",
                column: "Ma");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SanPhams",
                table: "SanPhams",
                column: "MaSanPham");

            migrationBuilder.AddPrimaryKey(
                name: "PK_NhanViens",
                table: "NhanViens",
                column: "MaNhanVien");

            migrationBuilder.AddPrimaryKey(
                name: "PK_KhachHangs",
                table: "KhachHangs",
                column: "MaKhachHang");

            migrationBuilder.AddForeignKey(
                name: "FK_HoaDon_KhachHangs_MaKhachHang",
                table: "HoaDon",
                column: "MaKhachHang",
                principalTable: "KhachHangs",
                principalColumn: "MaKhachHang");

            migrationBuilder.AddForeignKey(
                name: "FK_HoaDon_NhanViens_MaNhanVien",
                table: "HoaDon",
                column: "MaNhanVien",
                principalTable: "NhanViens",
                principalColumn: "MaNhanVien",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HoaDon_Vouchers_MaVoucher",
                table: "HoaDon",
                column: "MaVoucher",
                principalTable: "Vouchers",
                principalColumn: "MaVoucher");

            migrationBuilder.AddForeignKey(
                name: "FK_HoaDonChiTiet_SanPhams_MaSanPham",
                table: "HoaDonChiTiet",
                column: "MaSanPham",
                principalTable: "SanPhams",
                principalColumn: "MaSanPham",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SanPhamChiTiet_ThuocTinh_SanPhamChiTiets_MaSanPhamChiTiet",
                table: "SanPhamChiTiet_ThuocTinh",
                column: "MaSanPhamChiTiet",
                principalTable: "SanPhamChiTiets",
                principalColumn: "Ma",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SanPhamChiTiets_SanPhams_MaSanPham",
                table: "SanPhamChiTiets",
                column: "MaSanPham",
                principalTable: "SanPhams",
                principalColumn: "MaSanPham",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SanPhams_LoaiSanPham_LoaiSanPhamMaLoai",
                table: "SanPhams",
                column: "LoaiSanPhamMaLoai",
                principalTable: "LoaiSanPham",
                principalColumn: "MaLoai",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
