namespace Mon_Secret
{
    partial class Accueill
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Accueill));
            panelMenu = new Panel();
            btnDeconnexion = new Button();
            btnContacts = new Button();
            btnActivites = new Button();
            btnSecrets = new Button();
            btnAccueil = new Button();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panelHeader = new Panel();
            btnFerme = new Button();
            label4 = new Label();
            LabelBonjour = new Label();
            pictureBox2 = new PictureBox();
            panelContenu = new Panel();
            panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.Navy;
            panelMenu.Controls.Add(btnDeconnexion);
            panelMenu.Controls.Add(btnContacts);
            panelMenu.Controls.Add(btnActivites);
            panelMenu.Controls.Add(btnSecrets);
            panelMenu.Controls.Add(btnAccueil);
            panelMenu.Controls.Add(label2);
            panelMenu.Controls.Add(label1);
            panelMenu.Controls.Add(pictureBox1);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(200, 450);
            panelMenu.TabIndex = 0;
            // 
            // btnDeconnexion
            // 
            btnDeconnexion.Anchor = AnchorStyles.Bottom;
            btnDeconnexion.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDeconnexion.ForeColor = Color.Red;
            btnDeconnexion.Image = Properties.Resources.favicon_16x161;
            btnDeconnexion.ImageAlign = ContentAlignment.MiddleLeft;
            btnDeconnexion.Location = new Point(27, 420);
            btnDeconnexion.Name = "btnDeconnexion";
            btnDeconnexion.Size = new Size(126, 23);
            btnDeconnexion.TabIndex = 5;
            btnDeconnexion.Text = "Déconnexion";
            btnDeconnexion.UseVisualStyleBackColor = true;
            btnDeconnexion.Click += btnDeconnexion_Click;
            // 
            // btnContacts
            // 
            btnContacts.BackColor = Color.CornflowerBlue;
            btnContacts.Font = new Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnContacts.ForeColor = Color.White;
            btnContacts.Image = Properties.Resources.favicon_32x324;
            btnContacts.ImageAlign = ContentAlignment.MiddleLeft;
            btnContacts.Location = new Point(27, 327);
            btnContacts.Name = "btnContacts";
            btnContacts.Size = new Size(126, 43);
            btnContacts.TabIndex = 4;
            btnContacts.Text = "Contacts";
            btnContacts.TextAlign = ContentAlignment.MiddleRight;
            btnContacts.UseVisualStyleBackColor = false;
            btnContacts.Click += btnContacts_Click;
            // 
            // btnActivites
            // 
            btnActivites.BackColor = Color.CornflowerBlue;
            btnActivites.Font = new Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnActivites.ForeColor = Color.White;
            btnActivites.Image = Properties.Resources.favicon_32x323;
            btnActivites.ImageAlign = ContentAlignment.MiddleLeft;
            btnActivites.Location = new Point(27, 270);
            btnActivites.Name = "btnActivites";
            btnActivites.Size = new Size(126, 43);
            btnActivites.TabIndex = 4;
            btnActivites.Text = "Activités";
            btnActivites.TextAlign = ContentAlignment.MiddleRight;
            btnActivites.UseVisualStyleBackColor = false;
            btnActivites.Click += btnActivites_Click;
            // 
            // btnSecrets
            // 
            btnSecrets.BackColor = Color.CornflowerBlue;
            btnSecrets.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSecrets.ForeColor = Color.White;
            btnSecrets.Image = Properties.Resources.favicon_32x322;
            btnSecrets.ImageAlign = ContentAlignment.MiddleLeft;
            btnSecrets.Location = new Point(27, 213);
            btnSecrets.Name = "btnSecrets";
            btnSecrets.Size = new Size(126, 43);
            btnSecrets.TabIndex = 4;
            btnSecrets.Text = "Mes Secrets";
            btnSecrets.TextAlign = ContentAlignment.MiddleRight;
            btnSecrets.UseVisualStyleBackColor = false;
            btnSecrets.Click += btnSecrets_Click;
            // 
            // btnAccueil
            // 
            btnAccueil.BackColor = Color.CornflowerBlue;
            btnAccueil.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAccueil.ForeColor = Color.White;
            btnAccueil.Image = Properties.Resources.favicon_32x321;
            btnAccueil.ImageAlign = ContentAlignment.MiddleLeft;
            btnAccueil.Location = new Point(27, 155);
            btnAccueil.Name = "btnAccueil";
            btnAccueil.Size = new Size(126, 43);
            btnAccueil.TabIndex = 3;
            btnAccueil.Text = "Accueil";
            btnAccueil.UseVisualStyleBackColor = false;
            btnAccueil.Click += btnAccueil_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(26, 121);
            label2.Name = "label2";
            label2.Size = new Size(134, 17);
            label2.TabIndex = 2;
            label2.Text = "Votre espace sécurisé";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(39, 99);
            label1.Name = "label1";
            label1.Size = new Size(99, 21);
            label1.TabIndex = 1;
            label1.Text = "Mon Secret";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.pngtree_silver_blue_shield_with_white_padlock_vector_png_image_9267823;
            pictureBox1.Location = new Point(36, 10);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 84);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.MidnightBlue;
            panelHeader.Controls.Add(btnFerme);
            panelHeader.Controls.Add(label4);
            panelHeader.Controls.Add(LabelBonjour);
            panelHeader.Controls.Add(pictureBox2);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(200, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(747, 63);
            panelHeader.TabIndex = 1;
            // 
            // btnFerme
            // 
            btnFerme.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnFerme.BackColor = Color.FromArgb(0, 0, 192);
            btnFerme.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFerme.ForeColor = Color.White;
            btnFerme.Location = new Point(656, 20);
            btnFerme.Name = "btnFerme";
            btnFerme.Size = new Size(75, 29);
            btnFerme.TabIndex = 3;
            btnFerme.Text = "Ferme";
            btnFerme.UseVisualStyleBackColor = false;
            btnFerme.Click += btnFerme_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(115, 32);
            label4.Name = "label4";
            label4.Size = new Size(163, 17);
            label4.TabIndex = 2;
            label4.Text = "Bienvenue sur Mon secret";
            // 
            // LabelBonjour
            // 
            LabelBonjour.AutoSize = true;
            LabelBonjour.Font = new Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelBonjour.ForeColor = Color.White;
            LabelBonjour.Location = new Point(117, 9);
            LabelBonjour.Name = "LabelBonjour";
            LabelBonjour.Size = new Size(0, 20);
            LabelBonjour.TabIndex = 1;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.user__2_;
            pictureBox2.Location = new Point(12, 5);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(100, 50);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // panelContenu
            // 
            panelContenu.Dock = DockStyle.Fill;
            panelContenu.Location = new Point(200, 63);
            panelContenu.Name = "panelContenu";
            panelContenu.Size = new Size(747, 387);
            panelContenu.TabIndex = 2;
            // 
            // Accueill
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(947, 450);
            Controls.Add(panelContenu);
            Controls.Add(panelHeader);
            Controls.Add(panelMenu);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Accueill";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Accueil";
            panelMenu.ResumeLayout(false);
            panelMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private PictureBox pictureBox1;
        private Panel panelHeader;
        private Label label1;
        private Label label2;
        private Button btnAccueil;
        private Button btnContacts;
        private Button btnActivites;
        private Button btnSecrets;
        private Button btnDeconnexion;
        private PictureBox pictureBox2;
        private Label LabelBonjour;
        private Label label4;
        private Button btnFerme;
        private Panel panelContenu;
    }
}
