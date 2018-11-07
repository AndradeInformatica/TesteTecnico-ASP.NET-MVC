using System.Collections.Generic;
using TesteTecnico.ApplicationCore.Entity;
using TesteTecnico.ApplicationCore.Interfaces.Repository;
using TesteTecnico.ApplicationCore.Interfaces.Services;

namespace TesteTecnico.ApplicationCore.Services
{
    public class PhysicalPersonServices : IPhysicalPersonServices
    {
        private readonly IPhysicalPersonRepository _PhysicalPersonRepository;

        public PhysicalPersonServices(IPhysicalPersonRepository physicalPersonRepository)
        {
            _PhysicalPersonRepository = physicalPersonRepository;
        }

        public PhysicalPerson Add(PhysicalPerson obj)
        {
            return _PhysicalPersonRepository.Add(obj);
        }

        public IEnumerable<PhysicalPerson> GetAllAsNoTracking()
        {
            return _PhysicalPersonRepository.GetAllAsNoTracking();
        }

        public PhysicalPerson GetById(int id)
        {
            return _PhysicalPersonRepository.GetById(id);
        }

        public void Remove(PhysicalPerson obj)
        {
            _PhysicalPersonRepository.Remove(obj);
        }

        public void Update(PhysicalPerson obj)
        {
            _PhysicalPersonRepository.Update(obj);
        }
    }
}
