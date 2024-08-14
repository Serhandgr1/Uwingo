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
    public class DriverVehicleService : IDriverVehicleService
    {
        private readonly IRepositoryManager _repository;
        private readonly IMapper _mapper;
        private readonly ILogger<DriverVehicleService> _logger;

        public DriverVehicleService(IRepositoryManager repository, IMapper mapper, ILogger<DriverVehicleService> logger)
        {
            _repository = repository;
            _mapper = mapper;
            _logger = logger;
        }
        public async Task<IEnumerable<DriverVehicleDTO>> GetAllDriverVehicle() 
        {
            try {
                var data = await _repository.DriverVehicleRepository.GenericRead(false);
                var dto = _mapper.Map<IEnumerable<DriverVehicleDTO>>(data);
                return dto;
            }  catch (Exception ex) {
                _logger.LogError(ex.ToString());
                return Enumerable.Empty<DriverVehicleDTO>();    
            }
           
        }
        public async Task<DriverVehicleDTO> CreateDriverVehicle(DriverVehicleDTO driverVehicle) 
        {
            try {
                var data = _mapper.Map<DriverVehicle>(driverVehicle);
                if (data != null)
                {
                    await _repository.DriverVehicleRepository.GenericCreate(data);
                    _repository.Save();
                }
                return driverVehicle;
            }  catch (Exception ex) {
                _logger.LogError(ex.ToString());
                return new DriverVehicleDTO();
            }
          
        }
        public void UpdateDriverVehicle(DriverVehicleDTO driverVehicle) 
        {
            try {
                var data = _mapper.Map<DriverVehicle>(driverVehicle);
                if (data != null)
                {
                    var dataCheckt = _repository.DriverVehicleRepository.GetDriverVehicle(driverVehicle.DriversId, false);
                    if (dataCheckt != null)
                    {
                        _repository.DriverVehicleRepository.GenericUpdate(data);
                        _repository.Save();
                    }
                }
            } catch (Exception ex) {
                _logger.LogError(ex.ToString());
            }
             
       }
        public void DeleteDiverVehicle(int id) 
        {
            try {
                var data = _repository.DriverVehicleRepository.GetDriverVehicle(id, false).SingleOrDefault();
                if (data != null)
                {
                    _repository.DriverVehicleRepository.GenericDelete(data);
                    _repository.Save();
                }
            } catch (Exception ex) {
                _logger.LogError(ex.ToString());
            }
        }
    }
}
