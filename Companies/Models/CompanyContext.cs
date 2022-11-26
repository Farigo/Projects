using Microsoft.EntityFrameworkCore;

namespace Companies.Models;

public class CompanyContext : DbContext
{
    public CompanyContext(DbContextOptions<CompanyContext> options)
        : base(options)
    {
        var folder = Environment.SpecialFolder.LocalApplicationData;
        var path = Environment.GetFolderPath(folder);
        DbPath = System.IO.Path.Join(path, "companies.db");
    }

    public DbSet<Company> Companies { get; set; } = null!;

    public string DbPath { get; }

    // The following configures EF to create a Sqlite database file in the
    // special "local" folder for your platform.
    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite($"Data Source={DbPath}");
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Company>().HasIndex(c => c.Isin).IsUnique();
    }
}