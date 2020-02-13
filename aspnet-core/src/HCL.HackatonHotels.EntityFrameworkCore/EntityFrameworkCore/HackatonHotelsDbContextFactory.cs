using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using HCL.HackatonHotels.Configuration;
using HCL.HackatonHotels.Web;

namespace HCL.HackatonHotels.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class HackatonHotelsDbContextFactory : IDesignTimeDbContextFactory<HackatonHotelsDbContext>
    {
        public HackatonHotelsDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<HackatonHotelsDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            HackatonHotelsDbContextConfigurer.Configure(builder, configuration.GetConnectionString(HackatonHotelsConsts.ConnectionStringName));

            return new HackatonHotelsDbContext(builder.Options);
        }
    }
}
