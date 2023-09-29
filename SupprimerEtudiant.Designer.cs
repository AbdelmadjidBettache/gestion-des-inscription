namespace ProjetFinal
{
    partial class SupprimerEtudiant
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SupprimerEtudiant));
            btn_Retour = new Button();
            btn_Annuler = new Button();
            btn_Supprimer = new Button();
            textBox_Email = new TextBox();
            textBox_Prenom = new TextBox();
            textBox_Nom = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBox_Ddn = new TextBox();
            button1 = new Button();
            textBox_CodeProgramme = new TextBox();
            pictureBox1 = new PictureBox();
            textBox_CodePermanent = new TextBox();
            errorProvider_CodeEtudiant = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider_CodeEtudiant).BeginInit();
            SuspendLayout();
            // 
            // btn_Retour
            // 
            btn_Retour.Font = new Font("Cascadia Code", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Retour.Location = new Point(369, 308);
            btn_Retour.Name = "btn_Retour";
            btn_Retour.Size = new Size(126, 37);
            btn_Retour.TabIndex = 37;
            btn_Retour.Text = "Retour";
            btn_Retour.UseVisualStyleBackColor = true;
            btn_Retour.Click += Btn_Retour_Click;
            // 
            // btn_Annuler
            // 
            btn_Annuler.Font = new Font("Cascadia Code", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Annuler.Location = new Point(202, 308);
            btn_Annuler.Name = "btn_Annuler";
            btn_Annuler.Size = new Size(126, 37);
            btn_Annuler.TabIndex = 36;
            btn_Annuler.Text = "Annuler";
            btn_Annuler.UseVisualStyleBackColor = true;
            btn_Annuler.Click += btn_Annuler_Click;
            // 
            // btn_Supprimer
            // 
            btn_Supprimer.Font = new Font("Cascadia Code", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Supprimer.Location = new Point(36, 308);
            btn_Supprimer.Name = "btn_Supprimer";
            btn_Supprimer.Size = new Size(126, 37);
            btn_Supprimer.TabIndex = 35;
            btn_Supprimer.Text = "Supprimer";
            btn_Supprimer.UseVisualStyleBackColor = true;
            btn_Supprimer.Click += btn_Supprimer_Click;
            // 
            // textBox_Email
            // 
            textBox_Email.Font = new Font("Cascadia Code", 9F, FontStyle.Bold, GraphicsUnit.Point);
            textBox_Email.Location = new Point(258, 222);
            textBox_Email.Name = "textBox_Email";
            textBox_Email.ReadOnly = true;
            textBox_Email.Size = new Size(140, 25);
            textBox_Email.TabIndex = 32;
            // 
            // textBox_Prenom
            // 
            textBox_Prenom.Font = new Font("Cascadia Code", 9F, FontStyle.Bold, GraphicsUnit.Point);
            textBox_Prenom.Location = new Point(258, 156);
            textBox_Prenom.Name = "textBox_Prenom";
            textBox_Prenom.ReadOnly = true;
            textBox_Prenom.Size = new Size(136, 25);
            textBox_Prenom.TabIndex = 31;
            // 
            // textBox_Nom
            // 
            textBox_Nom.Font = new Font("Cascadia Code", 9F, FontStyle.Bold, GraphicsUnit.Point);
            textBox_Nom.Location = new Point(258, 123);
            textBox_Nom.Name = "textBox_Nom";
            textBox_Nom.ReadOnly = true;
            textBox_Nom.Size = new Size(136, 25);
            textBox_Nom.TabIndex = 30;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Cascadia Code", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(206, 23);
            label7.Name = "label7";
            label7.Size = new Size(338, 30);
            label7.TabIndex = 28;
            label7.Text = "Suppression d'un Étudiant";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Cascadia Code", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(39, 258);
            label6.Name = "label6";
            label6.Size = new Size(171, 40);
            label6.TabIndex = 27;
            label6.Text = "Code du programme \r\ninscrit : ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Cascadia Code", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(39, 231);
            label5.Name = "label5";
            label5.Size = new Size(108, 20);
            label5.TabIndex = 26;
            label5.Text = "Courriel : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cascadia Code", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(39, 192);
            label4.Name = "label4";
            label4.Size = new Size(189, 20);
            label4.TabIndex = 25;
            label4.Text = "Date de naissance : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cascadia Code", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(39, 159);
            label3.Name = "label3";
            label3.Size = new Size(216, 20);
            label3.TabIndex = 24;
            label3.Text = "Prénom de l'étudiant : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cascadia Code", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(39, 129);
            label2.Name = "label2";
            label2.Size = new Size(180, 20);
            label2.TabIndex = 23;
            label2.Text = "Nom de l'étudiant :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cascadia Code", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(39, 88);
            label1.Name = "label1";
            label1.Size = new Size(189, 20);
            label1.TabIndex = 22;
            label1.Text = "Code de l'étudiant :";
            // 
            // textBox_Ddn
            // 
            textBox_Ddn.Font = new Font("Cascadia Code", 9F, FontStyle.Bold, GraphicsUnit.Point);
            textBox_Ddn.Location = new Point(258, 189);
            textBox_Ddn.Name = "textBox_Ddn";
            textBox_Ddn.ReadOnly = true;
            textBox_Ddn.Size = new Size(140, 25);
            textBox_Ddn.TabIndex = 38;
            // 
            // button1
            // 
            button1.Font = new Font("Cascadia Code", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(411, 88);
            button1.Name = "button1";
            button1.Size = new Size(117, 29);
            button1.TabIndex = 39;
            button1.Text = "Rechercher";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btn_Rechercher_Click;
            // 
            // textBox_CodeProgramme
            // 
            textBox_CodeProgramme.Font = new Font("Cascadia Code", 9F, FontStyle.Bold, GraphicsUnit.Point);
            textBox_CodeProgramme.Location = new Point(258, 255);
            textBox_CodeProgramme.Name = "textBox_CodeProgramme";
            textBox_CodeProgramme.ReadOnly = true;
            textBox_CodeProgramme.Size = new Size(140, 25);
            textBox_CodeProgramme.TabIndex = 40;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(539, 88);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(227, 224);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 41;
            pictureBox1.TabStop = false;
            // 
            // textBox_CodePermanent
            // 
            textBox_CodePermanent.Location = new Point(258, 85);
            textBox_CodePermanent.Name = "textBox_CodePermanent";
            textBox_CodePermanent.Size = new Size(136, 27);
            textBox_CodePermanent.TabIndex = 42;
            // 
            // errorProvider_CodeEtudiant
            // 
            errorProvider_CodeEtudiant.ContainerControl = this;
            // 
            // SupprimerEtudiant
            // 
            AcceptButton = btn_Supprimer;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(778, 355);
            Controls.Add(textBox_CodePermanent);
            Controls.Add(pictureBox1);
            Controls.Add(textBox_CodeProgramme);
            Controls.Add(button1);
            Controls.Add(textBox_Ddn);
            Controls.Add(btn_Retour);
            Controls.Add(btn_Annuler);
            Controls.Add(btn_Supprimer);
            Controls.Add(textBox_Email);
            Controls.Add(textBox_Prenom);
            Controls.Add(textBox_Nom);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "SupprimerEtudiant";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inscription Collège - Supprimer Etudiant";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider_CodeEtudiant).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Retour;
        private Button btn_Annuler;
        private Button btn_Supprimer;
        private TextBox textBox_Email;
        private TextBox textBox_Prenom;
        private TextBox textBox_Nom;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBox_Ddn;
        private Button button1;
        private TextBox textBox_CodeProgramme;
        private PictureBox pictureBox1;
        private TextBox textBox_CodePermanent;
        private ErrorProvider errorProvider_CodeEtudiant;
    }
}