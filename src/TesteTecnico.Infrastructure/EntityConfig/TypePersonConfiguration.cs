using Microsoft.EntityFrameworkCore;
using TesteTecnico.ApplicationCore.Entity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TesteTecnico.Infrastructure.EntityConfig
{
    public class TypePersonConfiguration : IEntityTypeConfiguration<TypePerson>
    {

        public void Configure(EntityTypeBuilder<TypePerson> builder)
        {
            builder.ToTable("TypesPeople");
            builder.HasKey(tp => tp.TypePersonId);
            builder.Property(tp => tp.Description).HasColumnType("varchar(10)");
        }
    }
}
