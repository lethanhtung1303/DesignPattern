namespace quanlyxekhach.Models.CustomerBuilder
{
    public class CustomerBuilder : ICustomerBuilder
    {
        public int stt { get; set; }
        public string maKH { get; set; }
        public string tenKH { get; set; }
        public string sdt { get; set; }
        public bool gioiTinh { get; set; }

        public CustomerBuilder AddgioiTinh(bool gioiTinh)
        {
            this.gioiTinh = gioiTinh;
            return this;
        }

        public CustomerBuilder AddmaKH(string maKH)
        {
            this.maKH = maKH;
            return this;
        }

        public CustomerBuilder Addsdt(string sdt)
        {
            this.sdt = sdt;
            return this;
        }

        public CustomerBuilder Addstt(int stt)
        {
            this.stt = stt;
            return this;
        }

        public CustomerBuilder AddtenKH(string tenKH)
        {
            this.tenKH = tenKH;
            return this;
        }

        public Customer Builder()
        {
            return new Customer(stt, maKH, tenKH, sdt, gioiTinh);
        }
    }
}