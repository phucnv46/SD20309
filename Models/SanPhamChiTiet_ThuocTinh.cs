using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SD20309.Models
{
    [PrimaryKey(nameof(MaSanPhamChiTiet), nameof(MaThuocTinh))]
    public class SanPhamChiTiet_ThuocTinh
    {
        [ForeignKey(nameof(SanPhamChiTiet))]
        public string MaSanPhamChiTiet { get; set; }

        [ForeignKey(nameof(ThuocTinh))]
        public long MaThuocTinh { get; set; }

        public string GiaTri { get; set; }

        public string? KieuDuLieu { get; set; }

        public SanPhamChiTiet SanPhamChiTiet { get; set; }

        public ThuocTinh ThuocTinh { get; set; }

        public List<SanPhamChiTiet_ThuocTinh> SanPhamChiTiet_ThuocTinhs { get; set; } = new();
    }
}
