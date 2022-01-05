using System.Data;

namespace quanlyxekhach.IDAO
{
    public interface ILocationDao
    {
        DataTable GetAll();

        DataTable GetAllTemp();
    }
}