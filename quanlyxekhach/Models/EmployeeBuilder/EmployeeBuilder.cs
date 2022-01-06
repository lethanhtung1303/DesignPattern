namespace quanlyxekhach.Models.EmployeeBuilder
{
    public class EmployeeBuilder : IEmployeeBuilder
    {
        public int STT { get; set; }
        public string MaNV { get; set; }
        public string TenNV { get; set; }
        public string ChucVu { get; set; }
        public bool GioiTinh { get; set; }
        public string SDT { get; set; }
        public string NgaySinh { get; set; }
        public string NgayVaoLam { get; set; }

        public EmployeeBuilder AddSTT(int STT)
        {
            this.STT = STT;
            return this;
        }

        public EmployeeBuilder AddMaNV(string MaNV)
        {
            this.MaNV = MaNV;
            return this;
        }

        public EmployeeBuilder AddTenNV(string TenNV)
        {
            this.TenNV = TenNV;
            return this;
        }

        public EmployeeBuilder AddChucVu(string ChucVu)
        {
            this.ChucVu = ChucVu;
            return this;
        }

        public EmployeeBuilder AddGioiTinh(bool GioiTinh)
        {
            this.GioiTinh = GioiTinh;
            return this;
        }

        public EmployeeBuilder AddSDT(string SDT)
        {
            this.SDT = SDT;
            return this;
        }

        public EmployeeBuilder AddNgaySinh(string NgaySinh)
        {
            this.NgaySinh = NgaySinh;
            return this;
        }

        public EmployeeBuilder AddNgayVaoLam(string NgayVaoLam)
        {
            this.NgayVaoLam = NgayVaoLam;
            return this;
        }

        public Employee Builder()
        {
            return new Employee(STT, MaNV, TenNV, ChucVu, GioiTinh, SDT, NgaySinh, NgayVaoLam);
        }
    }
}