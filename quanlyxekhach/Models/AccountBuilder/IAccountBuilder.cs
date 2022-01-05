using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanlyxekhach.Models.AccountBuilder
{
    interface IAccountBuilder
    {
        AccountBuilder AddStt(int stt);
        AccountBuilder AddMaNV(string manv);
        AccountBuilder AddTenNV(string tennv);
        AccountBuilder AddChucVu(string chucvu);
        AccountBuilder AddTenTK(string tentk);
        AccountBuilder AddMatKhau(string matkhau);
        Account Builder();


    }
}
