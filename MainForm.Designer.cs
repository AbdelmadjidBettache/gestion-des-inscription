namespace ProjetFinal
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            menuStrip1 = new MenuStrip();
            programmeToolStripMenuItem = new ToolStripMenuItem();
            ajouterProgrammeToolStripMenuItem = new ToolStripMenuItem();
            supprimerProgrammeToolStripMenuItem = new ToolStripMenuItem();
            listerProgrammeToolStripMenuItem = new ToolStripMenuItem();
            etudiantToolStripMenuItem = new ToolStripMenuItem();
            ajouterEtudiantToolStripMenuItem = new ToolStripMenuItem();
            supprimerEtudiantToolStripMenuItem = new ToolStripMenuItem();
            listerEtudiantToolStripMenuItem = new ToolStripMenuItem();
            quitterToolStripMenuItem = new ToolStripMenuItem();
            label_Etud_Iscrits = new Label();
            label_Prog_Dispo = new Label();
            pictureBox1 = new PictureBox();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Cascadia Code", 9F, FontStyle.Regular, GraphicsUnit.Point);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { programmeToolStripMenuItem, etudiantToolStripMenuItem, quitterToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 2, 0, 2);
            menuStrip1.Size = new Size(825, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menu";
            // 
            // programmeToolStripMenuItem
            // 
            programmeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ajouterProgrammeToolStripMenuItem, supprimerProgrammeToolStripMenuItem, listerProgrammeToolStripMenuItem });
            programmeToolStripMenuItem.Name = "programmeToolStripMenuItem";
            programmeToolStripMenuItem.Size = new Size(104, 24);
            programmeToolStripMenuItem.Text = "Programme";
            // 
            // ajouterProgrammeToolStripMenuItem
            // 
            ajouterProgrammeToolStripMenuItem.Name = "ajouterProgrammeToolStripMenuItem";
            ajouterProgrammeToolStripMenuItem.Size = new Size(263, 26);
            ajouterProgrammeToolStripMenuItem.Text = "Ajouter Programme";
            ajouterProgrammeToolStripMenuItem.Click += ajouterProgrammeToolStripMenuItem_Click;
            // 
            // supprimerProgrammeToolStripMenuItem
            // 
            supprimerProgrammeToolStripMenuItem.Name = "supprimerProgrammeToolStripMenuItem";
            supprimerProgrammeToolStripMenuItem.Size = new Size(263, 26);
            supprimerProgrammeToolStripMenuItem.Text = "Supprimer Programme";
            supprimerProgrammeToolStripMenuItem.Click += supprimerProgrammeToolStripMenuItem_Click;
            // 
            // listerProgrammeToolStripMenuItem
            // 
            listerProgrammeToolStripMenuItem.Name = "listerProgrammeToolStripMenuItem";
            listerProgrammeToolStripMenuItem.Size = new Size(263, 26);
            listerProgrammeToolStripMenuItem.Text = "Lister Programme";
            listerProgrammeToolStripMenuItem.Click += listerProgrammeToolStripMenuItem_Click;
            // 
            // etudiantToolStripMenuItem
            // 
            etudiantToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ajouterEtudiantToolStripMenuItem, supprimerEtudiantToolStripMenuItem, listerEtudiantToolStripMenuItem });
            etudiantToolStripMenuItem.Name = "etudiantToolStripMenuItem";
            etudiantToolStripMenuItem.Size = new Size(95, 24);
            etudiantToolStripMenuItem.Text = "Etudiant";
            // 
            // ajouterEtudiantToolStripMenuItem
            // 
            ajouterEtudiantToolStripMenuItem.Name = "ajouterEtudiantToolStripMenuItem";
            ajouterEtudiantToolStripMenuItem.Size = new Size(254, 26);
            ajouterEtudiantToolStripMenuItem.Text = "Ajouter Etudiant";
            ajouterEtudiantToolStripMenuItem.Click += ajouterEtudiantToolStripMenuItem_Click;
            // 
            // supprimerEtudiantToolStripMenuItem
            // 
            supprimerEtudiantToolStripMenuItem.Name = "supprimerEtudiantToolStripMenuItem";
            supprimerEtudiantToolStripMenuItem.Size = new Size(254, 26);
            supprimerEtudiantToolStripMenuItem.Text = "Supprimer Etudiant";
            supprimerEtudiantToolStripMenuItem.Click += supprimerEtudiantToolStripMenuItem_Click;
            // 
            // listerEtudiantToolStripMenuItem
            // 
            listerEtudiantToolStripMenuItem.Name = "listerEtudiantToolStripMenuItem";
            listerEtudiantToolStripMenuItem.Size = new Size(254, 26);
            listerEtudiantToolStripMenuItem.Text = "Lister Etudiant";
            listerEtudiantToolStripMenuItem.Click += listerEtudiantToolStripMenuItem_Click;
            // 
            // quitterToolStripMenuItem
            // 
            quitterToolStripMenuItem.Font = new Font("Cascadia Code", 9F, FontStyle.Regular, GraphicsUnit.Point);
            quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            quitterToolStripMenuItem.Size = new Size(86, 24);
            quitterToolStripMenuItem.Text = "Quitter";
            quitterToolStripMenuItem.Click += quitterToolStripMenuItem_Click;
            // 
            // label_Etud_Iscrits
            // 
            label_Etud_Iscrits.AutoSize = true;
            label_Etud_Iscrits.Location = new Point(403, 157);
            label_Etud_Iscrits.Name = "label_Etud_Iscrits";
            label_Etud_Iscrits.Size = new Size(63, 20);
            label_Etud_Iscrits.TabIndex = 1;
            label_Etud_Iscrits.Text = "label1";
            // 
            // label_Prog_Dispo
            // 
            label_Prog_Dispo.AutoSize = true;
            label_Prog_Dispo.Location = new Point(403, 197);
            label_Prog_Dispo.Name = "label_Prog_Dispo";
            label_Prog_Dispo.Size = new Size(63, 20);
            label_Prog_Dispo.TabIndex = 2;
            label_Prog_Dispo.Text = "label2";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(23, 92);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(345, 185);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(825, 339);
            Controls.Add(pictureBox1);
            Controls.Add(label_Prog_Dispo);
            Controls.Add(label_Etud_Iscrits);
            Controls.Add(menuStrip1);
            Font = new Font("Cascadia Mono", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inscription Collège";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem programmeToolStripMenuItem;
        private ToolStripMenuItem ajouterProgrammeToolStripMenuItem;
        private ToolStripMenuItem supprimerProgrammeToolStripMenuItem;
        private ToolStripMenuItem listerProgrammeToolStripMenuItem;
        private ToolStripMenuItem etudiantToolStripMenuItem;
        private ToolStripMenuItem ajouterEtudiantToolStripMenuItem;
        private ToolStripMenuItem supprimerEtudiantToolStripMenuItem;
        private ToolStripMenuItem listerEtudiantToolStripMenuItem;
        private ToolStripMenuItem quitterToolStripMenuItem;
        private Label label_Etud_Iscrits;
        private Label label_Prog_Dispo;
        private PictureBox pictureBox1;
    }
}