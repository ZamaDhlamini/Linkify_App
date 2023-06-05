using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myLinkify.Domain
{
    public class Grant: FullAuditedEntity<Guid>
    {
        public virtual string Grant_Id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public virtual string GrantName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public virtual string GrantType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public virtual string GrantDescription { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public virtual int GrantAmount { get; set; }
    }
}
