using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace SD20309.Models
{

    [PrimaryKey(nameof(MaHoaDon),nameof(MaSanPham))]    
    
    public class HoaDonChiTiet
    {

        [ForeignKey(nameof(HoaDon))]
        public string MaHoaDon { get; set; }

        [ForeignKey(nameof(SanPham))]
        public string MaSanPham { get; set; }

        public uint SoLuong { get; set; }

        public HoaDon HoaDon { get; set; }

        public SanPham SanPham { get; set; }

        public decimal DonGia { get; set; }
    }
}