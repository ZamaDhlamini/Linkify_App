using System.Threading.Tasks;
using Abp.Application.Services;
using myLinkify.Sessions.Dto;

namespace myLinkify.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
