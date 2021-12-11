using quanlyxekhach.AbstractModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanlyxekhach.Models
{
    class CustomerDAO
    {
        private AbstractDbFactory _factory;

        public CustomerDAO(AbstractDbFactory factory)
        {
            _factory = factory;
        }

        public DataTable GetAll()
        {
            var con = _factory.CreateConnection();
            con.Open();

            var query = "SELECT * FROM KhachHang";
            var cmd = _factory.CreateCommand(query, con);
            var adapter = _factory.CreateDataAdapter(cmd);

            var tb = new DataTable();
            adapter.Fill(tb);

            con.Close();
            return tb;
        }

        public DataTable Find(string txtFind)
        {
            var con = _factory.CreateConnection();
            con.Open();

            var query = "SELECT * FROM KhachHang WHERE (MaKH LIKE N'%" + txtFind + "%' OR TenKH LIKE N'%" + txtFind + "%' OR Sdt LIKE N'%" + txtFind + "%')";
            var cmd = _factory.CreateCommand(query, con);
            var adapter = _factory.CreateDataAdapter(cmd);

            var tb = new DataTable();
            adapter.Fill(tb);

            con.Close();
            return tb;
        }

        public bool Insert(Customer customer)
        {
            try
            {
                var con = _factory.CreateConnection();
                con.Open();

                var query = "INSERT INTO KhachHang  VALUES " +
                    "(@MaKH, @TenKH, @Sdt, @GioiTinh)";

                var cmd = _factory.CreateCommand(query, con);

                var MaKH = _factory.SqlParameter("@MaKH", SqlDbType.Char);
                var TenKH = _factory.SqlParameter("@TenKH", SqlDbType.NVarChar);
                var Sdt = _factory.SqlParameter("@Sdt", SqlDbType.Char);
                var GioiTinh = _factory.SqlParameter("@GioiTinh", SqlDbType.Bit);

                MaKH.Value = customer.maKH;
                TenKH.Value = customer.tenKH;
                Sdt.Value = customer.sdt;
                GioiTinh.Value = customer.gioiTinh;

                cmd.Parameters.Add(MaKH);
                cmd.Parameters.Add(TenKH);
                cmd.Parameters.Add(Sdt);
                cmd.Parameters.Add(GioiTinh);

                var ok = cmd.ExecuteNonQuery() > 0;
                con.Close();
                return ok;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Update(Customer customer)
        {
            try
            {
                var con = _factory.CreateConnection();
                con.Open();

                var query = "UPDATE KhachHang SET TenKH = @TenKH, Sdt = @Sdt, GioiTinh = @GioiTinh WHERE MaKH = @MaKH";

                var cmd = _factory.CreateCommand(query, con);

                var MaKH = _factory.SqlParameter("@MaKH", SqlDbType.Char);
                var TenKH = _factory.SqlParameter("@TenKH", SqlDbType.NVarChar);
                var Sdt = _factory.SqlParameter("@Sdt", SqlDbType.Char);
                var GioiTinh = _factory.SqlParameter("@GioiTinh", SqlDbType.Bit);

                MaKH.Value = customer.maKH;
                TenKH.Value = customer.tenKH;
                Sdt.Value = customer.sdt;
                GioiTinh.Value = customer.gioiTinh;

                cmd.Parameters.Add(MaKH);
                cmd.Parameters.Add(TenKH);
                cmd.Parameters.Add(Sdt);
                cmd.Parameters.Add(GioiTinh);

                var ok = cmd.ExecuteNonQuery() > 0;
                con.Close();
                return ok;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Delete(Customer customer)
        {
            try
            {
                var con = _factory.CreateConnection();
                con.Open();

                var query = "DELETE KhachHang WHERE MaKH = @MaKH";

                var cmd = _factory.CreateCommand(query, con);

                var MaKH = _factory.SqlParameter("@MaKH", SqlDbType.Char);

                MaKH.Value = customer.maKH;

                cmd.Parameters.Add(MaKH);

                var ok = cmd.ExecuteNonQuery() > 0;
                con.Close();
                return ok;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}

