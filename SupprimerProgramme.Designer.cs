namespace ProjetFinal
{
    partial class SupprimerProgramme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SupprimerProgramme));
            textBox_NbrHeures = new TextBox();
            btn_Retour = new Button();
            btn_Annuler = new Button();
            textBox_Nom = new TextBox();
            textBox_Domaine = new TextBox();
            textBox_CodeProgramme = new TextBox();
            label_Titre = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btn_Rechercher = new Button();
            btn_Supprimer = new Button();
            pictureBox1 = new PictureBox();
            errorProvider_CodeProgramme = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider_CodeProgramme).BeginInit();
            SuspendLayout();
            // 
            // textBox_NbrHeures
            // 
            textBox_NbrHeures.Font = new Font("Cascadia Code", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_NbrHeures.Location = new Point(234, 200);
            textBox_NbrHeures.Name = "textBox_NbrHeures";
            textBox_NbrHeures.ReadOnly = true;
            textBox_NbrHeures.Size = new Size(98, 25);
            textBox_NbrHeures.TabIndex = 54;
            // 
            // btn_Retour
            // 
            btn_Retour.Font = new Font("Cascadia Code", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Retour.Location = new Point(390, 294);
            btn_Retour.Name = "btn_Retour";
            btn_Retour.Size = new Size(126, 37);
            btn_Retour.TabIndex = 52;
            btn_Retour.Text = "Retour";
            btn_Retour.UseVisualStyleBackColor = true;
            btn_Retour.Click += btn_Retour_Click;
            // 
            // btn_Annuler
            // 
            btn_Annuler.Font = new Font("Cascadia Code", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Annuler.Location = new Point(223, 294);
            btn_Annuler.Name = "btn_Annuler";
            btn_Annuler.Size = new Size(126, 37);
            btn_Annuler.TabIndex = 51;
            btn_Annuler.Text = "Annuler";
            btn_Annuler.UseVisualStyleBackColor = true;
            btn_Annuler.Click += btn_Annuler_Click;
            // 
            // textBox_Nom
            // 
            textBox_Nom.Font = new Font("Cascadia Code", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_Nom.Location = new Point(234, 169);
            textBox_Nom.Name = "textBox_Nom";
            textBox_Nom.ReadOnly = true;
            textBox_Nom.Size = new Size(325, 25);
            textBox_Nom.TabIndex = 49;
            // 
            // textBox_Domaine
            // 
            textBox_Domaine.Font = new Font("Cascadia Code", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_Domaine.Location = new Point(234, 138);
            textBox_Domaine.Name = "textBox_Domaine";
            textBox_Domaine.ReadOnly = true;
            textBox_Domaine.Size = new Size(325, 25);
            textBox_Domaine.TabIndex = 48;
            // 
            // textBox_CodeProgramme
            // 
            textBox_CodeProgramme.Font = new Font("Cascadia Code", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_CodeProgramme.Location = new Point(234, 104);
            textBox_CodeProgramme.Name = "textBox_CodeProgramme";
            textBox_CodeProgramme.Size = new Size(163, 25);
            textBox_CodeProgramme.TabIndex = 47;
            // 
            // label_Titre
            // 
            label_Titre.AutoSize = true;
            label_Titre.Font = new Font("Cascadia Code", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label_Titre.Location = new Point(169, 23);
            label_Titre.Name = "label_Titre";
            label_Titre.Size = new Size(378, 32);
            label_Titre.TabIndex = 46;
            label_Titre.Text = "Suppression d'un programme";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cascadia Code", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(15, 205);
            label4.Name = "label4";
            label4.Size = new Size(162, 20);
            label4.TabIndex = 43;
            label4.Text = "Nombre d'heures :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cascadia Code", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(15, 178);
            label3.Name = "label3";
            label3.Size = new Size(54, 20);
            label3.TabIndex = 42;
            label3.Text = "Nom :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cascadia Code", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(15, 144);
            label2.Name = "label2";
            label2.Size = new Size(90, 20);
            label2.TabIndex = 41;
            label2.Text = "Domaine :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cascadia Code", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(15, 104);
            label1.Name = "label1";
            label1.Size = new Size(180, 20);
            label1.TabIndex = 40;
            label1.Text = "Code du programme :";
            // 
            // btn_Rechercher
            // 
            btn_Rechercher.Location = new Point(422, 103);
            btn_Rechercher.Name = "btn_Rechercher";
            btn_Rechercher.Size = new Size(137, 29);
            btn_Rechercher.TabIndex = 55;
            btn_Rechercher.Text = "Rechercher";
            btn_Rechercher.UseVisualStyleBackColor = true;
            btn_Rechercher.Click += btn_Rechercher_Click;
            // 
            // btn_Supprimer
            // 
            btn_Supprimer.Font = new Font("Cascadia Code", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Supprimer.Location = new Point(56, 294);
            btn_Supprimer.Name = "btn_Supprimer";
            btn_Supprimer.Size = new Size(126, 37);
            btn_Supprimer.TabIndex = 56;
            btn_Supprimer.Text = "Supprimer";
            btn_Supprimer.UseVisualStyleBackColor = true;
            btn_Supprimer.Click += btn_Supprimer_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(593, 104);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(223, 227);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 57;
            pictureBox1.TabStop = false;
            // 
            // errorProvider_CodeProgramme
            // 
            errorProvider_CodeProgramme.ContainerControl = this;
            // 
            // SupprimerProgramme
            // 
            AcceptButton = btn_Supprimer;
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(839, 351);
            Controls.Add(pictureBox1);
            Controls.Add(btn_Supprimer);
            Controls.Add(btn_Rechercher);
            Controls.Add(textBox_NbrHeures);
            Controls.Add(btn_Retour);
            Controls.Add(btn_Annuler);
            Controls.Add(textBox_Nom);
            Controls.Add(textBox_Domaine);
            Controls.Add(textBox_CodeProgramme);
            Controls.Add(label_Titre);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Cascadia Code", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "SupprimerProgramme";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inscription Collège - Supprimer Programme";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider_CodeProgramme).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox_NbrHeures;
        private Button btn_Retour;
        private Button btn_Annuler;
        private TextBox textBox_Nom;
        private TextBox textBox_Domaine;
        private TextBox textBox_CodeProgramme;
        private Label label_Titre;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btn_Rechercher;
        private Button btn_Supprimer;
        private PictureBox pictureBox1;
        private ErrorProvider errorProvider_CodeProgramme;
    }
}