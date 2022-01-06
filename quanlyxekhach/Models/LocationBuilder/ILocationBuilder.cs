namespace quanlyxekhach.Models.LocationBuilder
{
    internal interface ILocationBuilder
    {
        LocationBuilder AddMaDD(string madd);

        LocationBuilder AddTenDD(string tendd);

        LocationBuilder AddGiaTien(int giatien);

        Location Builder();
    }
}