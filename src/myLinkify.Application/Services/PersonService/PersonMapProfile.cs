using AutoMapper;
using myLinkify.Authorization.Users;
using myLinkify.Domain;
using myLinkify.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myLinkify.Services.PersonService
{
    public class PersonMapProfile : Profile
    {
        public PersonMapProfile()
        {
            CreateMap<Person, PersonDto>()
                .ForMember(x => x.userId, m => m.MapFrom(x => x.User != null ? x.User.Id : (long?)null));

            CreateMap<PersonDto, User>()
                //.ForMember(x => x.CellNumber, m => m.MapFrom(x => x.CellNumber))
                .ForMember(x => x.Name, m => m.MapFrom(x => x.Name + " " + x.Surname))
                .ForMember(x => x.Password, m => m.MapFrom(x => x.Password))
                .ForMember(x => x.Surname, m => m.MapFrom(x => x.Surname));


            CreateMap<PersonDto, User>()
                .ForMember(e => e.Id, d => d.Ignore());

            CreateMap<PersonDto, Person>()
                .ForMember(e => e.Id, d => d.Ignore());
        }
    }
}
