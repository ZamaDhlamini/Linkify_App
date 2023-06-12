using Abp.Application.Services;
using myLinkify.Services.StoreFilesService.Dto;
using myLinkify.Services.Transactions.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace myLinkify.Services.Transactions
{
    public interface ITransactionAppService : IApplicationService
    {
        Task<TransactionDto> CreateAsync(TransactionDto input);
        Task<TransactionDto> GetAsync(Guid id);
        Task<List<TransactionDto>> GetAllAsync();
        Task<TransactionDto> UpdateAsync(TransactionDto input);
        Task Delete(Guid id);
    }
}
