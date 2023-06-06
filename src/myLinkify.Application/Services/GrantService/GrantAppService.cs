using Abp.Application.Services;
using Abp.Domain.Repositories;
using AutoMapper;
using myLinkify.Domain;
using myLinkify.Services.GrantService.Dto;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace myLinkify.Services.GrantService
{
    public class GrantAppService : ApplicationService, IGrantAppService
    {
        private readonly IRepository<Grant, Guid> _grantRepository;

        public GrantAppService(IRepository<Grant, Guid> grantRepository)
        {
            _grantRepository = grantRepository;
        }

        public async Task<GrantDto> CreateAsync(GrantDto input)
        {
            var grant = ObjectMapper.Map<Grant>(input);
            var newGrant = await _grantRepository.InsertAsync(grant);
            return ObjectMapper.Map<GrantDto>(newGrant);
        }

        public async Task Delete(Guid id)
        {
            await _grantRepository.DeleteAsync(id);
        }

        public async Task<List<GrantDto>> GetAllAsync()
        {
            var grants = await _grantRepository.GetAllListAsync();
            return ObjectMapper.Map<List<GrantDto>>(grants);
        }

        public async Task<GrantDto> GetAsync(Guid id)
        {
            var grant = await _grantRepository.GetAsync(id);
            return ObjectMapper.Map<GrantDto>(grant);
        }

        public async Task<GrantDto> UpdateAsync(GrantDto input)
        {
            var grant = await _grantRepository.GetAsync(input.Id);
            ObjectMapper.Map(input, grant);
            var updatedGrant = await _grantRepository.UpdateAsync(grant);
            return ObjectMapper.Map<GrantDto>(updatedGrant);
        }
    }
}
