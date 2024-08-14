using EntitiesLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicesLayer.Abstract
{
    public interface IDriversService
    {
        Task<IEnumerable<DriversDTO>> GetAllDrivers();
        Task<DriversDTO> CreateDrivers(DriversDTO drivers);
        void UpdateDrivers(DriversDTO drivers);
        void DeleteDrivers(int id);
    }
}
