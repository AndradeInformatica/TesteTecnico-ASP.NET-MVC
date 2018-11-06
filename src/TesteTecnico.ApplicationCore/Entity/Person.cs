using System.Collections.Generic;

namespace TesteTecnico.ApplicationCore.Entity
{
    public class Person
    {
        public int PersonId { get; private set; }
        public TypePerson TypePerson { get; private set; }

        public virtual Customer Customer { get; private set; }
        public virtual PhysicalPerson PhysicalPerson { get; private set; }
        public virtual LegalPerson LegalPerson { get; private set; }

        public IEnumerable<Address> Address { get; private set; }

        public Person()
        {
            Address = new HashSet<Address>();
        }
    }
}
