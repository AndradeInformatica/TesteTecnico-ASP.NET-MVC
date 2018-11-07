using TesteTecnico.Infrastructure.Data;
using TesteTecnico.ApplicationCore.Entity;
using TesteTecnico.ApplicationCore.Interfaces.Repository;

namespace TesteTecnico.Infrastructure.Repository
{
    public class PersonRepository : EntityFrameworkRepository<Person>, IPersonRepository
    {
        public PersonRepository(TesteTecnicoContext context) : base (context)
        {
        }
    }
}
