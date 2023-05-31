using DapperBenchMark.Helpers;
using Microsoft.EntityFrameworkCore;

namespace DapperBenchMark.Models
{
  public partial class ColigadaFakeEFContext : DbContext
  {
    public DbSet<ColigadaFake> ColigadasFake { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseSqlServer(Utils.ConnectionString);
      //if (!optionsBuilder.IsConfigured)
      //  optionsBuilder.UseSqlServer(Utils.GetConnectionString());
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      modelBuilder.Entity<ColigadaFake>(entity =>
      {
        entity.HasKey(e => e.Id);

        entity.ToTable("ColigadaFake");

        entity.Property(e => e.Code)
            .HasColumnName("Code")
            .HasMaxLength(20)
            .ValueGeneratedNever();

        entity.Property(e => e.Description)
            .HasColumnName("Description")
            .IsUnicode(false);

        entity.Property(e => e.RecCreatedBy)
            .HasColumnName("RecCreatedBy")
            .HasMaxLength(50)
            .IsUnicode(false);

        entity.Property(e => e.RecCreatedOn)
            .HasColumnName("RecCreatedOn")
            .IsUnicode(false);
      });
    }
  }
}
