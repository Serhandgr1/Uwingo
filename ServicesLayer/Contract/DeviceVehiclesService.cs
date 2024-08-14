using AutoMapper;
using DataAccessLayer.Manager;
using EntitiesLayer.Abstract;
using EntitiesLayer.Contract;
using Microsoft.Extensions.Logging;
using ServicesLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicesLayer.Contract
{
    public class DeviceVehiclesService : IDeviceVehiclesService
    {
        private readonly IRepositoryManager _repository;
        private readonly IMapper _mapper;
        private readonly ILogger<DeviceVehiclesService> _logger;
        public DeviceVehiclesService(IRepositoryManager repository, IMapper mapper, ILogger<DeviceVehiclesService> logger)
        {
            _logger = logger;
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<IEnumerable<DeviceVehiclesDTO>> GetAllDeviceVehicles() 
        {
            try {
                var data = await _repository.DevicesVehiclesRepository.GenericRead(false);
                var dto = _mapper.Map<IEnumerable<DeviceVehiclesDTO>>(data);
                return dto;
            } catch (Exception ex) {
                _logger.LogError(ex.ToString());
                return  Enumerable.Empty<DeviceVehiclesDTO>();
            }
          
        }
        public async Task<DeviceVehiclesDTO> CreateDeviceVehicles(DeviceVehiclesDTO deviceVehicles) 
        {
            try {
                var data = _mapper.Map<DeviceVehicles>(deviceVehicles);
                if (data != null)
                {
                    await _repository.DevicesVehiclesRepository.GenericCreate(data);
                    _repository.Save();
                }
                return deviceVehicles;
            } catch (Exception ex) { 
                    _logger.LogError(ex.ToString());
                return new DeviceVehiclesDTO();
            }
         
        }
        public void UpdateDeviceVehicles(DeviceVehiclesDTO deviceVehicles) 
        {
            try {
                var data = _mapper.Map<DeviceVehicles>(deviceVehicles);
                if (data != null)
                {
                    var dataCheck = _repository.DevicesVehiclesRepository.GetDeviceVehicles(data.ConnectionId, false).SingleOrDefault();
                    if (dataCheck != null)
                    {
                        _repository.DevicesVehiclesRepository.GenericUpdate(data);
                        _repository.Save();
                    }
                }
            } catch (Exception ex) {
                _logger.LogError(ex.ToString());
            }
            
        }
        public void DeleteDeviceVehicles(int id) 
        { try {
                var data = _repository.DevicesVehiclesRepository.GetDeviceVehicles(id, false).SingleOrDefault();
                if (data != null)
                {
                    _repository.DevicesVehiclesRepository.GenericDelete(data);
                    _repository.Save();
                }
            } catch (Exception ex) {
                _logger.LogError(ex.ToString());
            }
        }
    }
}
