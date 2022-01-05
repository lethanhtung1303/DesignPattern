using quanlyxekhach.Models;
using System.Data;

namespace quanlyxekhach.IDAO
{
    public interface ICustomerDAO
    {
        DataTable GetAll();

        DataTable Find(string txtFind);

        bool Insert(Customer customer);

        bool Update(Customer customer);

        bool Delete(Customer customer);

        int Maxstt();
    }
}