using System.ComponentModel.DataAnnotations;

namespace SD20309.Models
{
    public class LoaiSanPham
    {
        [Key]
        public long MaLoai { get; set; }


        public string TenLoai { get; set; } = "Chưa rõ";


        public string? MoTa { get; set; }
    }
}