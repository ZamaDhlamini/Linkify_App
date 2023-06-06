using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myLinkify.Domain
{
    public class Transaction: FullAuditedEntity<Guid>
    {
        public virtual string TransactionName { get; set;}
        public virtual Person Person { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public virtual int Amount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public virtual DateTime Transactiondate { get; set; }
    }
}
