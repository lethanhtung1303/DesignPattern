using quanlyxekhach.AbstractModel;
using quanlyxekhach.Models;
using System;
using System.Collections.Generic;
using System.Data;

namespace quanlyxekhach.DAO
{
    internal class InfoTripDAO
    {
        private AbstractDbFactory _factory;

        public InfoTripDAO(AbstractDbFactory factory)
        {
            _factory = factory;
        }

        public DataTable GetAll()
        {
            var con = _factory.CreateConnection();
            con.Open();

            var query = "SELECT * FROM ThongTinChuyenDi";
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

            var query = "SELECT * FROM ThongTinChuyenDi WHERE (MaChuyen LIKE N'%" + txtFind + "%' OR MaTX LIKE N'%" + txtFind + "%' OR TenTX LIKE N'%" + txtFind + "%' OR MaHDV LIKE N'%" + txtFind + "%' OR TenHDV LIKE N'%" + txtFind + "%' OR MaCX LIKE N'%" + txtFind + "%' OR TenDD LIKE N'%" + txtFind + "%' OR NgayBatDau LIKE N'%" + txtFind + "%' OR NgayKetThuc LIKE N'%" + txtFind + "%')";
            var cmd = _factory.CreateCommand(query, con);
            var adapter = _factory.CreateDataAdapter(cmd);

            var tb = new DataTable();
            adapter.Fill(tb);

            con.Close();
            return tb;
        }

        public bool Insert(InfoTrip infoTrip)
        {
            try
            {
                var con = _factory.CreateConnection();
                con.Open();

                var query = "INSERT INTO ThongTinChuyenDi VALUES " +
                    "(@MaChuyen, @MaTX, @TenTX, @MaHDV, @TenHDV, @MaCX, @TenDD, @NgayBatDau, @NgayKetThuc)";

                var cmd = _factory.CreateCommand(query, con);

                var MaChuyen = _factory.SqlParameter("@MaChuyen", SqlDbType.Char);
                var MaTX = _factory.SqlParameter("@MaTX", SqlDbType.Char);
                var TenTX = _factory.SqlParameter("@TenTX", SqlDbType.NVarChar);
                var MaHDV = _factory.SqlParameter("@MaHDV", SqlDbType.Char);
                var TenHDV = _factory.SqlParameter("@TenHDV", SqlDbType.NVarChar);
                var MaCX = _factory.SqlParameter("@MaCX", SqlDbType.Char);
                var TenDD = _factory.SqlParameter("@TenDD", SqlDbType.NVarChar);
                var NgayBatDau = _factory.SqlParameter("@NgayBatDau", SqlDbType.DateTime);
                var NgayKetThuc = _factory.SqlParameter("@NgayKetThuc", SqlDbType.DateTime);

                MaChuyen.Value = infoTrip.maChuyen;
                MaTX.Value = infoTrip.maTaiXe;
                TenTX.Value = infoTrip.tenTaiXe;
                MaHDV.Value = infoTrip.maHuongDanVien;
                TenHDV.Value = infoTrip.tenHuongDanVien;
                MaCX.Value = infoTrip.maCX;
                TenDD.Value = infoTrip.tenDD;
                NgayBatDau.Value = infoTrip.ngayBatDau;
                NgayKetThuc.Value = infoTrip.ngayKetThuc;

                cmd.Parameters.Add(MaChuyen);
                cmd.Parameters.Add(MaTX);
                cmd.Parameters.Add(TenTX);
                cmd.Parameters.Add(MaHDV);
                cmd.Parameters.Add(TenHDV);
                cmd.Parameters.Add(MaCX);
                cmd.Parameters.Add(TenDD);
                cmd.Parameters.Add(NgayBatDau);
                cmd.Parameters.Add(NgayKetThuc);

                var ok = cmd.ExecuteNonQuery() > 0;
                con.Close();
                return ok;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Update(InfoTrip infoTrip)
        {
            try
            {
                var con = _factory.CreateConnection();
                con.Open();

                var query = "UPDATE ThongTinChuyenDi SET MaTX = @MaTX, TenTX = @TenTX, MaHDV = @MaHDV, TenHDV = @TenHDV, MaCX = @MaCX, TenDD = @TenDD, NgayBatDau = @NgayBatDau, NgayKetThuc = @NgayKetThuc WHERE MaChuyen = @MaChuyen";

                var cmd = _factory.CreateCommand(query, con);

                var MaChuyen = _factory.SqlParameter("@MaChuyen", SqlDbType.Char);
                var MaTX = _factory.SqlParameter("@MaTX", SqlDbType.Char);
                var TenTX = _factory.SqlParameter("@TenTX", SqlDbType.NVarChar);
                var MaHDV = _factory.SqlParameter("@MaHDV", SqlDbType.Char);
                var TenHDV = _factory.SqlParameter("@TenHDV", SqlDbType.NVarChar);
                var MaCX = _factory.SqlParameter("@MaCX", SqlDbType.Char);
                var TenDD = _factory.SqlParameter("@TenDD", SqlDbType.NVarChar);
                var NgayBatDau = _factory.SqlParameter("@NgayBatDau", SqlDbType.DateTime);
                var NgayKetThuc = _factory.SqlParameter("@NgayKetThuc", SqlDbType.DateTime);

                MaChuyen.Value = infoTrip.maChuyen;
                MaTX.Value = infoTrip.maTaiXe;
                TenTX.Value = infoTrip.tenTaiXe;
                MaHDV.Value = infoTrip.maHuongDanVien;
                TenHDV.Value = infoTrip.tenHuongDanVien;
                MaCX.Value = infoTrip.maCX;
                TenDD.Value = infoTrip.tenDD;
                NgayBatDau.Value = infoTrip.ngayBatDau;
                NgayKetThuc.Value = infoTrip.ngayKetThuc;

                cmd.Parameters.Add(MaChuyen);
                cmd.Parameters.Add(MaTX);
                cmd.Parameters.Add(TenTX);
                cmd.Parameters.Add(MaHDV);
                cmd.Parameters.Add(TenHDV);
                cmd.Parameters.Add(MaCX);
                cmd.Parameters.Add(TenDD);
                cmd.Parameters.Add(NgayBatDau);
                cmd.Parameters.Add(NgayKetThuc);

                var ok = cmd.ExecuteNonQuery() > 0;
                con.Close();
                return ok;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<Employee> GetAllTaiXe()
        {
            var con = _factory.CreateConnection();
            con.Open();

            var query = "SELECT * FROM NhanVien WHERE ChucVu = 'TX'";
            var cmd = _factory.CreateCommand(query, con);
            var adapter = _factory.CreateDataAdapter(cmd);
            var tb = new DataTable();
            var listTaiXe = new List<Employee>();
            adapter.Fill(tb);
            foreach (DataRow dataRow in tb.Rows)
            {
                Employee taiXe = new Employee
                {
                    STT = Convert.ToInt32(dataRow["stt"]),
                    MaNV = Convert.ToString(dataRow["MaNV"]),
                    TenNV = Convert.ToString(dataRow["TenNV"]),
                    ChucVu = Convert.ToString(dataRow["ChucVu"]),
                    GioiTinh = Convert.ToBoolean(dataRow["GioiTinh"]),
                    SDT = Convert.ToString(dataRow["SDT"]),
                    NgaySinh = Convert.ToString(dataRow["NgaySinh"]),
                    NgayVaoLam = Convert.ToString(dataRow["NgayVaoLam"])
                };
                listTaiXe.Add(taiXe);
            }
            con.Close();
            return listTaiXe;
        }

        public List<Employee> GetAllHDV()
        {
            var con = _factory.CreateConnection();
            con.Open();

            var query = "SELECT * FROM NhanVien WHERE ChucVu = 'HDV'";
            var cmd = _factory.CreateCommand(query, con);
            var adapter = _factory.CreateDataAdapter(cmd);
            var tb = new DataTable();
            var listHDV = new List<Employee>();
            adapter.Fill(tb);
            foreach (DataRow dataRow in tb.Rows)
            {
                Employee hdv = new Employee
                {
                    STT = Convert.ToInt32(dataRow["stt"]),
                    MaNV = Convert.ToString(dataRow["MaNV"]),
                    TenNV = Convert.ToString(dataRow["TenNV"]),
                    ChucVu = Convert.ToString(dataRow["ChucVu"]),
                    GioiTinh = Convert.ToBoolean(dataRow["GioiTinh"]),
                    SDT = Convert.ToString(dataRow["SDT"]),
                    NgaySinh = Convert.ToString(dataRow["NgaySinh"]),
                    NgayVaoLam = Convert.ToString(dataRow["NgayVaoLam"])
                };
                listHDV.Add(hdv);
            }
            con.Close();
            return listHDV;
        }

        public List<Location> GetAllLocation()
        {
            var con = _factory.CreateConnection();
            con.Open();

            var query = "SELECT * FROM DiaDiem";
            var cmd = _factory.CreateCommand(query, con);
            var adapter = _factory.CreateDataAdapter(cmd);
            var tb = new DataTable();
            var listLocation = new List<Location>();
            adapter.Fill(tb);
            foreach (DataRow dataRow in tb.Rows)
            {
                Location location = new Location
                {
                    MaDD = Convert.ToString(dataRow["MaDD"]),
                    TenDD = Convert.ToString(dataRow["TebDD"]),
                    GiaTien = Convert.ToInt32(dataRow["GiaTien"])
                };
                listLocation.Add(location);
            }
            con.Close();
            return listLocation;
        }

        public List<Vehicle> GetAllVehicle()
        {
            var con = _factory.CreateConnection();
            con.Open();

            var query = "SELECT * FROM XeKhach";
            var cmd = _factory.CreateCommand(query, con);
            var adapter = _factory.CreateDataAdapter(cmd);
            var tb = new DataTable();
            var listVehicle = new List<Vehicle>();
            adapter.Fill(tb);
            foreach (DataRow dataRow in tb.Rows)
            {
                Vehicle vehicle = new Vehicle
                {
                    stt = Convert.ToInt32(dataRow["stt"]),
                    MaXe = Convert.ToString(dataRow["MaXe"]),
                    MaTaiXe = Convert.ToString(dataRow["MaTaiXe"]),
                    MaHDV = Convert.ToString(dataRow["MaHDV"])
                };
                listVehicle.Add(vehicle);
            }
            con.Close();
            return listVehicle;
        }
    }
}