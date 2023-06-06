using AutoMapper;
using myLinkify.Domain;
using myLinkify.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myLinkify.Services.GrantService.Dto.Mapping
{
    public class GrantMapProfile : Profile
    {
        public GrantMapProfile()
        {
            CreateMap<GrantDto, Grant>().ForMember(e => e.Id, d => d.Ignore());
        }
    }
}
