using System.Collections.Generic;
using TesteTecnico.ApplicationCore.Entity;
using TesteTecnico.ApplicationCore.Interfaces.Repository;
using TesteTecnico.ApplicationCore.Interfaces.Services;

namespace TesteTecnico.ApplicationCore.Services
{
    public class AddressServices : IAddressServices
    {
        private readonly IAddressRepository _AddressRepository;

        public AddressServices(IAddressRepository addressRepository)
        {
            _AddressRepository = addressRepository;
        }

        public Address Add(Address obj)
        {
            return _AddressRepository.Add(obj);
        }

        public IEnumerable<Address> GetAllAsNoTracking()
        {
            return _AddressRepository.GetAllAsNoTracking();
        }

        public Address GetById(int id)
        {
            return _AddressRepository.GetById(id);
        }

        public void Remove(Address obj)
        {
            _AddressRepository.Remove(obj);
        }

        public void Update(Address obj)
        {
            _AddressRepository.Update(obj);
        }
    }
}
