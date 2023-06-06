using Abp.Application.Services;
using myLinkify.Services.CardService.Dto;
using myLinkify.Services.GrantService.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myLinkify.Services.GrantService
{
    public interface IGrantAppService : IApplicationService
    {
        Task<GrantDto> CreateAsync(GrantDto input);
        Task<GrantDto> GetAsync(Guid id);
        Task<List<GrantDto>> GetAllAsync();
        Task<GrantDto> UpdateAsync(GrantDto input);
        Task Delete(Guid id);
    }
}
