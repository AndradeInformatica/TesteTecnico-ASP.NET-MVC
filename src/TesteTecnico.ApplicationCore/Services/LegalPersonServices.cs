using System.Collections.Generic;
using TesteTecnico.ApplicationCore.Entity;
using TesteTecnico.ApplicationCore.Interfaces.Repository;
using TesteTecnico.ApplicationCore.Interfaces.Services;

namespace TesteTecnico.ApplicationCore.Services
{
    public class LegalPersonServices : ILegalLegalPersonServices
    {
        private readonly ILegalPersonRepository _LegalPersonRepository;

        public LegalPersonServices(ILegalPersonRepository legalPersonRepository)
        {
            _LegalPersonRepository = legalPersonRepository;
        }

        public LegalPerson Add(LegalPerson obj)
        {
            return _LegalPersonRepository.Add(obj);
        }

        public IEnumerable<LegalPerson> GetAllAsNoTracking()
        {
            return _LegalPersonRepository.GetAllAsNoTracking();
        }

        public LegalPerson GetById(int id)
        {
            return _LegalPersonRepository.GetById(id);
        }

        public void Remove(LegalPerson obj)
        {
            _LegalPersonRepository.Remove(obj);
        }

        public void Update(LegalPerson obj)
        {
            _LegalPersonRepository.Update(obj);
        }
    }
}
