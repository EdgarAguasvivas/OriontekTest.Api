using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OriontekTest.Data.Constants;
using OriontekTest.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OriontekTest.Data.Configurations
{
    class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.ToTable("Customer", Schemas.dbo);
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).HasColumnName("Name");
            builder.Property(x => x.LastName).HasColumnName("LastName");
            builder.Property(x => x.PhoneNumber).HasColumnName("PhoneNumber");
            builder.Property(x => x.Email).HasColumnName("Email");
            builder.Property(x => x.IsActive).HasColumnName("IsActive");
            builder.Property(x => x.CompanyId).HasColumnName("CompanyId");
            builder.HasOne(x => x.Company).WithMany(x => x.Customers).HasForeignKey(x => x.CompanyId);
        }
    }
}
