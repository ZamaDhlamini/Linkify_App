using Abp.Application.Services;
using Abp.Domain.Repositories;
using myLinkify.Domain;
using myLinkify.Services.StoreFilesService.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myLinkify.Services.StoreFilesService
{
    public class StoredFilesAppService : ApplicationService, IStoredFilesAppService
    {
        private readonly IRepository<StoredFile, Guid> _storedFilesRepository;

        public StoredFilesAppService(IRepository storedFilesRepository)
        {
            _storedFilesRepository = (IRepository<StoredFile, Guid>)storedFilesRepository;
        }

        public async Task<StoredFilesDto> CreateAsync(StoredFilesDto input)
        {
            var storedFile = ObjectMapper.Map<StoredFile>(input);
            storedFile.Id = Guid.NewGuid();
            await _storedFilesRepository.InsertAsync(storedFile);
            return ObjectMapper.Map<StoredFilesDto>(storedFile);
        }

        public async Task Delete(Guid id)
        {
            await _storedFilesRepository.DeleteAsync(id);
        }

        public async Task<List<StoredFilesDto>> GetAllAsync()
        {
            var storedFiles = await _storedFilesRepository.GetAllListAsync();
            return ObjectMapper.Map<List<StoredFilesDto>>(storedFiles);
        }

        public async Task<StoredFilesDto> GetAsync(Guid id)
        {
            var storedFile = await _storedFilesRepository.GetAsync(id);
            return ObjectMapper.Map<StoredFilesDto>(storedFile);
        }

        public async Task<StoredFilesDto> UpdateAsync(StoredFilesDto input)
        {
            var storedFile = await _storedFilesRepository.GetAsync(input.Id);
            ObjectMapper.Map(input, storedFile);
            await _storedFilesRepository.UpdateAsync(storedFile);
            return ObjectMapper.Map<StoredFilesDto>(storedFile);
        }
    }
}
