using Abp.Domain.Entities.Auditing;
using myLinkify.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myLinkify.Domain
{
    public class Address: FullAuditedEntity<Guid>
    {
        public virtual string StreetName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public virtual string City { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public virtual string PostalCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public virtual string HouseNumber { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public virtual RefListProvince Province { get; set; }
    }
}
