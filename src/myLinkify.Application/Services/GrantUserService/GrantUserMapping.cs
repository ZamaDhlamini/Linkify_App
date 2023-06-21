using AutoMapper;
using myLinkify.Authorization.Users;
using myLinkify.Domain;
using myLinkify.Services.Dto;
using myLinkify.Services.GrantUserService.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myLinkify.Services.GrantUserService
{
    public class GrantUserMapping : Profile
    {
        public GrantUserMapping()
        {
            CreateMap<GrantUserDto, GrantUser>()
                 .ForMember(x => x.BankStatement, e => e.Ignore())
                 .ForMember(x => x.PoliceAffidavit, e => e.Ignore())
                 .ForMember(x => x.BankLetter, e => e.Ignore())
                 .ForMember(x => x.MarriageCertificate, e => e.Ignore())
                 .ForMember(x => x.IncomeDocument, e => e.Ignore())
                 .ForMember(x => x.SassaAffidavit, e => e.Ignore())
                 .ForMember(x => x.UifCard, e => e.Ignore())
                 .ForMember(x => x.SpouseAffidavit, e => e.Ignore())
                 .ForMember(x => x.SocialWorkerReport, e => e.Ignore())
                 .ForMember(x => x.SchoolLetter, e => e.Ignore())
                 .ForMember(x => x.Id, e => e.Ignore());

            CreateMap<GrantUser, GrantUserDto>()
                .ForMember(x => x.BankStatement, e => e.Ignore())
                 .ForMember(x => x.PoliceAffidavit, e => e.Ignore())
                 .ForMember(x => x.BankLetter, e => e.Ignore())
                 .ForMember(x => x.MarriageCertificate, e => e.Ignore())
                 .ForMember(x => x.IncomeDocument, e => e.Ignore())
                 .ForMember(x => x.SassaAffidavit, e => e.Ignore())
                 .ForMember(x => x.UifCard, e => e.Ignore())
                 .ForMember(x => x.SpouseAffidavit, e => e.Ignore())
                 .ForMember(x => x.SocialWorkerReport, e => e.Ignore())
                 .ForMember(x => x.SchoolLetter, e => e.Ignore());
        }
    }
}
