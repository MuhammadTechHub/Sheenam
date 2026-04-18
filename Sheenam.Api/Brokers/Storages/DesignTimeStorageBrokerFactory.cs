//==================================================
// Copyright (c) Coalition of Good-Hearted Engineers
// Free to Use Comfort and Peace
//==================================================

using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Sheenam.Api.Brokers.Storages
{
    public class DesignTimeStorageBrokerFactory : IDesignTimeDbContextFactory<StorageBroker>
    {
        public StorageBroker CreateDbContext(string[] args)
        {
            var basePath = Directory.GetCurrentDirectory();

            var configuration = new ConfigurationBuilder()
                .SetBasePath(basePath)
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .AddEnvironmentVariables()
                .Build();

            // Return StorageBroker created with IConfiguration so it uses OnConfiguring to set the provider.
            return new StorageBroker(configuration);
        }
    }
}
