using System;

namespace quanlyxekhach.Models.InfoTripBuilder
{
    public class InfoTrip
    {
        public string maChuyen { get; set; }
        public string maTaiXe { get; set; }
        public string tenTaiXe { get; set; }
        public string maHuongDanVien { get; set; }
        public string tenHuongDanVien { get; set; }
        public string maCX { get; set; }
        public string tenDD { get; set; }
        public DateTime ngayBatDau { get; set; }
        public DateTime ngayKetThuc { get; set; }

        public InfoTrip(string maChuyen,
            string maTaiXe,
            string tenTaiXe,
            string maHuongDanVien,
            string tenHuongDanVien,
            string maCX,
            string tenDD,
            DateTime ngayBatDau,
            DateTime ngayKetThuc)
        {
            this.maChuyen = maChuyen;
            this.maTaiXe = maTaiXe;
            this.tenTaiXe = tenTaiXe;
            this.maHuongDanVien = maHuongDanVien;
            this.tenHuongDanVien = tenHuongDanVien;
            this.maCX = maCX;
            this.tenDD = tenDD;
            this.ngayBatDau = ngayBatDau;
            this.ngayKetThuc = ngayKetThuc;
        }
    }
}