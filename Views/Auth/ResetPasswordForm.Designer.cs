namespace Mon_Secret.Views.Auth
{
    partial class ResetPasswordForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResetPasswordForm));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            txtUsername = new TextBox();
            txtPin = new TextBox();
            txtNouveauPassword = new TextBox();
            txtConfirmPassword = new TextBox();
            btnAnnuler = new Button();
            btnReinitialiser = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.pngtree_silver_blue_shield_with_white_padlock_vector_png_image_92678234;
            pictureBox1.Location = new Point(149, 13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(87, 74);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(82, 90);
            label1.Name = "label1";
            label1.Size = new Size(230, 21);
            label1.TabIndex = 1;
            label1.Text = "Réinitialiser le mot de passe";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(37, 111);
            label2.Name = "label2";
            label2.Size = new Size(333, 15);
            label2.TabIndex = 2;
            label2.Text = "Vérifiez votre identité pour définir un nouveau mot de passe.";
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtUsername.Location = new Point(39, 157);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "Nom d'utilisateur";
            txtUsername.Size = new Size(142, 23);
            txtUsername.TabIndex = 3;
            // 
            // txtPin
            // 
            txtPin.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPin.Location = new Point(39, 200);
            txtPin.Name = "txtPin";
            txtPin.PlaceholderText = "Code PIN";
            txtPin.Size = new Size(142, 23);
            txtPin.TabIndex = 3;
            // 
            // txtNouveauPassword
            // 
            txtNouveauPassword.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNouveauPassword.Location = new Point(225, 157);
            txtNouveauPassword.Name = "txtNouveauPassword";
            txtNouveauPassword.PasswordChar = '*';
            txtNouveauPassword.PlaceholderText = "Nouveau mot de passe";
            txtNouveauPassword.Size = new Size(165, 23);
            txtNouveauPassword.TabIndex = 3;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtConfirmPassword.Location = new Point(225, 201);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.PasswordChar = '*';
            txtConfirmPassword.PlaceholderText = "Confirmer le mot de passe";
            txtConfirmPassword.Size = new Size(165, 23);
            txtConfirmPassword.TabIndex = 3;
            // 
            // btnAnnuler
            // 
            btnAnnuler.BackColor = SystemColors.ActiveBorder;
            btnAnnuler.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAnnuler.Location = new Point(38, 266);
            btnAnnuler.Name = "btnAnnuler";
            btnAnnuler.Size = new Size(75, 28);
            btnAnnuler.TabIndex = 4;
            btnAnnuler.Text = "Annuler";
            btnAnnuler.UseVisualStyleBackColor = false;
            btnAnnuler.Click += btnAnnuler_Click;
            // 
            // btnReinitialiser
            // 
            btnReinitialiser.BackColor = Color.DodgerBlue;
            btnReinitialiser.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnReinitialiser.ForeColor = Color.White;
            btnReinitialiser.Location = new Point(239, 266);
            btnReinitialiser.Name = "btnReinitialiser";
            btnReinitialiser.Size = new Size(102, 27);
            btnReinitialiser.TabIndex = 4;
            btnReinitialiser.Text = "Reinitialiser";
            btnReinitialiser.UseVisualStyleBackColor = false;
            btnReinitialiser.Click += btnReinitialiser_Click;
            // 
            // ResetPasswordForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(405, 321);
            Controls.Add(btnReinitialiser);
            Controls.Add(btnAnnuler);
            Controls.Add(txtConfirmPassword);
            Controls.Add(txtNouveauPassword);
            Controls.Add(txtPin);
            Controls.Add(txtUsername);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ResetPasswordForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ResetPasswordForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private TextBox txtUsername;
        private TextBox txtPin;
        private TextBox txtNouveauPassword;
        private TextBox txtConfirmPassword;
        private Button btnAnnuler;
        private Button btnReinitialiser;
    }
}