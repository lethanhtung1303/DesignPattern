using quanlyxekhach.AbstractModel;
using quanlyxekhach.Models;
using System;
using System.Data;

namespace quanlyxekhach.DAO
{
    public class EmployeeDAO
    {
        private AbstractDbFactory _factory;

        public EmployeeDAO(AbstractDbFactory factory)
        {
            _factory = factory;
        }

        public DataTable GetAll()
        {
            var con = _factory.CreateConnection();
            con.Open();

            var query = "SELECT * FROM NhanVien";
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

            var query = "SELECT * FROM NhanVien WHERE (MaNV LIKE N'%" + txtFind + "%' OR TenNV LIKE N'%" + txtFind + "%' OR ChucVu LIKE N'%" + txtFind + "%' OR SDT LIKE N'%" + txtFind + "%')";
            var cmd = _factory.CreateCommand(query, con);
            var adapter = _factory.CreateDataAdapter(cmd);

            var tb = new DataTable();
            adapter.Fill(tb);

            con.Close();
            return tb;
        }

        public bool Insert(Employee employee)
        {
            try
            {
                var con = _factory.CreateConnection();
                con.Open();

                var query = "INSERT INTO NhanVien  VALUES " +
                    "(@MaNV, @TenNV, @ChucVu, @GioiTinh, @SDT, @NgaySinh, @NgayVaoLam)";

                var cmd = _factory.CreateCommand(query, con);

                var MaNV = _factory.SqlParameter("@MaNV", SqlDbType.Char);
                var TenNV = _factory.SqlParameter("@TenNV", SqlDbType.NVarChar);
                var ChucVu = _factory.SqlParameter("@ChucVu", SqlDbType.NVarChar);
                var GioiTinh = _factory.SqlParameter("@GioiTinh", SqlDbType.Bit);
                var SDT = _factory.SqlParameter("@SDT", SqlDbType.Char);
                var NgaySinh = _factory.SqlParameter("@NgaySinh", SqlDbType.DateTime);
                var NgayVaoLam = _factory.SqlParameter("@NgayVaoLam", SqlDbType.DateTime);

                MaNV.Value = employee.MaNV;
                TenNV.Value = employee.TenNV;
                ChucVu.Value = employee.ChucVu;
                GioiTinh.Value = employee.GioiTinh;
                SDT.Value = employee.SDT;
                NgaySinh.Value = employee.NgaySinh;
                NgayVaoLam.Value = employee.NgayVaoLam;

                cmd.Parameters.Add(MaNV);
                cmd.Parameters.Add(TenNV);
                cmd.Parameters.Add(ChucVu);
                cmd.Parameters.Add(GioiTinh);
                cmd.Parameters.Add(SDT);
                cmd.Parameters.Add(NgaySinh);
                cmd.Parameters.Add(NgayVaoLam);

                var ok = cmd.ExecuteNonQuery() > 0;
                con.Close();
                return ok;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Update(Employee employee)
        {
            try
            {
                var con = _factory.CreateConnection();
                con.Open();

                var query = "UPDATE NhanVien" +
                    " SET" +
                    " TenNV = @TenNV," +
                    " ChucVu = @ChucVu," +
                    " GioiTinh = @GioiTinh," +
                    " SDT = @SDT," +
                    " NgaySinh = @NgaySinh," +
                    " NgayVaoLam = @NgayVaoLam" +
                    " WHERE MaNV = @MaNV";

                var cmd = _factory.CreateCommand(query, con);

                var MaNV = _factory.SqlParameter("@MaNV", SqlDbType.Char);
                var TenNV = _factory.SqlParameter("@TenNV", SqlDbType.NVarChar);
                var ChucVu = _factory.SqlParameter("@ChucVu", SqlDbType.NVarChar);
                var GioiTinh = _factory.SqlParameter("@GioiTinh", SqlDbType.Bit);
                var SDT = _factory.SqlParameter("@SDT", SqlDbType.Char);
                var NgaySinh = _factory.SqlParameter("@NgaySinh", SqlDbType.DateTime);
                var NgayVaoLam = _factory.SqlParameter("@NgayVaoLam", SqlDbType.DateTime);

                MaNV.Value = employee.MaNV;
                TenNV.Value = employee.TenNV;
                ChucVu.Value = employee.ChucVu;
                GioiTinh.Value = employee.GioiTinh;
                SDT.Value = employee.SDT;
                NgaySinh.Value = employee.NgaySinh;
                NgayVaoLam.Value = employee.NgayVaoLam;

                cmd.Parameters.Add(MaNV);
                cmd.Parameters.Add(TenNV);
                cmd.Parameters.Add(ChucVu);
                cmd.Parameters.Add(GioiTinh);
                cmd.Parameters.Add(SDT);
                cmd.Parameters.Add(NgaySinh);
                cmd.Parameters.Add(NgayVaoLam);

                var ok = cmd.ExecuteNonQuery() > 0;
                con.Close();
                return ok;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Delete(Employee employee)
        {
            try
            {
                var con = _factory.CreateConnection();
                con.Open();

                var query = "DELETE NhanVien WHERE MaNV = @MaNV";

                var cmd = _factory.CreateCommand(query, con);

                var MaNV = _factory.SqlParameter("@MaNV", SqlDbType.Char);

                MaNV.Value = employee.MaNV;

                cmd.Parameters.Add(MaNV);

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