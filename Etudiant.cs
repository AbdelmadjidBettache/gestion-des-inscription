using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetFinal
{
    public class Etudiant
    {
        private string codePermanent;
        private string nom;
        private string prenom;
        private DateTime ddn;
        private string email;
        private Programme programme;

        public Etudiant(string codePermanent, string nom, string prenom, DateTime ddn, string email, Programme programme)
        {
            this.codePermanent = codePermanent;
            this.nom = nom;
            this.prenom = prenom;
            this.ddn = ddn;
            this.email = email;
            this.programme = programme;
        }

        public string CodePermanent { get => codePermanent; set => codePermanent = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public DateTime Ddn { get => ddn; set => ddn = value; }
        public string Email { get => email; set => email = value; }
        public Programme Programme { get => programme; set => programme = value; }
    }
}
