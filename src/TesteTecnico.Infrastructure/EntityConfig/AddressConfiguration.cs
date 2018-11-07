using Microsoft.EntityFrameworkCore;
using TesteTecnico.ApplicationCore.Entity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TesteTecnico.Infrastructure.EntityConfig
{
    public class AddressConfiguration : IEntityTypeConfiguration<Address>
    {

        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.ToTable("Addresses");
            builder.HasKey(a => a.AddressId);
            builder.Property(a => a.Street)
                .HasColumnName("Street")
                .HasColumnType("varchar(50)")
                .IsRequired();

            builder.Property(a => a.Number)
                .HasColumnName("Number")
                .HasColumnType("varchar(15)")
                .IsRequired();

            builder.Property(a => a.Complement)
                .HasColumnName("Complement")
                .HasColumnType("varchar(25)");

            builder.Property(a => a.Neighborhood)
                .HasColumnName("Neighborhood")
                .HasColumnType("varchar(30)")
                .IsRequired();

            builder.Property(a => a.City)
                .HasColumnName("City")
                .HasColumnType("varchar(40)")
                .IsRequired();

            builder.Property(a => a.ZipCode)
                .HasColumnName("ZipCode")
                .HasColumnType("varchar(9)")
                .IsRequired();

            builder.Property(a => a.State)
                .HasColumnName("State")
                .HasColumnType("char(2)")
                .IsRequired();

            builder.HasOne(a => a.Person)
                .WithMany(a => a.Address)
                .HasForeignKey(a => a.PersonId)
                .HasPrincipalKey(a => a.PersonId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
