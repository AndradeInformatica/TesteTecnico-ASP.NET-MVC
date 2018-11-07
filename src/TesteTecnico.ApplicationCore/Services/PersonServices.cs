using System.Collections.Generic;
using TesteTecnico.ApplicationCore.Entity;
using TesteTecnico.ApplicationCore.Interfaces.Repository;
using TesteTecnico.ApplicationCore.Interfaces.Services;

namespace TesteTecnico.ApplicationCore.Services
{
    public class PersonServices : IPersonServices
    {
        private readonly IPersonRepository _PersonRepository;

        public PersonServices(IPersonRepository personRepository)
        {
            _PersonRepository = personRepository;
        }

        public Person Add(Person obj)
        {
            return _PersonRepository.Add(obj);
        }

        public IEnumerable<Person> GetAllAsNoTracking()
        {
            return _PersonRepository.GetAllAsNoTracking();
        }

        public Person GetById(int id)
        {
            return _PersonRepository.GetById(id);
        }

        public void Remove(Person obj)
        {
            _PersonRepository.Remove(obj);
        }
    }
}
