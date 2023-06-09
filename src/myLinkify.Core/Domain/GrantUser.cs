﻿using Abp.Domain.Entities.Auditing;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using myLinkify.Domain.Antributes;

namespace myLinkify.Domain
{
    //Discriminator
    //[Discriminator("GrantUser")]
    [DiscriminatorValue("GrantUser")]
    public class GrantUser: Person
    {
        /// <summary>
        /// 
        /// </summary>
        public virtual string SpouseIdNumber { get; set; }
        /// <summary>
        /// 
        /// </summary>

        public StoredFile MarriageCertificate { get; set; }
        /// <summary>
        /// 
        /// </summary>

        public StoredFile BankLetter { get; set; }
        /// <summary>
        /// 
        /// </summary>


        public StoredFile IncomeDocument { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// 

        public StoredFile SassaAffidavit { get; set; }
        /// <summary>
        /// 
        /// </summary>

        public StoredFile BankStatement { get; set; }
        /// <summary>
        /// 
        /// </summary>
        ///

        public StoredFile UifCard { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// 

        public StoredFile PoliceAffidavit { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// 

        public StoredFile SocialWorkerReport { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// 

        public StoredFile SpouseAffidavit { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// 

        public StoredFile SchoolLetter { get; set; }
    }
}
