using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SD20309.Models
{
    public class NhanVien
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Tự tăng
        public long MaNhanVien { get; set; }

        public string TenNhanVien { get; set; }

        public string? SoDienThoai { get; set; }
        public string? DiaChi { get; set; }
        public string? Email { get; set; }

        public List<HoaDon> HoaDons { get; set; } = new List<HoaDon>();

        public bool? GioiTinh { get; set; }

        public VaiTro VaiTro { get; set; }

        public string TaiKhoan { get; set; }


        public string MatKhau { get; set; }

    }


    public enum VaiTro
    {
        NhanVien,QuanLy
    }
}