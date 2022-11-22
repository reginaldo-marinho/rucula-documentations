using Rucula.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class ContentEstrutureConfiguration : IEntityTypeConfiguration<ContentEstruture>
{
    public void Configure(EntityTypeBuilder<ContentEstruture> builder)
    {
        builder
        .HasKey(k => k.Guuid)
        .HasName("PrimaryKey_ContentEstrutureGuuid")
        .HasAnnotation("MaxLength",36);

        builder
            .Property(p => p.Next)
            .HasMaxLength(150);

        builder
            .Property(p => p.Previous)
            .HasMaxLength(150);

        builder
            .HasOne(h => h.ContentHTML)
            .WithOne(p => p.ContentEstruture)
            .HasForeignKey<ContentEstruture>(fk => fk.ContentFk);

        
    }
}