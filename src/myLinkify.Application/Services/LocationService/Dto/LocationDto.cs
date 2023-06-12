using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using myLinkify.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myLinkify.Services.LocationService.Dto
{
    [AutoMap(typeof(Location))]
    public class LocationDto : EntityDto<Guid>
    {
        public string Address { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double Latitude { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double Longitude { get; set; }
    }
}
