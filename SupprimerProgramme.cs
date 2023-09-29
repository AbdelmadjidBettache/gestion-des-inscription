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
    public partial class SupprimerProgramme : Form
    {
        Administration administration;
        public SupprimerProgramme(Administration administration)
        {
            InitializeComponent();
            this.administration = administration;
        }

        private void btn_Rechercher_Click(object sender, EventArgs e)
        {
            // validation du champ code programme non vide
            errorProvider_CodeProgramme.Clear();
            if (string.IsNullOrWhiteSpace(textBox_CodeProgramme.Text))
            {
                errorProvider_CodeProgramme.SetError(textBox_CodeProgramme, "Veuillez saisir un code programme.");
                textBox_CodeProgramme.Focus();
                return;
            }
            errorProvider_CodeProgramme.Clear();
            int index = rechercherCode(textBox_CodeProgramme.Text);
            if (index != -1)
            {
                textBox_Domaine.Text = administration.Programmes[index].Domaine;
                textBox_Nom.Text = administration.Programmes[index].Nom;
                textBox_NbrHeures.Text = administration.Programmes[index].NbrHeures.ToString();
            }
            else
            {
                MessageBox.Show("Ce code n'existe pas. veuillez en saisr un autre.", "Erreur de saisie", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_CodeProgramme.Focus();
            }

        }

        private void btn_Supprimer_Click(object sender, EventArgs e)
        {
            textBox_CodeProgramme.Focus();


            int index = rechercherCode(textBox_CodeProgramme.Text);
            if (index != -1)
            {
                // Vérifier si des étudiants sont inscrits à ce programme
                List<Etudiant> etudiantsAsupprimer = new List<Etudiant>();
                for (int i = 0; i < administration.Etudiants.Count; i++)
                {
                    if (administration.Etudiants[i].Programme.CodeProgramme.Equals(textBox_CodeProgramme.Text))
                    {
                        etudiantsAsupprimer.Add(administration.Etudiants[i]);
                    }
                }
                if (etudiantsAsupprimer.Count > 0)
                {
                    DialogResult result = MessageBox.Show("Certains étudiants sont inscrits à ce programme. Voulez-vous supprimer également les étudiants associés ?",
                        "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        // Supprimer les étudiants inscrits à ce programme
                        foreach (Etudiant etudiant in etudiantsAsupprimer)
                        {
                            administration.SupprimerEtudiant(etudiant);
                            MessageBox.Show("Les étudiants ont été supprimé avec succès!", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        administration.Programmes.RemoveAt(index);
                        MessageBox.Show("Le programme a été supprimé avec succès!", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        initialiserChamps();
                        textBox_CodeProgramme.Focus();
                    }
                }
                else
                {
                    administration.Programmes.RemoveAt(index);
                    MessageBox.Show("Le programme a été supprimé avec succès!", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    initialiserChamps();
                    textBox_CodeProgramme.Focus();
                }
            }

        }

        private void btn_Annuler_Click(object sender, EventArgs e)
        {
            initialiserChamps();
        }

        private void btn_Retour_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void initialiserChamps()
        {
            textBox_CodeProgramme.Text = "";
            textBox_Domaine.Text = "";
            textBox_Nom.Text = "";
            textBox_NbrHeures.Text = "";
        }
        private int rechercherCode(string codeProgramme)
        {
            int index = -1;
            for (int i = 0; i < administration.Programmes.Count; i++)
            {
                if (administration.Programmes[i].CodeProgramme.Equals(codeProgramme))
                {
                    index = i;
                }
            }
            return index;
        }
    }
}
