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
    public partial class MainForm : Form
    {
        private Administration administration;
        public MainForm()
        {
            InitializeComponent();
            administration = new Administration();
            MettreAJourLabels();
        }

        private void ajouterEtudiantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AjoutEtudiant ajoutEtudiant = new AjoutEtudiant(administration);
            ajoutEtudiant.FormClosed += AjoutEtudiant_FormClosed; ;
            ajoutEtudiant.Show();
            this.Hide();
        }

        private void AjoutEtudiant_FormClosed(object? sender, FormClosedEventArgs e)
        {
            MettreAJourLabels();
            this.Show();
        }

        private void ajouterProgrammeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AjoutProgramme ajoutProgramme = new AjoutProgramme(administration);
            ajoutProgramme.FormClosed += AjoutProgramme_FormClosed;
            ajoutProgramme.Show();
            this.Hide();
        }

        private void AjoutProgramme_FormClosed(object? sender, FormClosedEventArgs e)
        {
            MettreAJourLabels();
            this.Show();
        }

        public void MettreAJourLabels()
        {
            label_Etud_Iscrits.Text = "Il y a " + administration.Etudiants.Count.ToString() + " étudiants inscrits au Collège.";
            label_Prog_Dispo.Text = "Il y a " + administration.Programmes.Count.ToString() + " porgrammes disponibles au Collège.";
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listerProgrammeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListeProgrammes listeProgrammesForm = new ListeProgrammes(administration.Programmes);
            listeProgrammesForm.FormClosed += ListeProgrammes_FormClosed;
            listeProgrammesForm.Show();
            this.Hide();
        }
        private void ListeProgrammes_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void listerEtudiantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListeEtudiants listeEtudiants = new ListeEtudiants(administration.Etudiants);
            listeEtudiants.FormClosed += ListeEtudiants_FormClosed;
            listeEtudiants.Show();
            this.Hide();
        }
        private void ListeEtudiants_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }
        private void supprimerProgrammeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SupprimerProgramme supprimerProgramme = new SupprimerProgramme(administration);

            supprimerProgramme.FormClosed += SupprimerProgramme_FormClosed;
            supprimerProgramme.Show();
            this.Hide();
        }



        private void SupprimerProgramme_FormClosed(object? sender, FormClosedEventArgs e)
        {
            MettreAJourLabels();
            this.Show();

        }

        private void supprimerEtudiantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SupprimerEtudiant supprimerEtudiant = new SupprimerEtudiant(administration);
            supprimerEtudiant.FormClosed += SupprimerEtudiant_FormClosed;
            supprimerEtudiant.Show();
            this.Hide();
        }
        private void SupprimerEtudiant_FormClosed(Object? sender, FormClosedEventArgs e)
        {
            MettreAJourLabels();
            this.Show();
        }
    }
}
