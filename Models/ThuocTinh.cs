using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SD20309.Models
{
    public class ThuocTinh
    {
        [Key]
        public long Ma { get; set; }

        public string TenThuocTinh { get; set; }

        
    }
}
