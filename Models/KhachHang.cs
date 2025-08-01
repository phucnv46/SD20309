using System.ComponentModel.DataAnnotations;

namespace SD20309.Models
{
    public class KhachHang
    {
        [Key]
        public long MaKhachHang { get; set; }

       
        public string HoTen { get; set; }

        public string SoDienThoai { get; set; }

        public string? Email { get; set; }

        public string? DiaChi { get; set; }
    }
}