using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace acr_main_api.Data
{
    public class MainContextFactory : IDesignTimeDbContextFactory<MainContext>
    {
        public MainContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<MainContext>();
            optionsBuilder.UseNpgsql(Config.DbConnectionString);

            return new MainContext(optionsBuilder.Options);
        }
    }
}
