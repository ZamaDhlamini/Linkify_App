using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myLinkify.Domain
{
    public class StoredFile : FullAuditedEntity<Guid>
    {
        public virtual string FileType { get; set; }
        public virtual string FileName { get; set; }
        public virtual string FileDescription { get; set; }

    }
}
