namespace quanlyxekhach.Models.AccountBuilder
{
    public class Account
    {
        public int stt { get; set; }
        public string MaNV { get; set; }
        public string TenNv { get; set; }
        public string ChucVu { get; set; }
        public string TenTK { get; set; }
        public string MatKhau { get; set; }

        public Account(int Stt, string manv, string tennv, string chucvu, string tentk, string matkhau)
        {
            stt = Stt;
            MaNV = manv;
            TenNv = tennv;
            ChucVu = chucvu;
            TenTK = tentk;
            MatKhau = matkhau;
        }
    }
}