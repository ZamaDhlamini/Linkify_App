using Abp.Application.Services.Dto;
using AutoMapper;
using myLinkify.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myLinkify.Services.GrantService.Dto
{
    [AutoMap(typeof(Grant))]
    public class GrantDto : EntityDto<Guid>
    {
        public  string GrantName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public  string GrantType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string GrantDescription { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int GrantAmount { get; set; }
    }
}
