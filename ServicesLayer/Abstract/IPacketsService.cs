using EntitiesLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicesLayer.Abstract
{
    public interface IPacketsService
    {
        Task<IEnumerable<PacketsDTO>> GetAllPackets();
        Task<PacketsDTO> CreatePackets(PacketsDTO packets);
        void UpdatePackets(PacketsDTO packets);
        void DeletePackets(int id);
    }
}
