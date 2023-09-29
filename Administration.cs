using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetFinal
{
    public class Administration
    {
        private List<Agent> agents;
        private List<Programme> programmes;
        private List<Etudiant> etudiants;

        

        public Administration()
        {
            agents = new List<Agent>();
            programmes = new List<Programme>();
            etudiants = new List<Etudiant>();
            initAgents();
        }
        public List<Agent> Agents { get => agents; set => agents = value; }
        public List<Programme> Programmes { get => programmes; set => programmes = value; }
        public List<Etudiant> Etudiants { get => etudiants; set => etudiants = value; }

        // Méthodes pour ajouter, supprimer, modifier les agents, les programmes et les étudiants

        public void initAgents()
        {
            Agents.Add(new Agent("A007", "007"));
        }
        
        public void SupprimerAgent(Agent agent)
        {
            Agents.Remove(agent);
        }

        // Autres méthodes pour la gestion des agents

        public void AjouterProgramme(Programme programme)
        {
            Programmes.Add(programme);
        }

        public void SupprimerProgramme(Programme programme)
        {
            Programmes.Remove(programme);
        }

        // Autres méthodes pour la gestion des programmes

        public void AjouterEtudiant(Etudiant etudiant)
        {
            Etudiants.Add(etudiant);
        }

        public void SupprimerEtudiant(Etudiant etudiant)
        {
            Etudiants.Remove(etudiant);
        }

        // Autres méthodes pour la gestion des étudiants

        // Autres fonctionnalités liées à l'administration

        // ...
    }
}

