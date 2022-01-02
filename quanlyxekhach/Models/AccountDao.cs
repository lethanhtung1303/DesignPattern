using quanlyxekhach.AbstractModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanlyxekhach.Models
{
    public class AccountDao
    {
        private AbstractDbFactory factory;

        public AccountDao(AbstractDbFactory factory)
        {
            this.factory = factory;
        }

        public bool Login(string username, string password)
        {
            var con = factory.CreateConnection();
            con.Open();
            var cmd = factory.CreateCommand("select * from TaiKhoan where TenTK =@TenTK and MatKhau =@MatKhau", con);
            var TenTK = factory.SqlParameter("@TenTK", SqlDbType.NVarChar);
            var MatKhau = factory.SqlParameter("@MatKhau", SqlDbType.NVarChar);
            TenTK.Value = username;
            MatKhau.Value = password;
            cmd.Parameters.Add(TenTK);
            cmd.Parameters.Add(MatKhau);
            var adapter = factory.CreateDataAdapter(cmd);
            var tb = new DataTable();
            adapter.Fill(tb);
            if (tb.Rows.Count == 1)
            {
                return true;
            }
            else { return false; }
        }

        public DataTable GetAll()
        {
            var con = factory.CreateConnection();
            con.Open();
            var cmd = factory.CreateCommand("select * from TaiKhoan", con);
            var adapter = factory.CreateDataAdapter(cmd);
            var tb = new DataTable();
            var ListAcc = new List<Account>();
            adapter.Fill(tb);
            //foreach (DataRow dataRow in tb.Rows)
            //{
            //    var acc = new Account
            //    {
            //        stt = Convert.ToInt32(dataRow["stt"]),
            //        MaNV = dataRow["MaNV"].ToString(),
            //        TenNv = dataRow["TenNV"].ToString(),
            //        ChucVu = dataRow["ChucVu"].ToString(),
            //        TenTK = dataRow["TenTK"].ToString(),
            //        MatKhau = dataRow["MatKhau"].ToString()
            //    };
            //    ListAcc.Add(acc);
            //}
            con.Close();
            return tb;
        }

        public bool Add(Account account)
        {
            var con = factory.CreateConnection();
            con.Open();
            var cmd = factory.CreateCommand("insert into TaiKhoan values (@MaNV, @TenNV,@ChucVu,@TenTK, @MatKhau)", con);
            var ManV = factory.SqlParameter("@MaNV", SqlDbType.NVarChar);
            var TenNV = factory.SqlParameter("@TenNV", SqlDbType.NVarChar);
            var ChucVu = factory.SqlParameter("@ChucVu", SqlDbType.NVarChar);
            var TenTK = factory.SqlParameter("@TenTK", SqlDbType.NVarChar);
            var MatKhau = factory.SqlParameter("@MatKhau", SqlDbType.NVarChar);

            ManV.Value = account.MaNV;
            TenNV.Value = account.TenNv;
            ChucVu.Value = account.ChucVu;
            TenTK.Value = account.TenTK;
            MatKhau.Value = account.MatKhau;
            cmd.Parameters.Add(ManV);
            cmd.Parameters.Add(TenNV);
            cmd.Parameters.Add(ChucVu);
            cmd.Parameters.Add(TenTK);
            cmd.Parameters.Add(MatKhau);
            var ok = cmd.ExecuteNonQuery() > 0;
            con.Close();
            return ok;
        }

        public bool Update(Account account)
        {
            var con = factory.CreateConnection();
            con.Open();
            var cmd = factory.CreateCommand("update TaiKhoan set TenNV = @TenNV, ChucVu = @ChucVu,MatKhau = @MatKhau where TenTK = @TenTK", con);
            var TenNV = factory.SqlParameter("@TenNV", SqlDbType.NVarChar);
            var ChucVu = factory.SqlParameter("@ChucVu", SqlDbType.NVarChar);
            var TenTK = factory.SqlParameter("@TenTK", SqlDbType.NVarChar);
            var MatKhau = factory.SqlParameter("@MatKhau", SqlDbType.NVarChar);

            TenNV.Value = account.TenNv;
            ChucVu.Value = account.ChucVu;
            TenTK.Value = account.TenTK;
            MatKhau.Value = account.MatKhau;

            cmd.Parameters.Add(TenNV);
            cmd.Parameters.Add(ChucVu);
            cmd.Parameters.Add(TenTK);
            cmd.Parameters.Add(MatKhau);

            var ok = cmd.ExecuteNonQuery() > 0;
            con.Close();
            return ok;
        }

        public bool Delete(string taiKhoan)
        {
            var con = factory.CreateConnection();
            con.Open();
            var cmd = factory.CreateCommand("Delete from TaiKhoan where TenTK = @TenTK", con);
            var tenTK = factory.SqlParameter("@TenTK", SqlDbType.Char);
            tenTK.Value = taiKhoan;
            cmd.Parameters.Add(tenTK);
            var ok = cmd.ExecuteNonQuery() > 0;
            con.Close();
            return ok;
        }

        public Account GetAccount(string tenTaiKhoan)
        {
            var con = factory.CreateConnection();
            con.Open();
            var cmd = factory.CreateCommand("Select * from TaiKhoan where TenTK = @TenTK", con);
            var tenTK = factory.SqlParameter("@TenTK", SqlDbType.Char);
            tenTK.Value = tenTaiKhoan;
            cmd.Parameters.Add(tenTK);
            var adapter = factory.CreateDataAdapter(cmd);
            var tb = new DataTable();
            adapter.Fill(tb);
            var account = new Account();
            foreach (DataRow dataRow in tb.Rows)
            {
                account.stt = Convert.ToInt32(dataRow["stt"]);
                account.MaNV = dataRow["MaNV"].ToString();
                account.TenNv = dataRow["TenNV"].ToString();
                account.ChucVu = dataRow["ChucVu"].ToString();
                account.TenTK = dataRow["TenTK"].ToString();
                account.MatKhau = dataRow["MatKhau"].ToString();
             }
            return account;
        }
    }
}