using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SD20309.Models
{
   
    public class SanPham
    {
        [Key]
        public string MaSanPham { get; set; }

        public string TenSanPham { get; set; }

        public string? MoTa { get; set; }

        public uint SoLuong { get; set; }

        [ForeignKey(nameof(LoaiSanPham))]
        public long MaLoaiSanPham { get; set; }

        public LoaiSanPham LoaiSanPham { get; set; }

        public List<SanPhamChiTiet> SanPhamChiTiets { get; set; } = new List<SanPhamChiTiet>();
    }
}
