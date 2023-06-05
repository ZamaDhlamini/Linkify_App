using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using myLinkify.Authorization.Roles;
using myLinkify.Authorization.Users;
using myLinkify.MultiTenancy;
using myLinkify.Domain;

namespace myLinkify.EntityFrameworkCore
{
    public class myLinkifyDbContext : AbpZeroDbContext<Tenant, Role, User, myLinkifyDbContext>
    {
        /* Define a DbSet for each entity of the application */
        public DbSet<Person> Persons { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Card> Cards { get; set; }
        public DbSet<Grant> Grants { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<SarsNumber> SarsNumbers { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        
        public myLinkifyDbContext(DbContextOptions<myLinkifyDbContext> options)
            : base(options)
        {
        }
    }
}
