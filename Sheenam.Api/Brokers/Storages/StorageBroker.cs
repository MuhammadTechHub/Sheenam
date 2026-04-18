//==================================================
// Copyright (c) Coalition of Good-Hearted Engineers
// Free to Use Comfort and Peace
//==================================================

using EFxceptions;
//==================================================
// Copyright (c) Coalition of Good-Hearted Engineers
// Free to Use Comfort and Peace
//==================================================

using Microsoft.EntityFrameworkCore;

namespace Sheenam.Api.Brokers.Storages
{
    public partial class StorageBroker : EFxceptionsContext
    {
        public readonly IConfiguration configuration;

        // Constructor used by runtime when IConfiguration is available via DI
        public StorageBroker(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        // NOTE: EFxceptionsContext does not expose a constructor that accepts DbContextOptions.
        // Design-time creation uses the IConfiguration-based constructor below.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                string connectionString = this.configuration?.GetConnectionString(name: "DefaultConnection")
                                          ?? "Server=(localdb)\\MSSQLLocalDB;Database=SheenamDb;Trusted_Connection=True;MultipleActiveResultSets=true";

                optionsBuilder.UseSqlServer(connectionString);
            }
        }

        public override void Dispose()
        {
            base.Dispose();
        }
    }
}