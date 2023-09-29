namespace ProjetFinal
{
    public partial class AuthentificationForm : Form
    {
        private Administration administration;
        private MainForm? mainForm; // Ajout d'une référence au formulaire MainForm
        public AuthentificationForm(Administration administration)
        {
            InitializeComponent();
            this.administration = administration;
        }

        private void button_Connexion_Click(object sender, EventArgs e)
        {
            string username = textBox_User.Text;
            string password = textBox_Pwd.Text;

            // Réinitialiser les erreurs
            errorProvider_Login.Clear();

            // Validation du champ username
            if (string.IsNullOrWhiteSpace(username))
            {
                errorProvider_Login.SetError(textBox_User, "Veuillez saisir un nom d'utilisateur.");
                textBox_User.Focus();
                return;
            }

            // Validation du champ password
            if (string.IsNullOrWhiteSpace(password))
            {
                errorProvider_Login.SetError(textBox_Pwd, "Veuillez saisir un mot de passe.");
                textBox_Pwd.Focus();
                return;
            }

            if (estAuthentifie(username, password))
            {
                
                // Authentification réussie, ouvrir le formulaire principal et cacher le formulaire d'authentification
                mainForm = new MainForm();
                mainForm.FormClosed += MainForm_FormClosed; // Attacher le gestionnaire d'événement
                this.Hide(); // Cacher le formulaire d'authentification
                mainForm.Show(); // Afficher le formulaire principal

            }
            else
            {
                MessageBox.Show("Nom d'utilisateur ou mot de passe incorrect.", "Erreur d'authentification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_User.Focus();
            }
        }
        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainForm = null; // Réinitialiser la référence au formulaire principal
            this.Show(); // Afficher à nouveau le formulaire d'authentification lorsque le formulaire principal est fermé
        }

        private void button_Quitter_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Voulez-vous vraiment quitter ?", "Confirmation de sortie", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Merci d'avoir utilisé l'application. Au revoir !", "Au revoir", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
        private bool estAuthentifie(string username, string password)
        {
            bool authentifie = false;
            for (int i = 0; i < administration.Agents.Count; i++)
            {
                if (administration.Agents[i].Username.Equals(username) && administration.Agents[i].Password.Equals(password))
                {
                    authentifie = true;
                }
            }
            return authentifie;
        }
    }
}