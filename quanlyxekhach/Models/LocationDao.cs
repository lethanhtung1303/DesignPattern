using quanlyxekhach.AbstractModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanlyxekhach.Models
{
    class LocationDao
    {
        private AbstractDbFactory factory;

        public LocationDao(AbstractDbFactory factory)
        {
            this.factory = factory;
        }
        public DataTable GetAll()
        {
            var con = factory.CreateConnection();
            con.Open();
            var cmd = factory.CreateCommand("select * from DiaDiem", con);
            var adapter = factory.CreateDataAdapter(cmd);
            var tb = new DataTable();
            var ListLocation = new List<Location>();
            adapter.Fill(tb);
     
            con.Close();
            return tb;
        }

        public DataTable GetAllTemp()
        {
            var con = factory.CreateConnection();
            con.Open();
            var cmd = factory.CreateCommand("select * from XeKhach", con);
            var adapter = factory.CreateDataAdapter(cmd);
            var tb = new DataTable();
            var ListCar = new List<Vehicle>();
            adapter.Fill(tb);

            con.Close();
            return tb;
        }
    }
}
