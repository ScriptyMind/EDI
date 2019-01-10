namespace EDI
{
    partial class Profile
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
            this.image = new System.Windows.Forms.PictureBox();
            this.code_etudient = new System.Windows.Forms.TextBox();
            this.prenom = new System.Windows.Forms.TextBox();
            this.nom = new System.Windows.Forms.TextBox();
            this.language = new System.Windows.Forms.TextBox();
            this.classe = new System.Windows.Forms.TextBox();
            this.date_de_naissance = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.mdp = new System.Windows.Forms.TextBox();
            this.newmdp = new System.Windows.Forms.TextBox();
            this.renewmdp = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.image)).BeginInit();
            this.SuspendLayout();
            // 
            // image
            // 
            this.image.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.image.Location = new System.Drawing.Point(54, 55);
            this.image.Name = "image";
            this.image.Size = new System.Drawing.Size(123, 134);
            this.image.TabIndex = 0;
            this.image.TabStop = false;
            // 
            // code_etudient
            // 
            this.code_etudient.Location = new System.Drawing.Point(317, 55);
            this.code_etudient.Name = "code_etudient";
            this.code_etudient.ReadOnly = true;
            this.code_etudient.Size = new System.Drawing.Size(146, 20);
            this.code_etudient.TabIndex = 1;
            // 
            // prenom
            // 
            this.prenom.Location = new System.Drawing.Point(527, 110);
            this.prenom.Name = "prenom";
            this.prenom.ReadOnly = true;
            this.prenom.Size = new System.Drawing.Size(146, 20);
            this.prenom.TabIndex = 2;
            // 
            // nom
            // 
            this.nom.Location = new System.Drawing.Point(317, 108);
            this.nom.Name = "nom";
            this.nom.ReadOnly = true;
            this.nom.Size = new System.Drawing.Size(146, 20);
            this.nom.TabIndex = 3;
            // 
            // language
            // 
            this.language.Location = new System.Drawing.Point(317, 214);
            this.language.Name = "language";
            this.language.ReadOnly = true;
            this.language.Size = new System.Drawing.Size(146, 20);
            this.language.TabIndex = 4;
            // 
            // classe
            // 
            this.classe.Location = new System.Drawing.Point(317, 267);
            this.classe.Name = "classe";
            this.classe.ReadOnly = true;
            this.classe.Size = new System.Drawing.Size(146, 20);
            this.classe.TabIndex = 5;
            // 
            // date_de_naissance
            // 
            this.date_de_naissance.Location = new System.Drawing.Point(317, 161);
            this.date_de_naissance.Name = "date_de_naissance";
            this.date_de_naissance.ReadOnly = true;
            this.date_de_naissance.Size = new System.Drawing.Size(146, 20);
            this.date_de_naissance.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(209, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Code Etudient :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(209, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nom :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(469, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Prenom :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(209, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Date de naissance :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(209, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Language :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(209, 270);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Classe :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label7.Location = new System.Drawing.Point(51, 300);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Changer votre mot de passe";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // mdp
            // 
            this.mdp.Location = new System.Drawing.Point(54, 330);
            this.mdp.Name = "mdp";
            this.mdp.Size = new System.Drawing.Size(135, 20);
            this.mdp.TabIndex = 14;
            this.mdp.Visible = false;
            // 
            // newmdp
            // 
            this.newmdp.Location = new System.Drawing.Point(229, 330);
            this.newmdp.Name = "newmdp";
            this.newmdp.Size = new System.Drawing.Size(135, 20);
            this.newmdp.TabIndex = 15;
            this.newmdp.Visible = false;
            // 
            // renewmdp
            // 
            this.renewmdp.Location = new System.Drawing.Point(408, 330);
            this.renewmdp.Name = "renewmdp";
            this.renewmdp.Size = new System.Drawing.Size(135, 20);
            this.renewmdp.TabIndex = 16;
            this.renewmdp.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(593, 326);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 26);
            this.button1.TabIndex = 17;
            this.button1.Text = "Confirmer ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 379);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.renewmdp);
            this.Controls.Add(this.newmdp);
            this.Controls.Add(this.mdp);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.date_de_naissance);
            this.Controls.Add(this.classe);
            this.Controls.Add(this.language);
            this.Controls.Add(this.nom);
            this.Controls.Add(this.prenom);
            this.Controls.Add(this.code_etudient);
            this.Controls.Add(this.image);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Profile";
            this.Text = "Profile";
            ((System.ComponentModel.ISupportInitialize)(this.image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox image;
        private System.Windows.Forms.TextBox code_etudient;
        private System.Windows.Forms.TextBox prenom;
        private System.Windows.Forms.TextBox nom;
        private System.Windows.Forms.TextBox language;
        private System.Windows.Forms.TextBox classe;
        private System.Windows.Forms.TextBox date_de_naissance;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox mdp;
        private System.Windows.Forms.TextBox newmdp;
        private System.Windows.Forms.TextBox renewmdp;
        private System.Windows.Forms.Button button1;
    }
}