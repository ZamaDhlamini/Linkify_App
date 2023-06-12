using Abp.Application.Services;
using myLinkify.Services.ProdcutService.Dto;
using myLinkify.Services.SarsNumberService.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myLinkify.Services.SarsNumberService
{
    public interface ISarsNumberAppService : IApplicationService
    {
        Task<SarsNumberDto> CreateAsync(SarsNumberDto input);
        Task<SarsNumberDto> GetAsync(Guid id);
        Task<List<SarsNumberDto>> GetAllAsync();
        Task<SarsNumberDto> UpdateAsync(SarsNumberDto input);
        Task Delete(Guid id);
    }
}
