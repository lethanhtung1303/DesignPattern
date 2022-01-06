namespace quanlyxekhach.Models.EmployeeBuilder
{
    public class Employee
    {
        public int STT { get; set; }
        public string MaNV { get; set; }
        public string TenNV { get; set; }
        public string ChucVu { get; set; }
        public bool GioiTinh { get; set; }
        public string SDT { get; set; }
        public string NgaySinh { get; set; }
        public string NgayVaoLam { get; set; }

        public Employee(int STT,
            string MaNV,
            string TenNV,
            string ChucVu,
            bool GioiTinh,
            string SDT,
            string NgaySinh,
            string NgayVaoLam)
        {
            this.STT = STT;
            this.MaNV = MaNV;
            this.TenNV = TenNV;
            this.ChucVu = ChucVu;
            this.GioiTinh = GioiTinh;
            this.SDT = SDT;
            this.NgaySinh = NgaySinh;
            this.NgayVaoLam = NgayVaoLam;
        }
    }
}