using EntitiesLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicesLayer.Abstract
{
    public interface ITrackingDataForACCService
    {
        Task<IEnumerable<TrackingDataForACCDTO>> GetAllTarckingDataAcc();
        Task<TrackingDataForACCDTO> CreateTrackingDataForAcc(TrackingDataForACCDTO trackingDataForACCDTO);
        void UpdateTrackingDataForAcc(TrackingDataForACCDTO trackingDataForACCDTO);
        void DeleteTrackingDataForAcc(int id);
    }
}
