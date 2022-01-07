using System;

namespace quanlyxekhach.Models.InfoTripBuilder
{
    public interface IInfoTripBuilder
    {
        InfoTripBuilder AddmaChuyen(string maChuyen);

        InfoTripBuilder AddmaTaiXe(string maTaiXe);

        InfoTripBuilder AddtenTaiXe(string tenTaiXe);

        InfoTripBuilder AddmaHuongDanVien(string maHuongDanVien);

        InfoTripBuilder AddtenHuongDanVien(string tenHuongDanVien);

        InfoTripBuilder AddmaCX(string maCX);

        InfoTripBuilder AddtenDD(string tenDD);

        InfoTripBuilder AddngayBatDau(DateTime ngayBatDau);

        InfoTripBuilder AddngayKetThuc(DateTime ngayKetThuc);

        InfoTrip Builder();
    }
}