using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using myLinkify.Authorization;

namespace myLinkify
{
    [DependsOn(
        typeof(myLinkifyCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class myLinkifyApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<myLinkifyAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(myLinkifyApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
