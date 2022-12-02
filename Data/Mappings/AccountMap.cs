using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models;

namespace Data.Mappings;

public class AccountMap : IEntityTypeConfiguration<Account>
{
    public void Configure(EntityTypeBuilder<Account> builder)
    {
        builder
            .ToTable("account")
            .HasKey(x => x.Email);
        builder
            .Property(x => x.Ativo)
            .HasDefaultValueSql("true")
            .IsRequired()
            .HasColumnName("ativo")
            .HasColumnType("boolean");
        builder
            .Property(x => x.CriadoEm)
            .IsRequired()
            .HasColumnName("criado_em")
            .HasColumnType("timestamptz")
            .HasDefaultValueSql("now()")
            .ValueGeneratedOnAdd();
        builder
            .Property(x => x.AtualizadoEm)
            .IsRequired()
            .HasColumnName("atualizado_em")
            .HasColumnType("timestamptz")
            .HasDefaultValueSql("now()")
            .ValueGeneratedOnAddOrUpdate();

        builder.HasIndex(x => x.ContatoId)
            .IsUnique();

        builder
            .Property(x => x.Email)
            .IsRequired()
            .HasColumnName("email")
            .HasColumnType("varchar(254)")
            .HasMaxLength(254);
        builder
            .Property(x => x.Senha)
            .IsRequired()
            .HasColumnName("senha")
            .HasColumnType("varchar(150)")
            .HasMaxLength(150);

        builder
            .HasOne(x => x.Contato)
            .WithOne(x => x.Account)
            .IsRequired();
        builder
            .Property(x => x.ContatoId)
            .HasColumnName("contato_id")
            .HasColumnType("uuid")
            .IsRequired();
    }
}