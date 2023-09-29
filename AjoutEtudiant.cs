using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetFinal
{
    public partial class AjoutEtudiant : Form
    {
        private Administration administration;

        public AjoutEtudiant(Administration administration)
        {
            this.administration = administration;
            InitializeComponent();
            comboBox_CodeProgramme.DataSource = administration.Programmes.ToList();
            comboBox_CodeProgramme.DisplayMember = "CodeProgramme";

        }

        private void btn_Retour_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Annuler_Click(object sender, EventArgs e)
        {
            initialiserChamps();
        }

        private void btn_Ajouter_Click(object sender, EventArgs e)
        {

            string nom = textBox_Nom.Text.Trim();
            string prenom = textBox_Prenom.Text.Trim();
            string email = textBox_Email.Text.Trim();


            DateTime dateNaissance = dateTimePicker_Ddn.Value;

            errorProvider_AjoutEtudiant.Clear();
            // validation du champ nom
            if (string.IsNullOrWhiteSpace(nom))
            {
                errorProvider_AjoutEtudiant.SetError(textBox_Nom, "Veuillez saisir un nom.");
                textBox_Nom.Focus();
                return;
            }

            // Validation du champ prénom
            if (string.IsNullOrWhiteSpace(prenom))
            {
                errorProvider_AjoutEtudiant.SetError(textBox_Prenom, "Veuillez saisir un prénom.");
                textBox_Prenom.Focus();
                return;
            }

            // Validation du champ email
            if (string.IsNullOrWhiteSpace(email))
            {
                errorProvider_AjoutEtudiant.SetError(textBox_Email, "Veuillez saisir une adresse email.");
                textBox_Email.Focus();
                return;
            }

            // Validation de l'email
            if (!IsValidEmail(email))
            {
                errorProvider_AjoutEtudiant.SetError(textBox_Email, "Veuillez saisir une adresse email valide.");
                textBox_Email.Focus();
                return;
            }

            // Réinitialiser les erreurs
            errorProvider_AjoutEtudiant.Clear();

            // creation du code de l'étudiant
            string codePermanent = nom.Substring(0, 3) + prenom.Substring(0, 1);

            Programme? programme = comboBox_CodeProgramme.SelectedItem as Programme;
            Etudiant nouvelEtudiant = new Etudiant(codePermanent, nom, prenom, dateNaissance, email, programme);
            administration.AjouterEtudiant(nouvelEtudiant);
            MessageBox.Show("L'étudiant a été ajouté avec succès!", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
            initialiserChamps();
        }
        public bool IsValidEmail(string email)
        {
            // Expression régulière pour la validation de l'adresse email
            string pattern = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$";

            // Vérifier si l'adresse email correspond au format valide
            bool isValid = Regex.IsMatch(email, pattern);

            return isValid;
        }
        private void initialiserChamps()
        {
            textBox_CodePermanent.Text = "";
            textBox_Nom.Text = "";
            textBox_Prenom.Text = "";
            dateTimePicker_Ddn.Value = DateTime.Now;
            textBox_Email.Text = "";
            comboBox_CodeProgramme.SelectedIndex = 0;
        }
    }
}
