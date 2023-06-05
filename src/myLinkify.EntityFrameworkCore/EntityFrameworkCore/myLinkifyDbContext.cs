using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using myLinkify.Authorization.Roles;
using myLinkify.Authorization.Users;
using myLinkify.MultiTenancy;

namespace myLinkify.EntityFrameworkCore
{
    public class myLinkifyDbContext : AbpZeroDbContext<Tenant, Role, User, myLinkifyDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public myLinkifyDbContext(DbContextOptions<myLinkifyDbContext> options)
            : base(options)
        {
        }
    }
}
