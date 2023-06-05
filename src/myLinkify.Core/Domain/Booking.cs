using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myLinkify.Domain
{
    public class Booking: FullAuditedEntity<Guid>
    {
        public virtual string BookingId { get; set; }
        public virtual string Time { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public virtual string Status { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public virtual int BookingTooken { get; set; }
        /// <summary>
        /// 
        /// </summary>
    }
}
