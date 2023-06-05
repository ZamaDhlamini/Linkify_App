using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using myLinkify.Configuration;

namespace myLinkify.Web.Host.Startup
{
    [DependsOn(
       typeof(myLinkifyWebCoreModule))]
    public class myLinkifyWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public myLinkifyWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(myLinkifyWebHostModule).GetAssembly());
        }
    }
}
