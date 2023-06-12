using Abp.Application.Services;
using Abp.Domain.Repositories;
using myLinkify.Domain;
using myLinkify.Services.Transactions.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myLinkify.Services.Transactions
{
    public class TransactionAppService : ApplicationService, ITransactionAppService
    {
        private readonly IRepository<Transaction, Guid> _transactionRepository;

        public TransactionAppService(IRepository transactionRepository)
        {
            _transactionRepository = (IRepository<Transaction, Guid>)transactionRepository;
        }

        public async Task<TransactionDto> CreateAsync(TransactionDto input)
        {
            var transaction = ObjectMapper.Map<Transaction>(input);
            transaction.Id = Guid.NewGuid();
            await _transactionRepository.InsertAsync(transaction);
            return ObjectMapper.Map<TransactionDto>(transaction);
        }

        public async Task Delete(Guid id)
        {
            await _transactionRepository.DeleteAsync(id);
        }

        public async Task<List<TransactionDto>> GetAllAsync()
        {
            var transactions = await _transactionRepository.GetAllListAsync();
            return ObjectMapper.Map<List<TransactionDto>>(transactions);
        }

        public async Task<TransactionDto> GetAsync(Guid id)
        {
            var transaction = await _transactionRepository.GetAsync(id);
            return ObjectMapper.Map<TransactionDto>(transaction);
        }

        public async Task<TransactionDto> UpdateAsync(TransactionDto input)
        {
            var transaction = await _transactionRepository.GetAsync(input.Id);
            ObjectMapper.Map(input, transaction);
            await _transactionRepository.UpdateAsync(transaction);
            return ObjectMapper.Map<TransactionDto>(transaction);
        }
    }
}
