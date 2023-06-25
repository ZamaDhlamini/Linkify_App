using Abp.Application.Services.Dto;
using myLinkify.Domain.Enum;
using myLinkify.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using myLinkify.Services.Dto;
using Abp.AutoMapper;

namespace myLinkify.Services.Bookings.Dto
{
    [AutoMap(typeof(Booking))]
    public class BookingDto : EntityDto<Guid>
    {
        /// <summary>
        /// 
        /// </summary>
        public  DateTime BookingDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public RefListStatus? Status { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public RefListBranches? Branches { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public  int BookingToken { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public PersonDto Person { get; set; }
    }
}
