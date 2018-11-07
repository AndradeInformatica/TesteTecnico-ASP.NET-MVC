using Microsoft.EntityFrameworkCore;
using TesteTecnico.ApplicationCore.Entity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TesteTecnico.Infrastructure.EntityConfig
{
    public class PersonConfiguration : IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> builder)
        {
            builder.ToTable("People");
            builder.HasKey(p => p.PersonId);
            builder.HasMany(p => p.Address)
                .WithOne(p => p.Person)
                .HasForeignKey(p => p.PersonId)
                .HasPrincipalKey(p => p.PersonId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(p => p.Customer)
                .WithOne(p => p.Person)
                .HasForeignKey<Customer>(p => p.CustomerId);

            builder.HasOne(p => p.PhysicalPerson)
                .WithOne(p => p.Person)
                .HasForeignKey<PhysicalPerson>(p => p.PhysicalPersonId);

            builder.HasOne(p => p.LegalPerson)
                .WithOne(p => p.Person)
                .HasForeignKey<LegalPerson>(p => p.LegalPersonId);
        }
    }
}
