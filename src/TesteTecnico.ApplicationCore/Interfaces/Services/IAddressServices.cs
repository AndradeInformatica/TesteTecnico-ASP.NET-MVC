using System.Collections.Generic;
using TesteTecnico.ApplicationCore.Entity;

namespace TesteTecnico.ApplicationCore.Interfaces.Services
{
    public interface IAddressServices
    {
        Address Add(Address obj);
        void Update(Address obj);
        void Remove(Address obj);
        Address GetById(int id);
        IEnumerable<Address> GetAllAsNoTracking();
    }
}
