using System.Collections.Generic;
using TesteTecnico.ApplicationCore.Entity;

namespace TesteTecnico.ApplicationCore.Interfaces.Services
{
    public interface ILegalLegalPersonServices
    {
        LegalPerson Add(LegalPerson obj);
        void Update(LegalPerson obj);
        void Remove(LegalPerson obj);
        LegalPerson GetById(int id);
        IEnumerable<LegalPerson> GetAllAsNoTracking();
    }
}
