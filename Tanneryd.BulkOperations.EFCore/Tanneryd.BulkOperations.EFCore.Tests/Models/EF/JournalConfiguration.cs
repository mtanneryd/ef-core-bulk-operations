// <auto-generated>
// ReSharper disable All

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Tanneryd.BulkOperations.EFCore.Tests
{
    // Journal
    public class JournalConfiguration : IEntityTypeConfiguration<Journal>
    {
        public void Configure(EntityTypeBuilder<Journal> builder)
        {
            builder.ToTable("Journal", "dbo");
            builder.HasKey(x => x.Id).HasName("PK_dbo.Journal").IsClustered();

            builder.Property(x => x.Id).HasColumnName(@"PrimaryKey").HasColumnType("uniqueidentifier").IsRequired().ValueGeneratedNever();
        }
    }

}
// </auto-generated>
