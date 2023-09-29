namespace ProjetFinal
{
    partial class ListeProgrammes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListeProgrammes));
            label7 = new Label();
            dataGridViewProgrammes = new DataGridView();
            CodeProgramme = new DataGridViewTextBoxColumn();
            Domaine = new DataGridViewTextBoxColumn();
            Nom = new DataGridViewTextBoxColumn();
            nbrHeures = new DataGridViewTextBoxColumn();
            btn_Retour = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProgrammes).BeginInit();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Cascadia Code", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(192, 24);
            label7.Name = "label7";
            label7.Size = new Size(448, 32);
            label7.TabIndex = 14;
            label7.Text = "Liste des Programmes du Collège";
            // 
            // dataGridViewProgrammes
            // 
            dataGridViewProgrammes.AllowUserToDeleteRows = false;
            dataGridViewProgrammes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProgrammes.Columns.AddRange(new DataGridViewColumn[] { CodeProgramme, Domaine, Nom, nbrHeures });
            dataGridViewProgrammes.Location = new Point(114, 133);
            dataGridViewProgrammes.Name = "dataGridViewProgrammes";
            dataGridViewProgrammes.ReadOnly = true;
            dataGridViewProgrammes.RowHeadersWidth = 51;
            dataGridViewProgrammes.RowTemplate.Height = 29;
            dataGridViewProgrammes.Size = new Size(630, 201);
            dataGridViewProgrammes.TabIndex = 15;
            // 
            // CodeProgramme
            // 
            CodeProgramme.HeaderText = "Code";
            CodeProgramme.MinimumWidth = 6;
            CodeProgramme.Name = "CodeProgramme";
            CodeProgramme.ReadOnly = true;
            CodeProgramme.Width = 125;
            // 
            // Domaine
            // 
            Domaine.HeaderText = "Domaine";
            Domaine.MinimumWidth = 6;
            Domaine.Name = "Domaine";
            Domaine.ReadOnly = true;
            Domaine.Width = 125;
            // 
            // Nom
            // 
            Nom.HeaderText = "Nom";
            Nom.MinimumWidth = 6;
            Nom.Name = "Nom";
            Nom.ReadOnly = true;
            Nom.Width = 200;
            // 
            // nbrHeures
            // 
            nbrHeures.HeaderText = "Nombre d'heures";
            nbrHeures.MinimumWidth = 6;
            nbrHeures.Name = "nbrHeures";
            nbrHeures.ReadOnly = true;
            nbrHeures.Width = 125;
            // 
            // btn_Retour
            // 
            btn_Retour.Font = new Font("Cascadia Code", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Retour.Location = new Point(339, 374);
            btn_Retour.Name = "btn_Retour";
            btn_Retour.Size = new Size(182, 53);
            btn_Retour.TabIndex = 16;
            btn_Retour.Text = "Retour";
            btn_Retour.UseVisualStyleBackColor = true;
            btn_Retour.Click += btn_Retour_Click;
            // 
            // ListeProgrammes
            // 
            AcceptButton = btn_Retour;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(840, 450);
            Controls.Add(btn_Retour);
            Controls.Add(dataGridViewProgrammes);
            Controls.Add(label7);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ListeProgrammes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inscription Collège - Lister Programmes";
            ((System.ComponentModel.ISupportInitialize)dataGridViewProgrammes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label7;
        private DataGridView dataGridViewProgrammes;
        private DataGridViewTextBoxColumn CodeProgramme;
        private DataGridViewTextBoxColumn Domaine;
        private DataGridViewTextBoxColumn Nom;
        private DataGridViewTextBoxColumn nbrHeures;
        private Button btn_Retour;
    }
}