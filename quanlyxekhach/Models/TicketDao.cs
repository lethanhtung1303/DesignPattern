using quanlyxekhach.AbstractModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanlyxekhach.Models
{
    class TicketDao
    {

        private AbstractDbFactory factory;

        public TicketDao(AbstractDbFactory factory)
        {
            this.factory = factory;
        }

        public bool Add(Ticket ticket)
        {
            var con = factory.CreateConnection();
            con.Open();
            var cmd = factory.CreateCommand("insert into PhieuVe values (@MaPhieu, @MaKH,@TenKH, @MaNVBV,@TenNVBV,@SoTien, @ChoNgoi,  @MaChuyenxe,'" + ticket.NgayKhoiHanh + "', @TenDD)", con);
            var MaPhieu = factory.SqlParameter("@MaPhieu", SqlDbType.Char);
            var MaKH = factory.SqlParameter("@MaKH", SqlDbType.Char);
            var TenKH = factory.SqlParameter("@TenKH", SqlDbType.NVarChar);
            var TenNVBV = factory.SqlParameter("@TenNVBV", SqlDbType.NVarChar);
            var MaNVBV = factory.SqlParameter("@MaNVBV", SqlDbType.Char);
            var SoTien = factory.SqlParameter("@SoTien", SqlDbType.Int);
            var ChoNgoi = factory.SqlParameter("@ChoNgoi", SqlDbType.Char);
            //var NgayKhoiHanh = factory.SqlParameter("@NgayKhoiHanh", SqlDbType.DateTime);
            var MaChuyenxe = factory.SqlParameter("@MaChuyenxe", SqlDbType.Char);
            var TenDD = factory.SqlParameter("@TenDD", SqlDbType.NVarChar);

            Debug.WriteLine(ticket.NgayKhoiHanh);

            MaPhieu.Value = ticket.MaPhieu;
            MaKH.Value = ticket.MaKH;
            TenKH.Value = ticket.TenKH;
            TenNVBV.Value = ticket.TenNVBV;
            MaNVBV.Value = ticket.MaNVBV;
            SoTien.Value = ticket.SoTien;
            ChoNgoi.Value = ticket.ChoNgoi;
           // NgayKhoiHanh.Value = ticket.NgayKhoiHanh;
            MaChuyenxe.Value = ticket.MaChuyenxe;
            TenDD.Value = ticket.TenDD;


            cmd.Parameters.Add(MaPhieu);
            cmd.Parameters.Add(MaKH);
            cmd.Parameters.Add(TenKH);
            cmd.Parameters.Add(TenNVBV);
            cmd.Parameters.Add(MaNVBV);
            cmd.Parameters.Add(SoTien);
            cmd.Parameters.Add(ChoNgoi);
            //cmd.Parameters.Add(NgayKhoiHanh);
            cmd.Parameters.Add(MaChuyenxe);
            cmd.Parameters.Add(TenDD);
            var ok = cmd.ExecuteNonQuery() > 0;
            con.Close();
            return ok;
        }

        public int MaxStt()
        {
            var con = factory.CreateConnection();
            con.Open();

            var query = "SELECT MAX(stt) FROM PhieuVe";
            var cmd = factory.CreateCommand(query, con);
            Int32 count = (Int32)(cmd.ExecuteScalar());

            return count;
        }

    }
}
