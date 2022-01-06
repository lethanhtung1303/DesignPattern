namespace quanlyxekhach.Models.TicketBuilder
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

        public Ticket(int Stt, string maphieu, string makh, string tenkh, string manvbv, string tennvbv, int sotien, string chongoi, string machuyenxe, string ngaykhoihanh, string tendiadiem)
        {
            stt = Stt;
            MaPhieu = maphieu;
            MaKH = makh;
            TenKH = tenkh;
            MaNVBV = manvbv;
            TenNVBV = tennvbv;
            SoTien = sotien;
            ChoNgoi = chongoi;
            MaChuyenxe = machuyenxe;
            NgayKhoiHanh = ngaykhoihanh;
            TenDD = tendiadiem;
        }
    }
}