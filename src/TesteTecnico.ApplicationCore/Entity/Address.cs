using System.ComponentModel.DataAnnotations;

namespace TesteTecnico.ApplicationCore.Entity
{
    public class Address
    {
        [Key]
        public int AddressId { get; protected set; }
        public string Street { get; protected set; }
        public string Number { get; protected set; }
        public string Complement { get; protected set; }
        public string Neighborhood { get; protected set; }
        public string City { get; protected set; }
        public string ZipCode { get; protected set; }
        public string State { get; protected set; }

        public Address() { }
    }
}