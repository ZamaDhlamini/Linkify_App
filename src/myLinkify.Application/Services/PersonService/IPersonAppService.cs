using Abp.Application.Services;
using myLinkify.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myLinkify.Services.PersonService
{
    public interface IPersonAppService : IApplicationService
    {
        Task<PersonDto> CreateAsync(PersonDto input);
        Task<PersonDto> GetAsync(Guid id);
        Task<List<PersonDto>> GetAllAsync();
        Task<PersonDto> UpdateAsync(PersonDto input);
        Task<PersonDto> GetByUserIdAsync(Guid id);
        Task Delete(Guid id);
    }
}
