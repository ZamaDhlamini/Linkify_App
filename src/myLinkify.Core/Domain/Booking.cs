using Abp.Domain.Entities.Auditing;
using myLinkify.Domain.Antributes;
using myLinkify.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myLinkify.Domain
{
    [DiscriminatorValue("Booking")]
    public class Booking: FullAuditedEntity<Guid>
    {
        public virtual DateTime BookingDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
   
        /// <summary>
        /// 
        /// </summary>
        public virtual RefListStatus Status { get; set; }

        public virtual RefListBranches Branches { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public virtual int BookingToken { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public virtual Person Person { get; set; }
    }
}
