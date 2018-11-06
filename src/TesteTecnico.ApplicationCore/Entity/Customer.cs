using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TesteTecnico.ApplicationCore.Entity
{
    public class Customer
    {
        [Key]
        [ForeignKey("Person")]
        public int CustomerId { get; protected set; }

        public virtual Person Person { get; protected set; }

        public Customer() { }
    }
}