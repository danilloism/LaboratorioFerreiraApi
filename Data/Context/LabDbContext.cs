using Data.Mappings;
using Enums;
using Microsoft.EntityFrameworkCore;
using Models;

namespace Data.Context;

public class LabDbContext : DbContext
{
    public DbSet<Contato> Contatos { get; set; } = null!;
    public DbSet<Account> Accounts { get; set; } = null!;

    public LabDbContext(DbContextOptions<LabDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .HasPostgresEnum<CategoriasEnum>()
            .ApplyConfiguration(new ContatoMap())
            .ApplyConfiguration(new AccountMap());
    }
}