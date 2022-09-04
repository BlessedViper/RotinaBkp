using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RotinaBackup.Data.Models;

namespace RotinaBackup.Data.Configurations
{
    public class ServerConfiguration : IEntityTypeConfiguration<Server>
    {
        public void Configure(EntityTypeBuilder<Server> builder)
        {
            builder.ToTable("Server");

            builder.Property(a => a.Id)
                .HasColumnName("Id");

            builder.Property(a => a.Instancia)
                .HasColumnName("Instancia")
                .HasColumnType("VARCHAR(MAX)");

            builder.Property(a => a.Banco)
                .HasColumnName("Banco")
                .HasColumnType("VARCHAR(MAX)");

            builder.Property(a => a.Usuario)
                .HasColumnName("Usuario")
                .HasColumnType("VARCHAR(MAX)");

            builder.Property(a => a.Pass)
                .HasColumnName("Password")
                .HasColumnType("VARCHAR(MAX)");

            builder.Property(a => a.IdSettings)
                .HasColumnName("IdSettings")
                .HasColumnType("int")
                .IsRequired();

            builder
                .HasOne(a => a.Settings)
                .WithMany()
                .HasForeignKey(a => a.IdSettings);
        }

    }
}
