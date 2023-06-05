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
        public int CardId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string UserId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public virtual string CardNumber { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public virtual string ExpiraryDate { get; set; }
    }
}
