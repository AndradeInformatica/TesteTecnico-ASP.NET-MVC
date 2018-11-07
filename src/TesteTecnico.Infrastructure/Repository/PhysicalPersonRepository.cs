using TesteTecnico.Infrastructure.Data;
using TesteTecnico.ApplicationCore.Entity;
using TesteTecnico.ApplicationCore.Interfaces.Repository;

namespace TesteTecnico.Infrastructure.Repository
{
    public class PhysicalPersonRepository : EntityFrameworkRepository<PhysicalPerson>, IPhysicalPersonRepository
    {
        public PhysicalPersonRepository(TesteTecnicoContext context) : base (context)
        {
        }
    }
}
