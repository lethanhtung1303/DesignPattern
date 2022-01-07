using quanlyxekhach.Models.EmployeeBuilder;
using System.Data;

namespace quanlyxekhach.IDAO
{
    public interface IEmployeeDAO
    {
        DataTable GetAll();

        DataTable Find(string txtFind);

        bool Insert(Employee employee);

        bool Update(Employee employee);

        bool Delete(Employee employee);

        int MaxStt();
    }
}