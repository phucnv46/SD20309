using System.ComponentModel.DataAnnotations;

namespace SD20309.Models
{
    public class Voucher
    {
        [Key]
        public string MaVoucher { get; set; }

        public string TenVouCher { get; set; }

        public LoaiGiam LoaiGiam { get; set; }
        public decimal GiaTriGiam { get; set; }

        public DateOnly HanSuDung { get; set; }

        public decimal? GiaTriApDung { get; set; } = 0;

        public decimal? GiaTriGiamToiDa { get; set; } = 0;

        public bool TrangThai { get; set; } = false;

    }

    public enum LoaiGiam
    {
        GiamPhanTram = 0, GiamTienCoDinh = 1
    }
}