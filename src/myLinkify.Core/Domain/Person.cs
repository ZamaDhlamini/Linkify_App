using Abp.Domain.Entities.Auditing;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using myLinkify.Authorization.Users;
using myLinkify.Domain.Antributes;
using myLinkify.Domain.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myLinkify.Domain
{
    [DiscriminatorValue("Person")]
    public class Person: FullAuditedEntity<Guid>
    {
        public virtual string IdNumber { get; set; }
        /// <summary>
        /// 
        /// </summary>
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
        public virtual Address Address { get; set; }
        public virtual RefListGender Gender { get; set; }


    }
}
