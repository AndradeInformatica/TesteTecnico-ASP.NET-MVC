using Microsoft.EntityFrameworkCore;
using TesteTecnico.ApplicationCore.Entity;
using TesteTecnico.Infrastructure.EntityConfig;

namespace TesteTecnico.Infrastructure.Data
{
    public class TesteTecnicoContext : DbContext
    {
        public TesteTecnicoContext(DbContextOptions<TesteTecnicoContext> options) : base(options) { }

        public DbSet<Person> People { get; private set; }
        public DbSet<Customer> Customers { get; private set; }
        public DbSet<PhysicalPerson> PhysicalsPeople { get; private set; }
        public DbSet<LegalPerson> LegalsPeople { get; private set; }
        public DbSet<TypePerson> TypesPeople { get; private set; }
        public DbSet<Address> Addresses { get; private set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Person>().ToTable("People");
            modelBuilder.Entity<Customer>().ToTable("Customers");
            modelBuilder.Entity<PhysicalPerson>().ToTable("PhisicalsPeople");
            modelBuilder.Entity<LegalPerson>().ToTable("LegalPeople");
            modelBuilder.Entity<TypePerson>().ToTable("TypesPeople");
            modelBuilder.Entity<Address>().ToTable("Addresses");

            modelBuilder.ApplyConfiguration(new PersonConfiguration());
            modelBuilder.ApplyConfiguration(new CustomerConfiguration());
            modelBuilder.ApplyConfiguration(new PhysicalPersonConfiguration());
            modelBuilder.ApplyConfiguration(new LegalPersonConfiguration());
            modelBuilder.ApplyConfiguration(new TypePersonConfiguration());
            modelBuilder.ApplyConfiguration(new AddressConfiguration());
        }
    }
}
