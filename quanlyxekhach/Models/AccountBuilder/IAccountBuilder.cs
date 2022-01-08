namespace quanlyxekhach.Models.AccountBuilder
{
    public interface IAccountBuilder
    {
        AccountBuilder AddStt(int stt);

        AccountBuilder AddMaNV(string manv);

        AccountBuilder AddTenNV(string tennv);

        AccountBuilder AddChucVu(string chucvu);

        AccountBuilder AddTenTK(string tentk);

        AccountBuilder AddMatKhau(string matkhau);

        Account Builder();
    }
}