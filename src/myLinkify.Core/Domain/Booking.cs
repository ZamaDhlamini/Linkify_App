using Abp.Domain.Entities.Auditing;
using myLinkify.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myLinkify.Domain
{
    public class Booking: FullAuditedEntity<Guid>
    {
        public virtual DateTime BookingDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        //public virtual string Time { get; set; }
        /*public virtual TimeSpan Time { get; set; }*/ //slot numbers
        public virtual TimeSpan StartTime { get; set; } //slot numbers
        public virtual TimeSpan EndTime { get; set; } //slot numbers

        /// <summary>
        /// 
        /// </summary>
        public virtual RefListStatus Status { get; set; }
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
