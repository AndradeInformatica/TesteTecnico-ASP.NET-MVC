using Microsoft.EntityFrameworkCore;
using TesteTecnico.ApplicationCore.Entity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TesteTecnico.Infrastructure.EntityConfig
{
    public class PhysicalPersonConfiguration : IEntityTypeConfiguration<PhysicalPerson>
    {

        public void Configure(EntityTypeBuilder<PhysicalPerson> builder)
        {
            builder.ToTable("PhysicalsPeople");
            builder.HasKey(fp => fp.PhysicalPersonId);
            builder.Property(fp => fp.FirstName)
                .HasColumnType("varchar(25)")
                .IsRequired();

            builder.Property(fp => fp.LastName)
                .HasColumnType("varchar(25)")
                .IsRequired();

            builder.Property(fp => fp.CPF)
                .HasColumnType("varchar(14)")
                .IsRequired();

            builder.Property(fp => fp.RG)
                .HasColumnType("varchar(12)")
                .IsRequired();
        }
    }
}
