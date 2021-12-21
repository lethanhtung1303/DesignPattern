using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanlyxekhach.Models
{
	public class Ticket
	{
		public int stt { get; set; }
		public string MaPhieu { get; set; }
		public string MaKH { get; set; }
		public string TenKH { get; set; }

		public string MaNVBV { get; set; }
		public string TenNVBV { get; set; }

		public int SoTien { get; set; }
		public string ChoNgoi { get; set; }
		public string MaChuyenxe { get; set; }
		public string NgayKhoiHanh { get; set; }
		public string TenDD { get; set; }
	}
}
