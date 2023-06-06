using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myLinkify.Domain
{
    public class Location: FullAuditedEntity<Guid>
    {
        /// <summary>
        /// 
        /// </summary>
        public virtual string Address { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public virtual double Latitude { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public virtual double Longitude { get; set; }
    }
}
