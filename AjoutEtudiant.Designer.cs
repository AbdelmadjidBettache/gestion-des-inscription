namespace ProjetFinal
{
    partial class AjoutEtudiant
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AjoutEtudiant));
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label7 = new Label();
            textBox_CodePermanent = new TextBox();
            textBox_Nom = new TextBox();
            textBox_Prenom = new TextBox();
            textBox_Email = new TextBox();
            dateTimePicker_Ddn = new DateTimePicker();
            comboBox_CodeProgramme = new ComboBox();
            btn_Ajouter = new Button();
            btn_Annuler = new Button();
            btn_Retour = new Button();
            pictureBox1 = new PictureBox();
            errorProvider_AjoutEtudiant = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider_AjoutEtudiant).BeginInit();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Cascadia Code", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(40, 276);
            label6.Name = "label6";
            label6.Size = new Size(190, 44);
            label6.TabIndex = 11;
            label6.Text = "Code du programme \r\ninscrit : ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Cascadia Code", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(40, 230);
            label5.Name = "label5";
            label5.Size = new Size(120, 22);
            label5.TabIndex = 10;
            label5.Text = "Courriel : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cascadia Code", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(34, 189);
            label4.Name = "label4";
            label4.Size = new Size(210, 22);
            label4.TabIndex = 9;
            label4.Text = "Date de naissance : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cascadia Code", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(251, 154);
            label3.Name = "label3";
            label3.Size = new Size(70, 22);
            label3.TabIndex = 8;
            label3.Text = "Prénom";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cascadia Code", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(31, 154);
            label2.Name = "label2";
            label2.Size = new Size(40, 22);
            label2.TabIndex = 7;
            label2.Text = "Nom";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cascadia Code", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(31, 107);
            label1.Name = "label1";
            label1.Size = new Size(50, 22);
            label1.TabIndex = 6;
            label1.Text = "Code";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Cascadia Code", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(118, 25);
            label7.Name = "label7";
            label7.Size = new Size(280, 32);
            label7.TabIndex = 12;
            label7.Text = "Ajout d'un Étudiant";
            // 
            // textBox_CodePermanent
            // 
            textBox_CodePermanent.Enabled = false;
            textBox_CodePermanent.Font = new Font("Cascadia Code", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            textBox_CodePermanent.Location = new Point(95, 107);
            textBox_CodePermanent.Name = "textBox_CodePermanent";
            textBox_CodePermanent.Size = new Size(125, 27);
            textBox_CodePermanent.TabIndex = 13;
            // 
            // textBox_Nom
            // 
            textBox_Nom.Font = new Font("Cascadia Code", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            textBox_Nom.Location = new Point(95, 151);
            textBox_Nom.Name = "textBox_Nom";
            textBox_Nom.Size = new Size(125, 27);
            textBox_Nom.TabIndex = 14;
            // 
            // textBox_Prenom
            // 
            textBox_Prenom.Font = new Font("Cascadia Code", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            textBox_Prenom.Location = new Point(335, 151);
            textBox_Prenom.Name = "textBox_Prenom";
            textBox_Prenom.Size = new Size(96, 27);
            textBox_Prenom.TabIndex = 15;
            // 
            // textBox_Email
            // 
            textBox_Email.Font = new Font("Cascadia Code", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            textBox_Email.Location = new Point(173, 227);
            textBox_Email.Name = "textBox_Email";
            textBox_Email.Size = new Size(264, 27);
            textBox_Email.TabIndex = 16;
            // 
            // dateTimePicker_Ddn
            // 
            dateTimePicker_Ddn.CalendarForeColor = Color.MidnightBlue;
            dateTimePicker_Ddn.CalendarTitleBackColor = Color.DarkBlue;
            dateTimePicker_Ddn.CalendarTitleForeColor = Color.AntiqueWhite;
            dateTimePicker_Ddn.Font = new Font("Cascadia Code", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            dateTimePicker_Ddn.Format = DateTimePickerFormat.Short;
            dateTimePicker_Ddn.Location = new Point(244, 184);
            dateTimePicker_Ddn.Name = "dateTimePicker_Ddn";
            dateTimePicker_Ddn.Size = new Size(187, 27);
            dateTimePicker_Ddn.TabIndex = 17;
            // 
            // comboBox_CodeProgramme
            // 
            comboBox_CodeProgramme.Font = new Font("Cascadia Code", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            comboBox_CodeProgramme.FormattingEnabled = true;
            comboBox_CodeProgramme.Location = new Point(226, 273);
            comboBox_CodeProgramme.Name = "comboBox_CodeProgramme";
            comboBox_CodeProgramme.Size = new Size(211, 30);
            comboBox_CodeProgramme.TabIndex = 18;
            // 
            // btn_Ajouter
            // 
            btn_Ajouter.Font = new Font("Cascadia Code", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Ajouter.Location = new Point(46, 331);
            btn_Ajouter.Name = "btn_Ajouter";
            btn_Ajouter.Size = new Size(126, 37);
            btn_Ajouter.TabIndex = 19;
            btn_Ajouter.Text = "Ajouter";
            btn_Ajouter.UseVisualStyleBackColor = true;
            btn_Ajouter.Click += btn_Ajouter_Click;
            // 
            // btn_Annuler
            // 
            btn_Annuler.Font = new Font("Cascadia Code", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Annuler.Location = new Point(179, 331);
            btn_Annuler.Name = "btn_Annuler";
            btn_Annuler.Size = new Size(126, 37);
            btn_Annuler.TabIndex = 20;
            btn_Annuler.Text = "Annuler";
            btn_Annuler.UseVisualStyleBackColor = true;
            btn_Annuler.Click += btn_Annuler_Click;
            // 
            // btn_Retour
            // 
            btn_Retour.Font = new Font("Cascadia Code", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Retour.Location = new Point(311, 331);
            btn_Retour.Name = "btn_Retour";
            btn_Retour.Size = new Size(126, 37);
            btn_Retour.TabIndex = 21;
            btn_Retour.Text = "Retour";
            btn_Retour.UseVisualStyleBackColor = true;
            btn_Retour.Click += btn_Retour_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(459, 107);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(227, 224);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 22;
            pictureBox1.TabStop = false;
            // 
            // errorProvider_AjoutEtudiant
            // 
            errorProvider_AjoutEtudiant.ContainerControl = this;
            // 
            // AjoutEtudiant
            // 
            AcceptButton = btn_Ajouter;
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(809, 489);
            Controls.Add(pictureBox1);
            Controls.Add(btn_Retour);
            Controls.Add(btn_Annuler);
            Controls.Add(btn_Ajouter);
            Controls.Add(comboBox_CodeProgramme);
            Controls.Add(dateTimePicker_Ddn);
            Controls.Add(textBox_Email);
            Controls.Add(textBox_Prenom);
            Controls.Add(textBox_Nom);
            Controls.Add(textBox_CodePermanent);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Cascadia Code", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = SystemColors.ControlText;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AjoutEtudiant";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inscription Collège  - Ajout étudiant";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider_AjoutEtudiant).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label7;
        private TextBox textBox_CodePermanent;
        private TextBox textBox_Nom;
        private TextBox textBox_Prenom;
        private TextBox textBox_Email;
        private DateTimePicker dateTimePicker_Ddn;
        private ComboBox comboBox_CodeProgramme;
        private Button btn_Ajouter;
        private Button btn_Annuler;
        private Button btn_Retour;
        private PictureBox pictureBox1;
        private ErrorProvider errorProvider_AjoutEtudiant;
    }
}