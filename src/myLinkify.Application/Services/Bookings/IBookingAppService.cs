using Abp.Application.Services;
using myLinkify.Domain.Enum;
using myLinkify.Services.Bookings.Dto;
using myLinkify.Services.CardService.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myLinkify.Services.Bookings
{
    public interface IBookingAppService : IApplicationService
    {
        Task<BookingDto> CreateAsync(BookingDto input);
        Task<BookingDto> GetAsync(Guid id);
        Task<List<BookingDto>> GetAllAsync();
        Task<BookingDto> UpdateAsync(BookingDto input);
        Task<List<BookingDto>> GetBookingsByStatusAsync(RefListStatus status);
        Task Delete(Guid id);
    }
}
