using Abp.Application.Services;
using myLinkify.Services.CardService.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myLinkify.Services.CardService
{
    public interface ICardAppService : IApplicationService
    {
        Task<CardDto> CreateAsync(CardDto input);
        Task<CardDto> GetAsync(Guid id);
        Task<List<CardDto>> GetAllAsync();
        Task<CardDto> UpdateAsync(CardDto input);
        Task Delete(Guid id);
    }
}
