using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace CodeHomeWork_4_6
{
    public class MyConnectionString
    {
        public string ConnectionString { get; set; }
    }

    public sealed class ApplicationContextFactory : IDesignTimeDbContextFactory<ApplicationContext>
    {
        public ApplicationContext CreateDbContext(string[] args)
        {
            string jsonString = File.ReadAllText("MyConnectionString.json");
            MyConnectionString myConnectionString = JsonSerializer.Deserialize<MyConnectionString>(jsonString);

            var connectionString = myConnectionString.ConnectionString;
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationContext>();
            var options = optionsBuilder
                .UseSqlServer(connectionString)
                .Options;

            return new ApplicationContext(options);
        }
    }
}
