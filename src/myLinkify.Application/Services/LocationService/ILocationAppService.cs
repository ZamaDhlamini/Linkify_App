using Abp.Application.Services;
using myLinkify.Services.GrantService.Dto;
using myLinkify.Services.LocationService.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myLinkify.Services.LocationService
{
    public interface ILocationAppService : IApplicationService
    {
        Task<LocationDto> CreateAsync(LocationDto input);
        Task<LocationDto> GetAsync(Guid id);
        Task<List<LocationDto>> GetAllAsync();
        Task<LocationDto> UpdateAsync(LocationDto input);
        Task Delete(Guid id);
    }
}
