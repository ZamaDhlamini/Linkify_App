using Abp.Application.Services;
using myLinkify.Services.SarsNumberService.Dto;
using myLinkify.Services.StoreFilesService.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myLinkify.Services.StoreFilesService
{
    public interface IStoredFilesAppService : IApplicationService
    {
        Task<StoredFilesDto> CreateAsync(StoredFilesDto input);
        Task<StoredFilesDto> GetAsync(Guid id);
        Task<List<StoredFilesDto>> GetAllAsync();
        Task<StoredFilesDto> UpdateAsync(StoredFilesDto input);
        Task Delete(Guid id);
    }
}
