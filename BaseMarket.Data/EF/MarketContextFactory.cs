using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseMarket.Data.EF
{
    public class MarketContextFactory : IDesignTimeDbContextFactory<MarketDbContext>
    {
        public MarketDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionStrings = configuration.GetConnectionString("MarketDb");

            var optionsBuilder = new DbContextOptionsBuilder<MarketDbContext>();
            optionsBuilder.UseSqlServer(connectionStrings);

            return new MarketDbContext(optionsBuilder.Options);
        }
    }
}
