using TesteTecnico.Infrastructure.Data;
using TesteTecnico.ApplicationCore.Entity;
using TesteTecnico.ApplicationCore.Interfaces.Repository;

namespace TesteTecnico.Infrastructure.Repository
{
    public class LegalPersonRepository : EntityFrameworkRepository<LegalPerson>, ILegalPersonRepository
    {
        public LegalPersonRepository(TesteTecnicoContext context) : base (context)
        {
        }
    }
}
