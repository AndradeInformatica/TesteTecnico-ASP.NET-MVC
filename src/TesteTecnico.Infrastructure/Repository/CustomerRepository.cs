using TesteTecnico.Infrastructure.Data;
using TesteTecnico.ApplicationCore.Entity;
using TesteTecnico.ApplicationCore.Interfaces.Repository;

namespace TesteTecnico.Infrastructure.Repository
{
    public class CustomerRepository : EntityFrameworkRepository<Customer>, ICustomerRepository
    {
        public CustomerRepository(TesteTecnicoContext context) : base (context)
        {
        }

        //public override Customer Add(Customer obj)
        //{
        //    Person person = new Person();
        //    _DbContext.Set<Person>().Add(person);

        //    _DbContext.Set<Customer>().Add(obj);
        //    _DbContext.SaveChanges();
        //    return obj;
        //}
    }
}
