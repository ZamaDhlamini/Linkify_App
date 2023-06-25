using Abp.Application.Services;
using Abp.Domain.Repositories;
using myLinkify.Domain;
using myLinkify.Services.SarsNumberService.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myLinkify.Services.SarsNumberService
{
    public class SarsNumberAppService : ApplicationService, ISarsNumberAppService
    {
        private readonly IRepository<SarsNumber, Guid> _sarsNumberRepository;
        private readonly Random _random;

        public SarsNumberAppService(IRepository<SarsNumber, Guid> sarsNumberRepository)
        {
            _sarsNumberRepository = sarsNumberRepository;
            _random = new Random();
        }

        public async Task<SarsNumberDto> CreateAsync(SarsNumberDto input)
        {
            input.Id = Guid.NewGuid();

            // Your logic for creating the SarsNumberDto goes here
            input.Number = GenerateUniqueProviderNumber();
            var sarsNumber = ObjectMapper.Map<SarsNumber>(input);
            await _sarsNumberRepository.InsertAsync(sarsNumber);

            return ObjectMapper.Map<SarsNumberDto>(sarsNumber);
        }

        private int GenerateUniqueProviderNumber()
        {
            while (true)
            {
                var Sars = _random.Next(100, 100000);
                var existingProvider = _sarsNumberRepository.FirstOrDefault(p => p.Number == Sars);
                if (existingProvider == null)
                {
                    return Sars;
                }
            }
        }

        public async Task Delete(Guid id)
        {
            // Your logic for deleting the SarsNumberDto with the given id goes here
            await _sarsNumberRepository.DeleteAsync(id);
        }

        public async Task<List<SarsNumberDto>> GetAllAsync()
        {
            // Your logic for getting all SarsNumberDto instances goes here
            var sarsNumbers = await _sarsNumberRepository.GetAllListAsync();
            return ObjectMapper.Map<List<SarsNumberDto>>(sarsNumbers);
        }

        public async Task<SarsNumberDto> GetAsync(Guid id)
        {
            // Your logic for getting the SarsNumberDto with the given id goes here
            var sarsNumber = await _sarsNumberRepository.GetAsync(id);
            return ObjectMapper.Map<SarsNumberDto>(sarsNumber);
        }

        public async Task<SarsNumberDto> UpdateAsync(SarsNumberDto input)
        {
            // Your logic for updating the SarsNumberDto goes here
            var sarsNumber = await _sarsNumberRepository.GetAsync(input.Id);
            ObjectMapper.Map(input, sarsNumber);
            await _sarsNumberRepository.UpdateAsync(sarsNumber);
            return ObjectMapper.Map<SarsNumberDto>(sarsNumber);
        }
    }
}
