namespace quanlyxekhach.Models
{
    public class Location
    {
        public string MaDD { get; set; }
        public string TenDD { get; set; }
        public int GiaTien { get; set; }
        public Location(string madd, string tendd, int giatien)
        {
            MaDD = madd;
            TenDD = tendd;
            GiaTien = giatien;
        }
    }


}