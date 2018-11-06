using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TesteTecnico.ApplicationCore.Entity
{
    public class LegalPerson
    {
        [Key]
        [ForeignKey("Person")]
        public int LegalPersonId { get; protected set; }
        public string SocialName { get; protected set; }
        public string FantasyName { get; protected set; }
        public string CNPJ { get; protected set; }
        public string StateRegistration { get; protected set; }

        public virtual Person Person { get; protected set; }

        public LegalPerson() { }
    }
}