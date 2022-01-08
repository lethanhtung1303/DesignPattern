namespace quanlyxekhach.Models.TicketBuilder
{
    public interface ITicketBuilder
    {
        TicketBuilder AddSTT(int Stt);

        TicketBuilder AddMaPhieu(string maphieu);

        TicketBuilder AdddMaKh(string makh);

        TicketBuilder AddTenKH(string tenkh);

        TicketBuilder AddMaNVBV(string manvbv);

        TicketBuilder AddTenNVBV(string tennvbv);

        TicketBuilder AddSoTien(int sotien);

        TicketBuilder AddChoNgoi(string chongoi);

        TicketBuilder AddMaChuyenXe(string machuyenxe);

        TicketBuilder AddNgayKhoihanh(string ngaykhoihanh);

        TicketBuilder AddTenDD(string tendd);

        Ticket Builder();
    }
}