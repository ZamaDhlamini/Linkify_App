using System.Threading.Tasks;
using myLinkify.Configuration.Dto;

namespace myLinkify.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
