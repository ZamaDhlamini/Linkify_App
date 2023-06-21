using Abp.Application.Services;
using Abp.Dependency;
using Abp.Domain.Repositories;
using Abp.UI;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using myLinkify.Authorization.Users;
using myLinkify.Domain;
using myLinkify.Services.GrantUserService.Dto;
using myLinkify.Services.StoreFilesService;
using myLinkify.Services.StoreFilesService.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myLinkify.Services.GrantUserService
{
    public class GrantUserAppService : ApplicationService, IGrantUserAppService
    {
        private readonly IRepository<GrantUser, Guid> _grantUserRepository;
        private readonly IRepository<User, long> _userRepository;
        private readonly UserManager _userManagerRepository;
        public GrantUserAppService(IRepository<GrantUser, Guid> grantUserRepository, UserManager userManager, IRepository<User, long> userRepository)
        {               
            _grantUserRepository = grantUserRepository;
            _userManagerRepository = userManager;
            _userRepository = userRepository;
        }

        [HttpPost]
        [Consumes("multipart/form-data")]
        public async Task<GrantUserDto> CreateAsync( [FromForm] GrantUserDto input)
        {

            var storedFileService = IocManager.Instance.Resolve<StoredFileAppService>();

            // check if user exists
            var user = await _userRepository.GetAsync(input.UserId);

            if (user == null)
                throw new UserFriendlyException("User does not exist");

            ObjectMapper.Map(user, input);

            var grantUser = ObjectMapper.Map<GrantUser>(input);

            grantUser.User = user;

            grantUser.BankLetter = await storedFileService.CreateStoredFile(new StoredFilesDto { File = input.BankLetter });
            grantUser.MarriageCertificate= await storedFileService.CreateStoredFile(new StoredFilesDto { File = input.MarriageCertificate });
            grantUser.IncomeDocument=await storedFileService.CreateStoredFile(new StoredFilesDto { File = input.IncomeDocument });
            grantUser.SassaAffidavit= await storedFileService.CreateStoredFile(new StoredFilesDto { File = input.SassaAffidavit });
            grantUser.BankStatement= await storedFileService.CreateStoredFile(new StoredFilesDto { File = input.BankStatement });
            grantUser.UifCard= await storedFileService.CreateStoredFile(new StoredFilesDto { File = input.UifCard });
            grantUser.PoliceAffidavit= await storedFileService.CreateStoredFile(new StoredFilesDto { File = input.PoliceAffidavit });
            grantUser.SocialWorkerReport= await storedFileService.CreateStoredFile(new StoredFilesDto { File = input.SocialWorkerReport });
            grantUser.SchoolLetter= await storedFileService.CreateStoredFile(new StoredFilesDto { File = input.SchoolLetter });


            grantUser = await _grantUserRepository.InsertAsync(grantUser);
            return ObjectMapper.Map<GrantUserDto>(grantUser);

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
