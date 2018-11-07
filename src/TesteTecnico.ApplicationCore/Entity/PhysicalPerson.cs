using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TesteTecnico.ApplicationCore.Entity
{
    public class PhysicalPerson
    {
        [Key]
        [ForeignKey("Person")]
        public int PhysicalPersonId { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string RG { get; private set; }
        public string CPF { get; private set; }

        public Person Person { get; private set; }

        public PhysicalPerson() { }
    }
}