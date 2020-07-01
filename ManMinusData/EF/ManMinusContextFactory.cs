using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace ManMinusData.EF
{
    public class ManMinusContextFactory : IDesignTimeDbContextFactory<ManMinusContext>
    {
        public ManMinusContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionStrings = configuration.GetConnectionString("ManMinusDatabase");

            var optionsBuilder = new DbContextOptionsBuilder<ManMinusContext>();
            optionsBuilder.UseSqlServer(connectionStrings);

            return new ManMinusContext(optionsBuilder.Options);
        }
    }
}
