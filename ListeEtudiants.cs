using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetFinal
{

    public partial class ListeEtudiants : Form
    {
        List<Etudiant> etudiants;
        private int indexcourant;
        public ListeEtudiants(List<Etudiant> etudiants)
        {
            InitializeComponent();
            this.etudiants = etudiants;
            indexcourant = 0;
            afficherEtudiantCourant();
        }
        private void afficherEtudiantCourant()
        {
            if (indexcourant >= 0 && indexcourant < etudiants.Count)
            {

                Etudiant etudiantCourant = etudiants[indexcourant];
                if (etudiantCourant != null && etudiantCourant.Programme != null)
                {
                    textBox_CodePermanent.Text = etudiantCourant.CodePermanent;
                    textBox_Nom.Text = etudiantCourant.Nom;
                    textBox_Prenom.Text = etudiantCourant.Prenom;
                    textBox_Email.Text = etudiantCourant.Email;
                    textBox_Ddn.Text = etudiantCourant.Ddn.ToShortDateString();
                    textBox_CodeProgramme.Text = etudiantCourant.Programme.CodeProgramme;
                }
                else
                {
                    MessageBox.Show(" ici ");
                    textBox_CodePermanent.Text = "";
                    textBox_Nom.Text = "";
                    textBox_Prenom.Text = "";
                    textBox_Email.Text = "";
                    textBox_Ddn.Text = "";
                }

            }
        }

        private void btn_Retour_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Premier_Click(object sender, EventArgs e)
        {
            indexcourant = 0;
            afficherEtudiantCourant();
        }

        private void btn_Precedant_Click(object sender, EventArgs e)
        {
            if (indexcourant > 0)
            {
                indexcourant--;
                afficherEtudiantCourant();
            }

        }

        private void btn_Suivant_Click(object sender, EventArgs e)
        {
            if (indexcourant < etudiants.Count() - 1)
            {
                indexcourant++;
                afficherEtudiantCourant();
            }

        }

        private void btn_Dernier_Click(object sender, EventArgs e)
        {
            indexcourant = etudiants.Count() - 1;
            afficherEtudiantCourant();
        }
    }
}
