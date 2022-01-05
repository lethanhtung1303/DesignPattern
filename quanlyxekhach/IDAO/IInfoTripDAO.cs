using quanlyxekhach.Models;
using System.Collections.Generic;
using System.Data;

namespace quanlyxekhach.IDAO
{
    public interface IInfoTripDAO
    {
        DataTable GetAll();

        DataTable Find(string txtFind);

        bool Insert(InfoTrip infoTrip);

        bool Update(InfoTrip infoTrip);

        List<Employee> GetAllTaiXe();

        List<Employee> GetAllHDV();

        List<Location> GetAllLocation();

        List<Vehicle> GetAllVehicle();
    }
}