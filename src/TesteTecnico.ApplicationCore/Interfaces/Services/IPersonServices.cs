using System.Collections.Generic;
using TesteTecnico.ApplicationCore.Entity;

namespace TesteTecnico.ApplicationCore.Interfaces.Services
{
    public interface IPersonServices
    {
        Person Add(Person obj);
        void Remove(Person obj);
        Person GetById(int id);
        IEnumerable<Person> GetAllAsNoTracking();
    }
}
