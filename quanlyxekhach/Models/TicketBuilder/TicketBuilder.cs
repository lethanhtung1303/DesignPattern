using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanlyxekhach.Models.TicketBuilder
{
    class TicketBuilder : ITicketBuilder
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
        public TicketBuilder AddChoNgoi(string chongoi)
        {
            ChoNgoi = chongoi;
            return this;
        }

        public TicketBuilder AddMaChuyenXe(string machuyenxe)
        {
            MaChuyenxe = machuyenxe;
            return this;
        }

        public TicketBuilder AddMaNVBV(string manvbv)
        {
            MaNVBV = manvbv;
            return this;
        }

        public TicketBuilder AddMaPhieu(string maphieu)
        {
            MaPhieu = maphieu;
            return this;
        }

        public TicketBuilder AddNgayKhoihanh(string ngaykhoihanh)
        {
            NgayKhoiHanh = ngaykhoihanh;
            return this;
        }

        public TicketBuilder AddSoTien(int sotien)
        {
            SoTien = sotien;
            return this;
        }

        public TicketBuilder AddSTT(int Stt)
        {
            stt = Stt;
            return this;
        }

        public TicketBuilder AddTenDD(string tendd)
        {
            TenDD = tendd;
            return this;
        }

        public TicketBuilder AddTenKH(string tenkh)
        {
            TenKH = tenkh;
            return this;
        }

        public TicketBuilder AddTenNVBV(string tennvbv)
        {
            TenNVBV = tennvbv;
            return this;
        }

        public Ticket Builder()
        {
            return new Ticket(stt, MaPhieu, MaKH, TenKH, MaNVBV, TenNVBV, SoTien, ChoNgoi, MaChuyenxe, NgayKhoiHanh, TenDD);
        }

        public TicketBuilder AdddMaKh(string makh)
        {
            MaKH = makh;
            return this;
        }
    }
}
