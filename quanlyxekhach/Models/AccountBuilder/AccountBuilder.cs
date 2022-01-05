using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanlyxekhach.Models.AccountBuilder
{
    class AccountBuilder:IAccountBuilder
    {
        public int stt { get; set; }
        public string MaNV { get; set; }
        public string TenNv { get; set; }
        public string ChucVu { get; set; }
        public string TenTK { get; set; }
        public string MatKhau { get; set; }

        public AccountBuilder AddChucVu(string chucvu)
        {
            ChucVu = chucvu;
            return this;
        }

        public AccountBuilder AddMaNV(string manv)
        {
            MaNV = manv;
            return this;
        }

        public AccountBuilder AddMatKhau(string matkhau)
        {
            MatKhau = matkhau;
            return this;
        }

        public AccountBuilder AddStt(int Stt)
        {
            stt = Stt;
            return this;
        }

        public AccountBuilder AddTenNV(string tennv)
        {
            TenNv = tennv;
            return this;
        }

        public AccountBuilder AddTenTK(string tentk)
        {
            TenTK = tentk;
            return this;
        }

        public Account Builder()
        {
            return new Account(stt, MaNV, TenNv, ChucVu, TenTK, MatKhau);
        }
    }
}
