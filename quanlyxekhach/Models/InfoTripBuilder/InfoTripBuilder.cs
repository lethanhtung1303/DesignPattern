using System;

namespace quanlyxekhach.Models.InfoTripBuilder
{
    public class InfoTripBuilder : IInfoTripBuilder
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

        public InfoTripBuilder AddmaChuyen(string maChuyen)
        {
            this.maChuyen = maChuyen;
            return this;
        }

        public InfoTripBuilder AddmaCX(string maCX)
        {
            this.maCX = maCX;
            return this;
        }

        public InfoTripBuilder AddmaHuongDanVien(string maHuongDanVien)
        {
            this.maHuongDanVien = maHuongDanVien;
            return this;
        }

        public InfoTripBuilder AddmaTaiXe(string maTaiXe)
        {
            this.maTaiXe = maTaiXe;
            return this;
        }

        public InfoTripBuilder AddngayBatDau(DateTime ngayBatDau)
        {
            this.ngayBatDau = ngayBatDau;
            return this;
        }

        public InfoTripBuilder AddngayKetThuc(DateTime ngayKetThuc)
        {
            this.ngayKetThuc = ngayKetThuc;
            return this;
        }

        public InfoTripBuilder AddtenDD(string tenDD)
        {
            this.tenDD = tenDD;
            return this;
        }

        public InfoTripBuilder AddtenHuongDanVien(string tenHuongDanVien)
        {
            this.tenHuongDanVien = tenHuongDanVien;
            return this;
        }

        public InfoTripBuilder AddtenTaiXe(string tenTaiXe)
        {
            this.tenTaiXe = tenTaiXe;
            return this;
        }

        public InfoTrip Builder()
        {
            return new InfoTrip(maChuyen, maTaiXe, tenTaiXe, maHuongDanVien, tenHuongDanVien, maCX, tenDD, ngayBatDau, ngayKetThuc);
        }
    }
}