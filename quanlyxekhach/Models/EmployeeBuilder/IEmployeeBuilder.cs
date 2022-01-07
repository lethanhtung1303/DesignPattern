namespace quanlyxekhach.Models.EmployeeBuilder
{
    public interface IEmployeeBuilder
    {
        EmployeeBuilder AddSTT(int STT);

        EmployeeBuilder AddMaNV(string MaNV);

        EmployeeBuilder AddTenNV(string TenNV);

        EmployeeBuilder AddChucVu(string ChucVu);

        EmployeeBuilder AddGioiTinh(bool GioiTinh);

        EmployeeBuilder AddSDT(string SDT);

        EmployeeBuilder AddNgaySinh(string NgaySinh);

        EmployeeBuilder AddNgayVaoLam(string NgayVaoLam);

        Employee Builder();
    }
}