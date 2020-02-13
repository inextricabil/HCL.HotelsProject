using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace HCL.HackatonHotels.EntityFrameworkCore
{
    public static class HackatonHotelsDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<HackatonHotelsDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<HackatonHotelsDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
