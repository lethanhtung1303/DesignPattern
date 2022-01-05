using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanlyxekhach.Models.LocationBuilder
{
    interface ILocationBuilder
    {
        LocationBuilder AddMaDD(string madd);
        LocationBuilder AddTenDD(string tendd);
        LocationBuilder AddGiaTien(int giatien);
        Location Builder();
    }
}
