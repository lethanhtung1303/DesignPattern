namespace quanlyxekhach.Models.LocationBuilder
{
    public class LocationBuilder : ILocationBuilder
    {
        public string MaDD { get; set; }
        public string TenDD { get; set; }
        public int GiaTien { get; set; }

        public LocationBuilder AddGiaTien(int giatien)
        {
            GiaTien = giatien;
            return this;
        }

        public LocationBuilder AddMaDD(string madd)
        {
            MaDD = madd;
            return this;
        }

        public LocationBuilder AddTenDD(string tendd)
        {
            TenDD = tendd;
            return this;
        }

        public Location Builder()
        {
            return new Location(MaDD, TenDD, GiaTien);
        }
    }
}