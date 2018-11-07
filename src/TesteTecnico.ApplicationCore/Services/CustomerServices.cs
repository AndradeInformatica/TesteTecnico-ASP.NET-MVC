using System.Collections.Generic;
using TesteTecnico.ApplicationCore.Entity;
using TesteTecnico.ApplicationCore.Interfaces.Repository;
using TesteTecnico.ApplicationCore.Interfaces.Services;

namespace TesteTecnico.ApplicationCore.Services
{
    public class CustomerServices : ICustomerServices
    {
        private readonly ICustomerRepository _CustomerRepository;

        public CustomerServices(ICustomerRepository customerRepository)
        {
            _CustomerRepository = customerRepository;
        }

        public Customer Add(Customer obj)
        {
            return _CustomerRepository.Add(obj);
        }

        public Customer GetById(int id)
        {
            return _CustomerRepository.GetById(id);
        }

        public IEnumerable<Customer> GetAllAsNoTracking()
        {
            return _CustomerRepository.GetAllAsNoTracking();
        }

        public void Remove(Customer obj)
        {
            _CustomerRepository.Remove(obj);
        }
    }
}
