using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myLinkify.Domain
{
    public class Card: FullAuditedEntity<Guid>
    {
        public virtual Person Person { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public virtual string CardNumber { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public virtual int ExpiraryDateMonth { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public virtual int ExpiraryDateYear { get; set; }
    }
}
