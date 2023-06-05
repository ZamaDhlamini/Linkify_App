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
        public virtual int TransactionId { get; set; }
        public virtual string TransactionName { get; set;}
        public virtual int Amount { get; set;}
    }
}
