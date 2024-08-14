using EntitiesLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicesLayer.Abstract
{
    public interface IDevicesService
    {
        Task<IEnumerable<DevicesDTO>> GetAllDevices();
        Task<DevicesDTO> CreateDevices(DevicesDTO devices);
        void UpdateDevices(DevicesDTO devices);
        void DeleteDevices(int id);
    }
}
