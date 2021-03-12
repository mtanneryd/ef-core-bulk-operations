// <auto-generated>
// ReSharper disable All

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Tanneryd.BulkOperations.EFCore.Tests
{
    // Composite
    public class CompositeConfiguration : IEntityTypeConfiguration<Composite>
    {
        public void Configure(EntityTypeBuilder<Composite> builder)
        {
            builder.ToTable("Composite", "dbo");
            builder.HasKey(x => x.NumberId).HasName("PK_dbo.Composite").IsClustered();

            builder.Property(x => x.NumberId).HasColumnName(@"NumberId").HasColumnType("bigint").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.UpdatedAt).HasColumnName(@"UpdatedAt").HasColumnType("datetime").IsRequired();
            builder.Property(x => x.UpdatedBy).HasColumnName(@"UpdatedBy").HasColumnType("nvarchar(max)").IsRequired(false);

            // Foreign keys
            builder.HasOne(a => a.Number).WithOne(b => b.Composite).HasForeignKey<Composite>(c => c.NumberId).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_dbo.Composite_dbo.Number_NumberId");

            builder.HasIndex(x => x.NumberId).HasName("IX_NumberId");
        }
    }

}
// </auto-generated>