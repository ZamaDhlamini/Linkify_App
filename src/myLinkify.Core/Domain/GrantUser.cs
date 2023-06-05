using Abp.Domain.Entities.Auditing;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myLinkify.Domain
{
    public class GrantUser: FullAuditedEntity<Guid>
    {
        public virtual string IdNumber { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// 
        public virtual string SpouseId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// 
        [NotMapped]
        public IFormFile MarriageCertificate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// 
        [NotMapped]
        public IFormFile BankLetter { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// 
        [NotMapped]
        public IFormFile IncomeDocument { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// 
        [NotMapped]
        public IFormFile SassaAffidavit { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [NotMapped]
        public IFormFile BankStatement { get; set; }
        /// <summary>
        /// 
        /// </summary>
        ///
        [NotMapped]
        public IFormFile UifCard { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// 
        [NotMapped]
        public IFormFile PoliceAffidavit { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// 
        [NotMapped]
        public IFormFile SocialWorkerReport { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// 
        [NotMapped]
        public IFormFile SpouseAffidavit { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// 
        [NotMapped]
        public IFormFile SchoolLetter { get; set; }
    }
}
