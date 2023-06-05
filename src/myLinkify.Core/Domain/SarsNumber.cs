using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myLinkify.Domain
{
    public class SarsNumber: FullAuditedEntity<Guid>
    {
        public virtual int SarsNumberId { get; set; }

        public virtual string UserId { get; set; }
    }
}
