namespace ProjetFinal
{
    partial class AjoutProgramme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AjoutProgramme));
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label7 = new Label();
            textBox_Code = new TextBox();
            textBox_Domaine = new TextBox();
            textBox_Nom = new TextBox();
            textBox_NbrHeures = new TextBox();
            btn_Ajouter = new Button();
            btn_Annuler = new Button();
            btn_Retour = new Button();
            errorProvider_ajoutProg = new ErrorProvider(components);
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)errorProvider_ajoutProg).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 138);
            label2.Name = "label2";
            label2.Size = new Size(153, 20);
            label2.TabIndex = 1;
            label2.Text = "Code Programme :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(39, 186);
            label3.Name = "label3";
            label3.Size = new Size(90, 20);
            label3.TabIndex = 2;
            label3.Text = "Domaine :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(39, 234);
            label4.Name = "label4";
            label4.Size = new Size(171, 20);
            label4.TabIndex = 3;
            label4.Text = "Nom du Programme :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(39, 283);
            label5.Name = "label5";
            label5.Size = new Size(162, 20);
            label5.TabIndex = 4;
            label5.Text = "Nombre d'heures :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Cascadia Code", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(229, 37);
            label7.Name = "label7";
            label7.Size = new Size(273, 30);
            label7.TabIndex = 13;
            label7.Text = "Ajout d'un Programme";
            // 
            // textBox_Code
            // 
            textBox_Code.Location = new Point(229, 135);
            textBox_Code.Name = "textBox_Code";
            textBox_Code.Size = new Size(125, 25);
            textBox_Code.TabIndex = 14;
            // 
            // textBox_Domaine
            // 
            textBox_Domaine.Location = new Point(229, 181);
            textBox_Domaine.Name = "textBox_Domaine";
            textBox_Domaine.Size = new Size(199, 25);
            textBox_Domaine.TabIndex = 15;
            // 
            // textBox_Nom
            // 
            textBox_Nom.Location = new Point(229, 231);
            textBox_Nom.Name = "textBox_Nom";
            textBox_Nom.Size = new Size(199, 25);
            textBox_Nom.TabIndex = 16;
            // 
            // textBox_NbrHeures
            // 
            textBox_NbrHeures.Location = new Point(229, 278);
            textBox_NbrHeures.Name = "textBox_NbrHeures";
            textBox_NbrHeures.Size = new Size(73, 25);
            textBox_NbrHeures.TabIndex = 17;
            // 
            // btn_Ajouter
            // 
            btn_Ajouter.Location = new Point(78, 332);
            btn_Ajouter.Name = "btn_Ajouter";
            btn_Ajouter.Size = new Size(132, 42);
            btn_Ajouter.TabIndex = 18;
            btn_Ajouter.Text = "Ajouter";
            btn_Ajouter.UseVisualStyleBackColor = true;
            btn_Ajouter.Click += btn_Ajouter_Click;
            // 
            // btn_Annuler
            // 
            btn_Annuler.Location = new Point(229, 332);
            btn_Annuler.Name = "btn_Annuler";
            btn_Annuler.Size = new Size(132, 42);
            btn_Annuler.TabIndex = 19;
            btn_Annuler.Text = "Annuler";
            btn_Annuler.UseVisualStyleBackColor = true;
            btn_Annuler.Click += btn_Annuler_Click;
            // 
            // btn_Retour
            // 
            btn_Retour.Location = new Point(377, 332);
            btn_Retour.Name = "btn_Retour";
            btn_Retour.Size = new Size(132, 42);
            btn_Retour.TabIndex = 20;
            btn_Retour.Text = "Retour";
            btn_Retour.UseVisualStyleBackColor = true;
            btn_Retour.Click += btn_Retour_Click;
            // 
            // errorProvider_ajoutProg
            // 
            errorProvider_ajoutProg.ContainerControl = this;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(552, 138);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(223, 227);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 21;
            pictureBox1.TabStop = false;
            // 
            // AjoutProgramme
            // 
            AcceptButton = btn_Ajouter;
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(787, 407);
            Controls.Add(pictureBox1);
            Controls.Add(btn_Retour);
            Controls.Add(btn_Annuler);
            Controls.Add(btn_Ajouter);
            Controls.Add(textBox_NbrHeures);
            Controls.Add(textBox_Nom);
            Controls.Add(textBox_Domaine);
            Controls.Add(textBox_Code);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Font = new Font("Cascadia Code", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AjoutProgramme";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inscription Collège - Ajout programme";
            ((System.ComponentModel.ISupportInitialize)errorProvider_ajoutProg).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label7;
        private TextBox textBox_Code;
        private TextBox textBox_Domaine;
        private TextBox textBox_Nom;
        private TextBox textBox_NbrHeures;
        private Button btn_Ajouter;
        private Button btn_Annuler;
        private Button btn_Retour;
        private ErrorProvider errorProvider_ajoutProg;
        private PictureBox pictureBox1;
    }
}