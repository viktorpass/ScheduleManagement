using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using ScheduleManagement.Models;
using System;

namespace ScheduleManagement.Context
{
        public class AppDbContextFactory : IDesignTimeDbContextFactory<AppDbContext> {

            public AppDbContext CreateDbContext(string[] args) {
                var config = new ConfigurationBuilder()
                 .SetBasePath(Directory.GetCurrentDirectory())
                 .AddJsonFile("appsettings.json")
                .Build();

                var builder = new DbContextOptionsBuilder<AppDbContext>()
                    .UseSqlServer(config.GetConnectionString("ConnectionString"), b => b.MigrationsAssembly("Data"))
                    ;

                

                return new AppDbContext(builder.Options);
            }
        


    }
}
