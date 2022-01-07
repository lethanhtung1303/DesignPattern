namespace quanlyxekhach.Models.CustomerBuilder
{
    public interface ICustomerBuilder
    {
        CustomerBuilder Addstt(int stt);

        CustomerBuilder AddmaKH(string maKH);

        CustomerBuilder AddtenKH(string tenKH);

        CustomerBuilder Addsdt(string sdt);

        CustomerBuilder AddgioiTinh(bool gioiTinh);

        Customer Builder();
    }
}