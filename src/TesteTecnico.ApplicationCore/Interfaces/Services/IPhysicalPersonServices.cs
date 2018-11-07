using System.Collections.Generic;
using TesteTecnico.ApplicationCore.Entity;

namespace TesteTecnico.ApplicationCore.Interfaces.Services
{
    public interface IPhysicalPersonServices
    {
        PhysicalPerson Add(PhysicalPerson obj);
        void Update(PhysicalPerson obj);
        void Remove(PhysicalPerson obj);
        PhysicalPerson GetById(int id);
        IEnumerable<PhysicalPerson> GetAllAsNoTracking();
    }
}
