using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SD20309.Models
{
    public class SanPhamChiTiet
    {
        [Key]
        public string Ma { get; set; }

        [Required]
        public SanPham SanPham { get; set; }

        [Required]
        [ForeignKey("SanPham")]
        public string MaSanPham { get; set; }


        public decimal Gia { get; set; } = 0;

        public List<SanPhamChiTiet_ThuocTinh> SanPhamChiTiet_ThuocTinhs { get; set; } = new();

        public uint SoLuong { get; set; }

        public string? AnhSP { get; set; }

    }
}