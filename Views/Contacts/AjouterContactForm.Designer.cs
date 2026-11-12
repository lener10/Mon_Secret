namespace Mon_Secret.Views.Contacts
{
    partial class AjouterContactForm
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            btnAnnuler = new Button();
            btnEnregistre = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textNom = new TextBox();
            textPrenom = new TextBox();
            textTelephone = new TextBox();
            textEmail = new TextBox();
            textAdresse = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.plus;
            pictureBox1.Location = new Point(26, 100);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(133, 157);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(31, 43);
            label1.Name = "label1";
            label1.Size = new Size(120, 20);
            label1.TabIndex = 1;
            label1.Text = "Ajouter Contact";
            // 
            // btnAnnuler
            // 
            btnAnnuler.BackColor = SystemColors.ActiveBorder;
            btnAnnuler.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAnnuler.Location = new Point(45, 339);
            btnAnnuler.Name = "btnAnnuler";
            btnAnnuler.Size = new Size(75, 23);
            btnAnnuler.TabIndex = 2;
            btnAnnuler.Text = "Annuler";
            btnAnnuler.UseVisualStyleBackColor = false;
            // 
            // btnEnregistre
            // 
            btnEnregistre.BackColor = Color.DodgerBlue;
            btnEnregistre.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEnregistre.ForeColor = Color.White;
            btnEnregistre.Location = new Point(265, 339);
            btnEnregistre.Name = "btnEnregistre";
            btnEnregistre.Size = new Size(75, 23);
            btnEnregistre.TabIndex = 3;
            btnEnregistre.Text = "Valider";
            btnEnregistre.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(203, 61);
            label2.Name = "label2";
            label2.Size = new Size(38, 17);
            label2.TabIndex = 4;
            label2.Text = "Nom";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(203, 114);
            label3.Name = "label3";
            label3.Size = new Size(56, 17);
            label3.TabIndex = 5;
            label3.Text = "Prenom";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(203, 168);
            label4.Name = "label4";
            label4.Size = new Size(72, 17);
            label4.TabIndex = 6;
            label4.Text = "Téléphone";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(203, 222);
            label5.Name = "label5";
            label5.Size = new Size(42, 17);
            label5.TabIndex = 7;
            label5.Text = "Email";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(203, 271);
            label6.Name = "label6";
            label6.Size = new Size(56, 17);
            label6.TabIndex = 8;
            label6.Text = "Adresse";
            // 
            // textNom
            // 
            textNom.Location = new Point(286, 61);
            textNom.Name = "textNom";
            textNom.Size = new Size(100, 23);
            textNom.TabIndex = 9;
            // 
            // textPrenom
            // 
            textPrenom.Location = new Point(286, 108);
            textPrenom.Name = "textPrenom";
            textPrenom.Size = new Size(100, 23);
            textPrenom.TabIndex = 10;
            // 
            // textTelephone
            // 
            textTelephone.Location = new Point(286, 162);
            textTelephone.Name = "textTelephone";
            textTelephone.Size = new Size(100, 23);
            textTelephone.TabIndex = 11;
            // 
            // textEmail
            // 
            textEmail.Location = new Point(286, 222);
            textEmail.Name = "textEmail";
            textEmail.Size = new Size(100, 23);
            textEmail.TabIndex = 12;
            // 
            // textAdresse
            // 
            textAdresse.Location = new Point(286, 271);
            textAdresse.Name = "textAdresse";
            textAdresse.Size = new Size(100, 23);
            textAdresse.TabIndex = 13;
            // 
            // AjouterContactForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(408, 374);
            Controls.Add(textAdresse);
            Controls.Add(textEmail);
            Controls.Add(textTelephone);
            Controls.Add(textPrenom);
            Controls.Add(textNom);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnEnregistre);
            Controls.Add(btnAnnuler);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AjouterContactForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "AjouterContactForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Button btnAnnuler;
        private Button btnEnregistre;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textNom;
        private TextBox textPrenom;
        private TextBox textTelephone;
        private TextBox textEmail;
        private TextBox textAdresse;
    }
}