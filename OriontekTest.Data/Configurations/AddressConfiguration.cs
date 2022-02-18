using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OriontekTest.Data.Constants;
using OriontekTest.Data.Entities;

namespace OriontekTest.Data.Configurations
{
    class AddressConfiguration : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.ToTable("Address", Schemas.dbo);
            builder.HasKey(x => x.Id);
            builder.Property(x => x.AddressDescription).HasColumnName("Address");
            builder.Property(x => x.City).HasColumnName("City");
            builder.Property(x => x.Country).HasColumnName("Country");
            builder.Property(x => x.State).HasColumnName("State");
            builder.Property(x => x.IsActive).HasColumnName("IsActive");
            builder.Property(x => x.CustomerId).HasColumnName("CustomerId");
            builder.HasOne(x => x.Customer).WithMany(x => x.Addresses).HasForeignKey(x => x.CustomerId);
        }
    }
}
