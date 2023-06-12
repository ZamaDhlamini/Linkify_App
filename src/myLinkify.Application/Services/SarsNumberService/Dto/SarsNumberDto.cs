using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using myLinkify.Domain;
using myLinkify.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myLinkify.Services.SarsNumberService.Dto
{
    [AutoMap(typeof(SarsNumber))]
    public class SarsNumberDto : EntityDto<Guid>
    {
        public  int Number { get; set; }

        public  PersonDto Person { get; set; }
    }
}
