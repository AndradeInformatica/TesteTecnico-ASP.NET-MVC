using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TesteTecnico.ApplicationCore.Entity
{
    public class PhysicalPerson
    {
        [Key]
        [ForeignKey("Person")]
        public int PhysicalPersonId { get; protected set; }
        public string FirstName { get; protected set; }
        public string LastName { get; protected set; }
        public string RG { get; protected set; }
        public string CPF { get; protected set; }

        public virtual Person Person { get; protected set; }

        public PhysicalPerson() { }
    }
}