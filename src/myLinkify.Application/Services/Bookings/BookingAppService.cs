using Abp.Application.Services;
using Abp.Domain.Repositories;
using AutoMapper;
using myLinkify.Domain;
using myLinkify.Domain.Enum;
using myLinkify.Services.Bookings.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myLinkify.Services.Bookings
{
    public class BookingAppService : ApplicationService, IBookingAppService
    {
        private readonly IRepository<Booking, Guid> _bookingRepository;

        public BookingAppService(IRepository<Booking, Guid> bookingRepository)
        {
            _bookingRepository = bookingRepository;
        }

        public async Task<BookingDto> CreateAsync(BookingDto input)
        {
            var booking = ObjectMapper.Map<Booking>(input);
            var newBooking = await _bookingRepository.InsertAsync(booking);
            return ObjectMapper.Map<BookingDto>(newBooking);
        }

        public async Task Delete(Guid id)
        {
            await _bookingRepository.DeleteAsync(id);
        }

        public async Task<List<BookingDto>> GetAllAsync()
        {
            var bookings = await _bookingRepository.GetAllListAsync();
            return ObjectMapper.Map<List<BookingDto>>(bookings);
        }

        public async Task<BookingDto> GetAsync(Guid id)
        {
            var booking = await _bookingRepository.GetAsync(id);
            return ObjectMapper.Map<BookingDto>(booking);
        }

        public async Task<BookingDto> UpdateAsync(BookingDto input)
        {
            var booking = await _bookingRepository.GetAsync(input.Id);
            ObjectMapper.Map(input, booking);
            var updatedBooking = await _bookingRepository.UpdateAsync(booking);
            return ObjectMapper.Map<BookingDto>(updatedBooking);
        }

        public async Task<List<BookingDto>> GetBookingsByStatusAsync(RefListStatus status)
        {
            var bookings = await _bookingRepository.GetAllListAsync(b => b.Status == status);
            return ObjectMapper.Map<List<BookingDto>>(bookings);
        }
    }
}
