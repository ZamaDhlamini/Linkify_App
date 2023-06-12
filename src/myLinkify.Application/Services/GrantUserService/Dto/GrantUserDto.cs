using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Microsoft.AspNetCore.Http;
using myLinkify.Domain;
using myLinkify.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myLinkify.Services.GrantUserService.Dto
{
    [AutoMap(typeof(GrantUser))]
    public class GrantUserDto : PersonDto
    {
        /// <summary>
        /// 
        /// </summary>
        public  string SpouseIdNumber { get; set; }

        /// <summary>
        /// 
        /// </summary>

        public IFormFile MarriageCertificate { get; set; }
        /// <summary>
        /// 
        /// </summary>

        public IFormFile BankLetter { get; set; }
        /// <summary>
        /// 
        /// </summary>


        public IFormFile IncomeDocument { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// 

        public IFormFile SassaAffidavit { get; set; }
        /// <summary>
        /// 
        /// </summary>

        public IFormFile BankStatement { get; set; }
        /// <summary>
        /// 
        /// </summary>
        ///

        public IFormFile UifCard { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// 

        public IFormFile PoliceAffidavit { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// 

        public IFormFile SocialWorkerReport { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// 

        public IFormFile SpouseAffidavit { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// 

        public IFormFile SchoolLetter { get; set; }
    }
}
