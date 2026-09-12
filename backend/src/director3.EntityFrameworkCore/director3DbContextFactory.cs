using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace director3.EntityFrameworkCore
{
    public class director3DbContextFactory : IDesignTimeDbContextFactory<director3DbContext>
    {
        public director3DbContext CreateDbContext(string[] args)
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../director3.Web.Host"))
                .AddJsonFile("appsettings.json", optional: false)
                .Build();

            var connStr = configuration.GetConnectionString("Default");
            var builder = new DbContextOptionsBuilder();
            builder.UseNpgsql(connStr);
            return new director3DbContext(builder.Options);
        }
    }
}
