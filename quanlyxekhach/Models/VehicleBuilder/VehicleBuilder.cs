namespace quanlyxekhach.Models.VehicleBuilder
{
    public class VehicleBuilder : IVehicleBuilder
    {
        public int stt { get; set; }
        public string MaXe { get; set; }
        public string MaTaiXe { get; set; }
        public string MaHDV { get; set; }

        public VehicleBuilder AddMaHDV(string MaHDV)
        {
            this.MaHDV = MaHDV;
            return this;
        }

        public VehicleBuilder AddMaTaiXe(string MaTaiXe)
        {
            this.MaTaiXe = MaTaiXe;
            return this;
        }

        public VehicleBuilder AddMaXe(string MaXe)
        {
            this.MaXe = MaXe;
            return this;
        }

        public VehicleBuilder Addstt(int stt)
        {
            this.stt = stt;
            return this;
        }

        public Vehicle Builder()
        {
            return new Vehicle(stt, MaXe, MaTaiXe, MaHDV);
        }
    }
}