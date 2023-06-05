using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myLinkify.Domain
{
    public class Product: FullAuditedEntity<Guid>
    {
        public virtual string ProductId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public virtual string ProductName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public virtual string ProductDescription { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public virtual string ProductCategory { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public virtual string Price { get; set; }
    }
}
