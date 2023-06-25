using Abp.Application.Services;
using Abp.Domain.Repositories;
using myLinkify.Domain;
using myLinkify.Services.LocationService.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myLinkify.Services.LocationService
{
    public class LocationAppService : ApplicationService, ILocationAppService
    {
        private readonly IRepository<Location, Guid> _locationRepository;

        public LocationAppService(IRepository<Location, Guid> locationRepository)
        {
            _locationRepository = locationRepository;
        }

        public async Task<LocationDto> CreateAsync(LocationDto input)
        {
            var location = ObjectMapper.Map<Location>(input);
            location.Id = Guid.NewGuid();
            await _locationRepository.InsertAsync(location);
            return ObjectMapper.Map<LocationDto>(location);
        }

        public async Task Delete(Guid id)
        {
            await _locationRepository.DeleteAsync(id);
        }

        public async Task<List<LocationDto>> GetAllAsync()
        {
            var locations = await _locationRepository.GetAllListAsync();
            return ObjectMapper.Map<List<LocationDto>>(locations);
        }

        public async Task<LocationDto> GetAsync(Guid id)
        {
            var location = await _locationRepository.GetAsync(id);
            return ObjectMapper.Map<LocationDto>(location);
        }

        public async Task<LocationDto> UpdateAsync(LocationDto input)
        {
            var location = await _locationRepository.GetAsync(input.Id);
            ObjectMapper.Map(input, location);
            await _locationRepository.UpdateAsync(location);
            return ObjectMapper.Map<LocationDto>(location);
        }
    }
}
