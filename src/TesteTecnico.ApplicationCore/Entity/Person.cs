using System.Collections.Generic;

namespace TesteTecnico.ApplicationCore.Entity
{
    public class Person
    {
        public int PersonId { get; protected set; }
        public TypePerson TypePerson { get; protected set; }

        public virtual Customer Customer { get; protected set; }
        public virtual PhysicalPerson PhysicalPerson { get; protected set; }
        public virtual LegalPerson LegalPerson { get; protected set; }

        public IEnumerable<Address> Address { get; protected set; }

        public Person() { }
    }
}
