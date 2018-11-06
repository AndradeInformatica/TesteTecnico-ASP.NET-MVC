using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TesteTecnico.ApplicationCore.Entity
{
    public class LegalPerson
    {
        [Key]
        [ForeignKey("Person")]
        public int LegalPersonId { get; private set; }
        public string SocialName { get; private set; }
        public string FantasyName { get; private set; }
        public string CNPJ { get; private set; }
        public string StateRegistration { get; private set; }

        public virtual Person Person { get; private set; }

        public LegalPerson() { }
    }
}