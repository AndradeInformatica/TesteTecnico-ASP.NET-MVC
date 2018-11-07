using System.Collections.Generic;
using TesteTecnico.ApplicationCore.Entity;

namespace TesteTecnico.ApplicationCore.Interfaces.Services
{
    public interface ICustomerServices
    {
        Customer Add(Customer obj);
        void Remove(Customer obj);
        Customer GetById(int id);
        IEnumerable<Customer> GetAllAsNoTracking();
    }
}
