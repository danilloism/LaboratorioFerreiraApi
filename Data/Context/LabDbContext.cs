using Data.Mappings;
using Enums;
using Microsoft.EntityFrameworkCore;
using Models;

namespace Data.Context;

public class LabDbContext : DbContext
{
    public DbSet<Contato> Contatos { get; set; }
    public DbSet<Account> Accounts { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        options.UseNpgsql("Server=localhost,5432;Database=lab;User ID=danilloism;Password=senhatemp123");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
    modelBuilder
        .HasPostgresExtension("uuid-ossp")
        .HasPostgresEnum<CategoriasEnum>()
        .ApplyConfiguration(new ContatoMap())
        .ApplyConfiguration(new AccountMap());
    }
}