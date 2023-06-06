using Abp.Application.Services;
using myLinkify.Services.BookingService.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myLinkify.Services.BookingService
{
    public class BookingAppService : ApplicationService, IBookingAppService
    {
        public Task<BookingDto> CreateAsync(BookingDto input)
        {
            throw new NotImplementedException();
        }

        public Task Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<List<BookingDto>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<BookingDto> GetAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<BookingDto> UpdateAsync(BookingDto input)
        {
            throw new NotImplementedException();
        }
    }
}
