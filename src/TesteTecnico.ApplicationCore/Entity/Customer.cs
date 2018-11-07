using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TesteTecnico.ApplicationCore.Entity
{
    public class Customer
    {
        [Key]
        [ForeignKey("Person")]
        public int CustomerId { get; private set; }

        public Person Person { get; private set; }

        public Customer() { }
    }
}