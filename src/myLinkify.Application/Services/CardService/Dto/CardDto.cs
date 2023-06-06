using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using myLinkify.Domain;
using myLinkify.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myLinkify.Services.CardService.Dto
{
    [AutoMap(typeof(Card))]
    public class CardDto : EntityDto<Guid>
    {
        public PersonDto Person { get; set; }
        public string CardNumber { get; set; }
        public int ExpiryDateMonth { get; set; }
        public int ExpiryDateYear { get; set; }
    }
}
