using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace myLinkify.EntityFrameworkCore
{
    public static class myLinkifyDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<myLinkifyDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<myLinkifyDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
