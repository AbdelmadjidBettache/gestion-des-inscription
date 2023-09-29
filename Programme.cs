using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetFinal
{
    public class Programme
    {
        private string codeProgramme = "";
        private string domaine = "";
        private string nom = "";
        private double nbrHeures=0;

        public Programme(string codeProgramme, string domaine, string nom, double nbrHeures)
        {
            this.CodeProgramme = codeProgramme;
            this.Domaine = domaine;
            this.Nom = nom;
            this.NbrHeures = nbrHeures;
        }

        public string CodeProgramme { get => codeProgramme; set => codeProgramme = value; }
        public string Domaine { get => domaine; set => domaine = value; }
        public string Nom { get => nom; set => nom = value; }
        public double NbrHeures { get => nbrHeures; set => nbrHeures = value; }
    }
}
