using quanlyxekhach.Models.TicketBuilder;
using System.Data;

namespace quanlyxekhach.IDAO
{
    public interface ITicketDao
    {
        bool Add(Ticket ticket);

        int MaxStt();

        DataTable GetAll();

        DataTable Find(string txtFind);

        bool Delete(Ticket ticket);
    }
}