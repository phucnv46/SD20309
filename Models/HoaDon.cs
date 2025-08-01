using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SD20309.Models
{
    public class HoaDon
    {
        [Key]
        public string MaHoaDon { get; set; }

        public DateTime ThoiGianTao { get; set; }

        public decimal TongHoaDon { get; set; } = 0;

        public decimal TongTienGiam { get; set; } =0;
        public decimal ThanhTien { get; set; } = 0;

        public List<HoaDonChiTiet> HoaDonChiTiets { get; set; } = new();

        public Voucher? Voucher { get; set; }

        public NhanVien NguoiTaoHoaDon { get; set; }

        public KhachHang? KhachHang { get; set; }

        [ForeignKey(nameof(NguoiTaoHoaDon))]
        public long MaNhanVien { get; set; }

        [ForeignKey(nameof(KhachHang))]

        public long? MaKhachHang { get; set; }

        [ForeignKey(nameof(Voucher))]

        public string? MaVoucher { get; set; }

    }
}
