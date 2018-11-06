using System.ComponentModel.DataAnnotations;

namespace TesteTecnico.ApplicationCore.Entity
{
    public class Address
    {
        [Key]
        public int AddressId { get; private set; }
        public string Street { get; private set; }
        public string Number { get; private set; }
        public string Complement { get; private set; }
        public string Neighborhood { get; private set; }
        public string City { get; private set; }
        public string ZipCode { get; private set; }
        public string State { get; private set; }

        public int PersonId { get; private set; }
        public virtual Person Person { get; private set; }

        public Address() { }
    }
}