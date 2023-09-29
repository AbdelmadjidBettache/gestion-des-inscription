using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetFinal
{
    public partial class SupprimerEtudiant : Form
    {
        Administration administration;
        public SupprimerEtudiant(Administration administration)
        {
            InitializeComponent();
            this.administration = administration;
        }
        private int rechercherCode(string codeEtudiant)
        {
            int index = -1;
            for (int i = 0; i < administration.Etudiants.Count; i++)
            {
                if (administration.Etudiants[i].CodePermanent.Equals(codeEtudiant))
                {
                    index = i;
                }
            }
            return index;
        }

        private void btn_Rechercher_Click(object sender, EventArgs e)
        {
            // validation du champ code etudiant non vide
            errorProvider_CodeEtudiant.Clear();
            if (string.IsNullOrWhiteSpace(textBox_CodePermanent.Text))
            {
                errorProvider_CodeEtudiant.SetError(textBox_CodePermanent, "Veuillez saisir un code étudiant.");
                textBox_CodePermanent.Focus();
                return;
            }
            errorProvider_CodeEtudiant.Clear();

            // si code trouver afficher le reste
            int index = rechercherCode(textBox_CodePermanent.Text);
            if (index != -1)
            {
                textBox_Nom.Text = administration.Etudiants[index].Nom;
                textBox_Prenom.Text = administration.Etudiants[index].Prenom;
                textBox_Ddn.Text = administration.Etudiants[index].Ddn.ToShortDateString();
                textBox_Email.Text = administration.Etudiants[index].Email;
                textBox_CodeProgramme.Text = administration.Etudiants[index].Programme.CodeProgramme;
                textBox_CodePermanent.Focus();
            }
            else
            {
                MessageBox.Show("Ce code n'existe pas. veuillez en saisr un autre.", "Erreur de saisie", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_CodePermanent.Focus();
            }
        }

        private void btn_Supprimer_Click(object sender, EventArgs e)
        {
            int index = rechercherCode(textBox_CodePermanent.Text);
            if (index != -1)
            {
                administration.Etudiants.RemoveAt(index);
                MessageBox.Show("L'étudiant a été supprimé avec succès!", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                initialiserChamps();
                textBox_CodePermanent.Focus();

            }
        }

        private void btn_Annuler_Click(object sender, EventArgs e)
        {
            initialiserChamps();
        }

        private void Btn_Retour_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void initialiserChamps()
        {
            textBox_Nom.Text = "";
            textBox_Prenom.Text = "";
            textBox_Ddn.Text = "";
            textBox_Email.Text = "";
            textBox_CodeProgramme.Text = "";
            textBox_CodePermanent.Focus();
        }
    }
}
