using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RotinaBackup.Data.Models;


namespace RotinaBackup.Data.Configurations
{
    public class BackupSettingsConfiguration : IEntityTypeConfiguration<BackupSettings>
    {
        public void Configure(EntityTypeBuilder<BackupSettings> builder)
        {
            builder.ToTable("BackupSettings");

            builder.Property(a => a.Id)
                .HasColumnName("Id")
                .HasColumnType("Identity");

            builder.Property(a => a.Caminho)
                .HasColumnName("Caminho")
                .HasColumnType("VARCHAR(MAX)")
                .IsRequired();
            


        }
    }
}
