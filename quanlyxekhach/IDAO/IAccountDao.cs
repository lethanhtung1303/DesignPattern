using quanlyxekhach.Models;
using System.Data;

namespace quanlyxekhach.IDAO
{
    public interface IAccountDao
    {
        bool Login(string username, string password);

        DataTable GetAll();

        bool Insert(Account account);

        bool Update(Account account);

        bool Delete(string taiKhoan);

        Account GetAccount(string tenTaiKhoan);
    }
}