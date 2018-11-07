using Microsoft.EntityFrameworkCore;
using TesteTecnico.ApplicationCore.Entity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TesteTecnico.Infrastructure.EntityConfig
{
    public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {

        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.ToTable("Customers");
            builder.HasKey(c => c.CustomerId);
        }
    }
}
