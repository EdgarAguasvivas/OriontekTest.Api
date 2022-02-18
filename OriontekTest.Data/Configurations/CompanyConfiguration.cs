using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OriontekTest.Data.Constants;
using OriontekTest.Data.Entities;

namespace OriontekTest.Data.Configurations
{
    public class CompanyConfiguration : IEntityTypeConfiguration<Company>
    {
        public void Configure(EntityTypeBuilder<Company> builder)
        {
            builder.ToTable("Company", Schemas.dbo);
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).HasColumnName("Name");
            builder.Property(x => x.IsActive).HasColumnName("IsActive");
            builder.Property(x => x.CustomerId).HasColumnName("CustomerId");
            builder.HasMany(x => x.Customers).WithOne(x => x.Company);
        }
    }
}
