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
    public partial class AjoutProgramme : Form
    {

        private Administration administration;

        public AjoutProgramme(Administration administration)
        {
            InitializeComponent();
            this.administration = administration;
        }

        private void btn_Ajouter_Click(object sender, EventArgs e)
        {
            // récupération valeur des champs
            string code = textBox_Code.Text.Trim().ToLower();
            string domaine = textBox_Domaine.Text.Trim();
            string nom = textBox_Nom.Text.Trim();
            string heures = textBox_NbrHeures.Text.Trim();

            // validation champs non vide
            if (string.IsNullOrWhiteSpace(code))
            {
                errorProvider_ajoutProg.SetError(textBox_Code, "Veuillez saisir un code.");
                textBox_Code.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(domaine))
            {
                errorProvider_ajoutProg.SetError(textBox_Domaine, "Veuillez saisir un domaine.");
                textBox_Domaine.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(nom))
            {
                errorProvider_ajoutProg.SetError(textBox_Nom, "Veuillez saisir un nom.");
                textBox_Nom.Focus();
                return;
            }

            if (!heuresValide(heures))
            {
                errorProvider_ajoutProg.SetError(textBox_NbrHeures, "Veuillez saisir un nombre d'heures valide supérieur à zéro.");
                textBox_NbrHeures.Focus();
                textBox_NbrHeures.SelectAll();
                return;
            }

            // Réinitialiser les erreurs
            errorProvider_ajoutProg.Clear();

            // validation : si code trouvé : message erreur sinon ajouter
            if (trouveCode(code))
            {
                MessageBox.Show("Ce code existe déjà. veuillez en saisr un autre.", "Erreur de saisie", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_Code.Focus();
            }
            else if (!heuresValide(heures))
            {
                MessageBox.Show("Veuillez saisir un nombre d'heures valide supérieur à zéro.", "Erreur de saisie", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                double nbrHeures = Double.Parse(textBox_NbrHeures.Text);
                Programme nouveauProgramme = new Programme(code, domaine, nom, nbrHeures);
                administration.AjouterProgramme(nouveauProgramme);
                MessageBox.Show("Le programme a été ajouté avec succès!", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                initialiserChamps();
            }
        }

        private void btn_Retour_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Annuler_Click(object sender, EventArgs e)
        {
            initialiserChamps();
        }
        private bool trouveCode(string code)
        {
            bool codeExiste = false;
            if (administration.Programmes.Count != 0)
            {
                foreach (Programme programme in administration.Programmes)
                {
                    if (programme.CodeProgramme.Equals(code))
                    {
                        codeExiste = true; break;
                    }
                }
            }
            return codeExiste;
        }
        private bool heuresValide(string heuresText)
        {
            bool nombreValide = true;
            if (!double.TryParse(heuresText, out double heures) || heures <= 0)
            {
                nombreValide = false;
            }
            return nombreValide;
        }
        private void initialiserChamps()
        {
            textBox_Code.Text = "";
            textBox_Domaine.Text = "";
            textBox_Nom.Text = "";
            textBox_NbrHeures.Text = "";
        }
    }
}
