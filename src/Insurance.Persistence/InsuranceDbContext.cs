using Isuranse.Persistence.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.Extensions.Logging;
using System.Reflection;

namespace Insurance.Persistence;
public class InsuranceDbContext : DbContext
{
    public InsuranceDbContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<InsuredPersonEntity> InsuredPersons { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.ConfigureWarnings(c => c.Log((RelationalEventId.CommandExecuting, LogLevel.Information)));
    }
}
