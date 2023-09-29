namespace ProjetFinal
{
    partial class ListeEtudiants
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListeEtudiants));
            textBox_Email = new TextBox();
            textBox_Prenom = new TextBox();
            textBox_Nom = new TextBox();
            textBox_CodePermanent = new TextBox();
            label_Titre = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btn_Retour = new Button();
            btn_Premier = new Button();
            btn_Precedant = new Button();
            btn_Suivant = new Button();
            btn_Dernier = new Button();
            textBox_CodeProgramme = new TextBox();
            textBox_Ddn = new TextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBox_Email
            // 
            textBox_Email.Font = new Font("Cascadia Code", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_Email.Location = new Point(245, 327);
            textBox_Email.Name = "textBox_Email";
            textBox_Email.ReadOnly = true;
            textBox_Email.Size = new Size(257, 25);
            textBox_Email.TabIndex = 29;
            // 
            // textBox_Prenom
            // 
            textBox_Prenom.Font = new Font("Cascadia Code", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_Prenom.Location = new Point(245, 212);
            textBox_Prenom.Name = "textBox_Prenom";
            textBox_Prenom.ReadOnly = true;
            textBox_Prenom.Size = new Size(257, 25);
            textBox_Prenom.TabIndex = 28;
            // 
            // textBox_Nom
            // 
            textBox_Nom.Font = new Font("Cascadia Code", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_Nom.Location = new Point(245, 162);
            textBox_Nom.Name = "textBox_Nom";
            textBox_Nom.ReadOnly = true;
            textBox_Nom.Size = new Size(257, 25);
            textBox_Nom.TabIndex = 27;
            // 
            // textBox_CodePermanent
            // 
            textBox_CodePermanent.Font = new Font("Cascadia Code", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_CodePermanent.Location = new Point(245, 114);
            textBox_CodePermanent.Name = "textBox_CodePermanent";
            textBox_CodePermanent.ReadOnly = true;
            textBox_CodePermanent.Size = new Size(257, 25);
            textBox_CodePermanent.TabIndex = 26;
            // 
            // label_Titre
            // 
            label_Titre.AutoSize = true;
            label_Titre.Font = new Font("Cascadia Code", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label_Titre.Location = new Point(107, 27);
            label_Titre.Name = "label_Titre";
            label_Titre.Size = new Size(448, 32);
            label_Titre.TabIndex = 25;
            label_Titre.Text = "Liste des  Étudiants du Collège";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Cascadia Code", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(26, 384);
            label6.Name = "label6";
            label6.Size = new Size(171, 40);
            label6.TabIndex = 24;
            label6.Text = "Code du programme \r\ninscrit : ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Cascadia Code", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(26, 336);
            label5.Name = "label5";
            label5.Size = new Size(108, 20);
            label5.TabIndex = 23;
            label5.Text = "Courriel : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cascadia Code", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(26, 280);
            label4.Name = "label4";
            label4.Size = new Size(189, 20);
            label4.TabIndex = 22;
            label4.Text = "Date de naissance : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cascadia Code", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(26, 221);
            label3.Name = "label3";
            label3.Size = new Size(216, 20);
            label3.TabIndex = 21;
            label3.Text = "Prénom de l'étudiant : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cascadia Code", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(26, 168);
            label2.Name = "label2";
            label2.Size = new Size(180, 20);
            label2.TabIndex = 20;
            label2.Text = "Nom de l'étudiant :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cascadia Code", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(26, 114);
            label1.Name = "label1";
            label1.Size = new Size(189, 20);
            label1.TabIndex = 19;
            label1.Text = "Code de l'étudiant :";
            // 
            // btn_Retour
            // 
            btn_Retour.Font = new Font("Cascadia Code", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Retour.Location = new Point(334, 434);
            btn_Retour.Name = "btn_Retour";
            btn_Retour.Size = new Size(126, 37);
            btn_Retour.TabIndex = 33;
            btn_Retour.Text = "Retour";
            btn_Retour.UseVisualStyleBackColor = true;
            btn_Retour.Click += btn_Retour_Click;
            // 
            // btn_Premier
            // 
            btn_Premier.Font = new Font("Cascadia Code", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Premier.Location = new Point(595, 240);
            btn_Premier.Name = "btn_Premier";
            btn_Premier.Size = new Size(108, 39);
            btn_Premier.TabIndex = 34;
            btn_Premier.Text = "Premier";
            btn_Premier.UseVisualStyleBackColor = true;
            btn_Premier.Click += btn_Premier_Click;
            // 
            // btn_Precedant
            // 
            btn_Precedant.Font = new Font("Cascadia Code", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Precedant.Location = new Point(595, 286);
            btn_Precedant.Name = "btn_Precedant";
            btn_Precedant.Size = new Size(108, 39);
            btn_Precedant.TabIndex = 35;
            btn_Precedant.Text = "Précédant";
            btn_Precedant.UseVisualStyleBackColor = true;
            btn_Precedant.Click += btn_Precedant_Click;
            // 
            // btn_Suivant
            // 
            btn_Suivant.Font = new Font("Cascadia Code", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Suivant.Location = new Point(595, 331);
            btn_Suivant.Name = "btn_Suivant";
            btn_Suivant.Size = new Size(108, 39);
            btn_Suivant.TabIndex = 36;
            btn_Suivant.Text = "Suivant";
            btn_Suivant.UseVisualStyleBackColor = true;
            btn_Suivant.Click += btn_Suivant_Click;
            // 
            // btn_Dernier
            // 
            btn_Dernier.Font = new Font("Cascadia Code", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Dernier.Location = new Point(595, 376);
            btn_Dernier.Name = "btn_Dernier";
            btn_Dernier.Size = new Size(108, 39);
            btn_Dernier.TabIndex = 37;
            btn_Dernier.Text = "Dernier";
            btn_Dernier.UseVisualStyleBackColor = true;
            btn_Dernier.Click += btn_Dernier_Click;
            // 
            // textBox_CodeProgramme
            // 
            textBox_CodeProgramme.Enabled = false;
            textBox_CodeProgramme.Font = new Font("Cascadia Code", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_CodeProgramme.Location = new Point(245, 384);
            textBox_CodeProgramme.Name = "textBox_CodeProgramme";
            textBox_CodeProgramme.ReadOnly = true;
            textBox_CodeProgramme.Size = new Size(257, 25);
            textBox_CodeProgramme.TabIndex = 38;
            // 
            // textBox_Ddn
            // 
            textBox_Ddn.Font = new Font("Cascadia Code", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_Ddn.Location = new Point(245, 275);
            textBox_Ddn.Name = "textBox_Ddn";
            textBox_Ddn.ReadOnly = true;
            textBox_Ddn.Size = new Size(257, 25);
            textBox_Ddn.TabIndex = 39;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(564, 78);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(168, 156);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 40;
            pictureBox1.TabStop = false;
            // 
            // ListeEtudiants
            // 
            AcceptButton = btn_Retour;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(763, 483);
            Controls.Add(pictureBox1);
            Controls.Add(textBox_Ddn);
            Controls.Add(textBox_CodeProgramme);
            Controls.Add(btn_Dernier);
            Controls.Add(btn_Suivant);
            Controls.Add(btn_Precedant);
            Controls.Add(btn_Premier);
            Controls.Add(btn_Retour);
            Controls.Add(textBox_Email);
            Controls.Add(textBox_Prenom);
            Controls.Add(textBox_Nom);
            Controls.Add(textBox_CodePermanent);
            Controls.Add(label_Titre);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ListeEtudiants";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inscription Collège - Liste Étudiants";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox_Email;
        private TextBox textBox_Prenom;
        private TextBox textBox_Nom;
        private TextBox textBox_CodePermanent;
        private Label label_Titre;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btn_Retour;
        private Button btn_Premier;
        private Button btn_Precedant;
        private Button btn_Suivant;
        private Button btn_Dernier;
        private TextBox textBox_CodeProgramme;
        private TextBox textBox_Ddn;
        private PictureBox pictureBox1;
    }
}