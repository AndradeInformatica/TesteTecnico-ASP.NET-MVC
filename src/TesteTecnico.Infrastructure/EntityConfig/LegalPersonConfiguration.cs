using Microsoft.EntityFrameworkCore;
using TesteTecnico.ApplicationCore.Entity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TesteTecnico.Infrastructure.EntityConfig
{
    public class LegalPersonConfiguration : IEntityTypeConfiguration<LegalPerson>
    {
        public void Configure(EntityTypeBuilder<LegalPerson> builder)
        {
            builder.ToTable("LegalPeople");
            builder.HasKey(lp => lp.LegalPersonId);
            builder.Property(lp => lp.SocialName)
                .HasColumnType("varchar(60)")
                .IsRequired();

            builder.Property(lp => lp.FantasyName)
                .HasColumnType("varchar(25)")
                .IsRequired();
            builder.Property(lp => lp.CNPJ)
                .HasColumnType("varchar(18)")
                .IsRequired();

            builder.Property(lp => lp.StateRegistration)
                .HasColumnType("varchar(20)")
                .IsRequired();
        }
    }
}
