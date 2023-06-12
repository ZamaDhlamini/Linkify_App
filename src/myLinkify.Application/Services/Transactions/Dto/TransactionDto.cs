using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using myLinkify.Domain;
using myLinkify.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using Transaction = myLinkify.Domain.Transaction;

namespace myLinkify.Services.Transactions.Dto
{
    [AutoMap(typeof(Transaction))]
    public class TransactionDto : EntityDto<Guid>
    {
        public  string TransactionName { get; set; }
        public  PersonDto Person { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public  int Amount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public  DateTime Transactiondate { get; set; }
    }
}
