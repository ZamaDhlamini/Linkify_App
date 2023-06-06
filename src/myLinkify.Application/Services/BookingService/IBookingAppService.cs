using Abp.Application.Services;
using myLinkify.Services.BookingService.Dto;
using myLinkify.Services.CardService.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myLinkify.Services.BookingService
{
    public interface IBookingAppService : IApplicationService
    {
        Task<BookingDto> CreateAsync(BookingDto input);
        Task<BookingDto> GetAsync(Guid id);
        Task<List<BookingDto>> GetAllAsync();
        Task<BookingDto> UpdateAsync(BookingDto input);
        Task Delete(Guid id);
    }
}
