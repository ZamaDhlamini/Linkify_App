using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using myLinkify.EntityFrameworkCore;
using myLinkify.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace myLinkify.Web.Tests
{
    [DependsOn(
        typeof(myLinkifyWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class myLinkifyWebTestModule : AbpModule
    {
        public myLinkifyWebTestModule(myLinkifyEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(myLinkifyWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(myLinkifyWebMvcModule).Assembly);
        }
    }
}