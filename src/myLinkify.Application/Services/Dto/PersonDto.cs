using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using myLinkify.Authorization.Users;
using myLinkify.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myLinkify.Services.Dto
{
    [AutoMap(typeof(Person))]
    public class PersonDto : EntityDto<Guid>
    {
        public virtual string IdNumber { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// 
        public virtual string Name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public virtual string Surname { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// 
        public virtual string Password { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual string PhoneNumber { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public virtual string EmailAddress { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public User User { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// 
        public virtual string[] RoleNames { get; set; }
    }
}
