namespace quanlyxekhach.Models.VehicleBuilder
{
    public class Vehicle
    {
        public int stt { get; set; }
        public string MaXe { get; set; }
        public string MaTaiXe { get; set; }
        public string MaHDV { get; set; }

        public Vehicle(int stt,
            string MaXe,
            string MaTaiXe,
            string MaHDV)
        {
            this.stt = stt;
            this.MaXe = MaXe;
            this.MaTaiXe = MaTaiXe;
            this.MaHDV = MaHDV;
        }
    }
}