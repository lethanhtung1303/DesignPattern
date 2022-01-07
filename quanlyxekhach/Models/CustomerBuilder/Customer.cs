namespace quanlyxekhach.Models.CustomerBuilder
{
    public class Customer
    {
        public int stt { get; set; }
        public string maKH { get; set; }
        public string tenKH { get; set; }
        public string sdt { get; set; }
        public bool gioiTinh { get; set; }

        public Customer(int stt, string maKH, string tenKH, string sdt, bool gioiTinh)
        {
            this.stt = stt;
            this.maKH = maKH;
            this.tenKH = tenKH;
            this.sdt = sdt;
            this.gioiTinh = gioiTinh;
        }
    }
}