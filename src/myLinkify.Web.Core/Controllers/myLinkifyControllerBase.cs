using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace myLinkify.Controllers
{
    public abstract class myLinkifyControllerBase: AbpController
    {
        protected myLinkifyControllerBase()
        {
            LocalizationSourceName = myLinkifyConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
