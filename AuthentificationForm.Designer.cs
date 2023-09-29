namespace ProjetFinal
{
    partial class AuthentificationForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthentificationForm));
            lbl_Titre = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox_User = new TextBox();
            textBox_Pwd = new TextBox();
            button_Connexion = new Button();
            button_Quitter = new Button();
            pictureBox1 = new PictureBox();
            errorProvider_Login = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider_Login).BeginInit();
            SuspendLayout();
            // 
            // lbl_Titre
            // 
            lbl_Titre.AutoSize = true;
            lbl_Titre.Font = new Font("Cascadia Code", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Titre.Location = new Point(98, 40);
            lbl_Titre.Name = "lbl_Titre";
            lbl_Titre.Size = new Size(221, 30);
            lbl_Titre.TabIndex = 0;
            lbl_Titre.Text = "Authentification";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cascadia Code", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(18, 128);
            label2.Name = "label2";
            label2.Size = new Size(180, 20);
            label2.TabIndex = 1;
            label2.Text = "Nom d'utilisateur :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cascadia Code", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(18, 171);
            label3.Name = "label3";
            label3.Size = new Size(180, 20);
            label3.TabIndex = 2;
            label3.Text = "Mot de passe      :";
            // 
            // textBox_User
            // 
            textBox_User.Font = new Font("Cascadia Code", 9F, FontStyle.Bold, GraphicsUnit.Point);
            textBox_User.Location = new Point(204, 123);
            textBox_User.Name = "textBox_User";
            textBox_User.Size = new Size(163, 25);
            textBox_User.TabIndex = 3;
            // 
            // textBox_Pwd
            // 
            textBox_Pwd.Font = new Font("Cascadia Code", 9F, FontStyle.Bold, GraphicsUnit.Point);
            textBox_Pwd.Location = new Point(204, 166);
            textBox_Pwd.Name = "textBox_Pwd";
            textBox_Pwd.PasswordChar = '*';
            textBox_Pwd.Size = new Size(163, 25);
            textBox_Pwd.TabIndex = 4;
            // 
            // button_Connexion
            // 
            button_Connexion.Font = new Font("Cascadia Code", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button_Connexion.Location = new Point(98, 197);
            button_Connexion.Name = "button_Connexion";
            button_Connexion.Size = new Size(125, 30);
            button_Connexion.TabIndex = 5;
            button_Connexion.Text = "Connexion";
            button_Connexion.UseVisualStyleBackColor = true;
            button_Connexion.Click += button_Connexion_Click;
            // 
            // button_Quitter
            // 
            button_Quitter.Font = new Font("Cascadia Code", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button_Quitter.Location = new Point(242, 197);
            button_Quitter.Name = "button_Quitter";
            button_Quitter.Size = new Size(125, 30);
            button_Quitter.TabIndex = 6;
            button_Quitter.Text = "Quitter";
            button_Quitter.UseVisualStyleBackColor = true;
            button_Quitter.Click += button_Quitter_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(382, 70);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(181, 154);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // errorProvider_Login
            // 
            errorProvider_Login.ContainerControl = this;
            // 
            // AuthentificationForm
            // 
            AcceptButton = button_Connexion;
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(582, 248);
            Controls.Add(pictureBox1);
            Controls.Add(button_Quitter);
            Controls.Add(button_Connexion);
            Controls.Add(textBox_Pwd);
            Controls.Add(textBox_User);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lbl_Titre);
            Font = new Font("Cascadia Code", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AuthentificationForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Athentification";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider_Login).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_Titre;
        private Label label2;
        private Label label3;
        private TextBox textBox_User;
        private TextBox textBox_Pwd;
        private Button button_Connexion;
        private Button button_Quitter;
        private PictureBox pictureBox1;
        private ErrorProvider errorProvider_Login;
    }
}