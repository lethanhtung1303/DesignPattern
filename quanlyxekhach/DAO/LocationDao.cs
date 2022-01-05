using quanlyxekhach.AbstractModel;
using quanlyxekhach.IDAO;
using quanlyxekhach.Models;
using System.Collections.Generic;
using System.Data;

namespace quanlyxekhach.DAO
{
    public class LocationDao : ILocationDao
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