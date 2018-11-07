using TesteTecnico.Infrastructure.Data;
using TesteTecnico.ApplicationCore.Entity;
using TesteTecnico.ApplicationCore.Interfaces.Repository;

namespace TesteTecnico.Infrastructure.Repository
{
    public class AddressRepository : EntityFrameworkRepository<Address>, IAddressRepository
    {
        public AddressRepository(TesteTecnicoContext context) : base (context)
        {
        }
    }
}
