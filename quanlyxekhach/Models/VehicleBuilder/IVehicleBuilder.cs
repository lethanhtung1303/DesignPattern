namespace quanlyxekhach.Models.VehicleBuilder
{
    public interface IVehicleBuilder
    {
        VehicleBuilder Addstt(int stt);

        VehicleBuilder AddMaXe(string MaXe);

        VehicleBuilder AddMaTaiXe(string MaTaiXe);

        VehicleBuilder AddMaHDV(string MaHDV);

        Vehicle Builder();
    }
}