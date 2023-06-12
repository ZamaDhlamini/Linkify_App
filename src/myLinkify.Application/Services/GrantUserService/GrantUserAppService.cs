using Abp.Application.Services;
using Abp.Dependency;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using myLinkify.Domain;
using myLinkify.Services.GrantUserService.Dto;
using myLinkify.Services.StoreFilesService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myLinkify.Services.GrantUserService
{
    public class GrantUserAppService : ApplicationService, IGrantUserAppService
    {

        [HttpPost]
        public async Task<GrantUserDto> CreateAsync( [FromForm] GrantUserDto input)
        {

            var storedFileService = IocManager.Instance.Resolve<StoredFileAppService>();

            var grantUser = ObjectMapper.Map<GrantUser>(input);
            grantUser.BankLetter = await storedFileService.CreateStoredFile(input.BankLetter);
            throw new NotImplementedException();

        }

        public Task Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<List<GrantUserDto>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<GrantUserDto> GetAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<GrantUserDto> UpdateAsync(GrantUserDto input)
        {
            throw new NotImplementedException();
        }
    }
}
