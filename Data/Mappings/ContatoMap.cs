using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.ValueGeneration;
using Models;

namespace Data.Mappings;

public class ContatoMap : IEntityTypeConfiguration<Contato>
{
    public void Configure(EntityTypeBuilder<Contato> builder)
    {
        builder
            .ToTable("contato")
            .HasKey(x => new { x.Id });
        builder
            .Property(x => x.Id)
            .IsRequired()
            .HasColumnName("uuid")
            .HasColumnType("uuid")
            .HasValueGenerator<GuidValueGenerator>()
            .ValueGeneratedOnAdd();

        builder
            .Property(x => x.CriadoEm)
            .IsRequired()
            .HasColumnName("criado_em")
            .HasColumnType("timestamptz")
            .HasDefaultValueSql("now()")
            .ValueGeneratedOnAdd();

        builder.Property(x => x.Telefones)
            .IsRequired()
            .HasColumnName("telefones")
            .HasColumnType("varchar(11)[]");

        builder.Property(x => x.Categorias)
            .IsRequired()
            .HasColumnName("categorias")
            .HasColumnType("categorias_enum[]");

        builder
            .Property(x => x.AtualizadoEm)
            .IsRequired()
            .HasColumnName("atualizado_em")
            .HasColumnType("timestamptz")
            .HasDefaultValueSql("now()")
            .ValueGeneratedOnAddOrUpdate();

        builder
            .Property(x => x.Nome)
            .IsRequired()
            .HasColumnName("nome")
            .HasColumnType("varchar(80)")
            .HasMaxLength(80);

        builder
            .HasOne(x => x.Account)
            .WithOne(x => x.Contato)
            .HasConstraintName("fk_contato_account")
            .HasForeignKey<Account>(x => new { x.ContatoId })
            .OnDelete(DeleteBehavior.SetNull);
    }
}