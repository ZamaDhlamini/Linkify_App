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
        public virtual int Number { get; set; }

        public virtual Person Person { get; set; }
    }
}
