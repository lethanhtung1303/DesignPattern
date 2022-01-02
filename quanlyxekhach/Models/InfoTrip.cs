using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanlyxekhach.Models
{
    class InfoTrip
    {
        public string maChuyen { get; set; }
        public string maTaiXe { get; set; }
        public string tenTaiXe { get; set; }
        public string maHuongDanVien { get; set; }
        public string tenHuongDanVien { get; set; }
        public string maCX { get; set; }
        public string tenDD { get; set; }
        public DateTime ngayBatDau { get; set; }
        public DateTime ngayKetThuc { get; set; }
    }
}
