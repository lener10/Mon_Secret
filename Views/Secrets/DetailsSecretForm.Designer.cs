namespace Mon_Secret.Views.Secrets
{
    partial class DetailsSecretForm
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
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtTitre = new TextBox();
            txtCategorie = new TextBox();
            txtDescription = new TextBox();
            txtValeurSecrete = new TextBox();
            txtDateAjout = new TextBox();
            btnAfficher = new Button();
            btnFermer = new Button();
            label7 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 360);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DodgerBlue;
            label1.Location = new Point(8, 274);
            label1.Name = "label1";
            label1.Size = new Size(189, 17);
            label1.TabIndex = 1;
            label1.Text = "Gadez vos secret en sécurité ";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.encrypted1;
            pictureBox1.Location = new Point(12, 50);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(170, 188);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(228, 58);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 1;
            label2.Text = "Titre :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(228, 93);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 1;
            label3.Text = "Categorie :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(228, 134);
            label4.Name = "label4";
            label4.Size = new Size(77, 15);
            label4.TabIndex = 2;
            label4.Text = "Description :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(228, 171);
            label5.Name = "label5";
            label5.Size = new Size(89, 15);
            label5.TabIndex = 3;
            label5.Text = "Valeur secret : ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(228, 239);
            label6.Name = "label6";
            label6.Size = new Size(82, 15);
            label6.TabIndex = 4;
            label6.Text = "Date d'ajout :";
            // 
            // txtTitre
            // 
            txtTitre.Location = new Point(344, 50);
            txtTitre.Name = "txtTitre";
            txtTitre.ReadOnly = true;
            txtTitre.Size = new Size(100, 23);
            txtTitre.TabIndex = 5;
            // 
            // txtCategorie
            // 
            txtCategorie.Location = new Point(344, 85);
            txtCategorie.Name = "txtCategorie";
            txtCategorie.ReadOnly = true;
            txtCategorie.Size = new Size(100, 23);
            txtCategorie.TabIndex = 6;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(344, 126);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.ReadOnly = true;
            txtDescription.Size = new Size(100, 23);
            txtDescription.TabIndex = 7;
            // 
            // txtValeurSecrete
            // 
            txtValeurSecrete.Location = new Point(344, 163);
            txtValeurSecrete.Name = "txtValeurSecrete";
            txtValeurSecrete.Size = new Size(100, 23);
            txtValeurSecrete.TabIndex = 8;
            txtValeurSecrete.UseSystemPasswordChar = true;
            // 
            // txtDateAjout
            // 
            txtDateAjout.Location = new Point(344, 236);
            txtDateAjout.Name = "txtDateAjout";
            txtDateAjout.ReadOnly = true;
            txtDateAjout.Size = new Size(100, 23);
            txtDateAjout.TabIndex = 9;
            // 
            // btnAfficher
            // 
            btnAfficher.BackColor = Color.DodgerBlue;
            btnAfficher.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAfficher.ForeColor = Color.White;
            btnAfficher.Location = new Point(369, 196);
            btnAfficher.Name = "btnAfficher";
            btnAfficher.Size = new Size(75, 25);
            btnAfficher.TabIndex = 10;
            btnAfficher.Text = "Afficher";
            btnAfficher.UseVisualStyleBackColor = false;
            // 
            // btnFermer
            // 
            btnFermer.BackColor = Color.White;
            btnFermer.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFermer.Location = new Point(400, 310);
            btnFermer.Name = "btnFermer";
            btnFermer.Size = new Size(75, 23);
            btnFermer.TabIndex = 1;
            btnFermer.Text = "Fermer";
            btnFermer.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.RoyalBlue;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(206, 336);
            label7.Name = "label7";
            label7.Size = new Size(272, 15);
            label7.TabIndex = 0;
            label7.Text = "La valeur secret est masque pour votre sécurité";
            label7.Click += label7_Click;
            // 
            // DetailsSecretForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(476, 360);
            Controls.Add(btnFermer);
            Controls.Add(label7);
            Controls.Add(btnAfficher);
            Controls.Add(txtDateAjout);
            Controls.Add(txtValeurSecrete);
            Controls.Add(txtDescription);
            Controls.Add(txtCategorie);
            Controls.Add(txtTitre);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "DetailsSecretForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "DetailsSecretForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtTitre;
        private TextBox txtCategorie;
        private TextBox txtDescription;
        private TextBox txtValeurSecrete;
        private TextBox txtDateAjout;
        private Button btnAfficher;
        private Label label7;
        private Button btnFermer;
    }
}