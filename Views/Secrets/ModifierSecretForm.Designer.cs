namespace Mon_Secret.Views.Secrets
{
    partial class ModifierSecretForm
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtTitre = new TextBox();
            txtDescription = new TextBox();
            txtValeurSecrete = new TextBox();
            cmbCategorie = new ComboBox();
            btnAnnuler = new Button();
            btnEnregistrer = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.pencil;
            pictureBox1.Location = new Point(135, 25);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 66);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(121, 105);
            label1.Name = "label1";
            label1.Size = new Size(123, 21);
            label1.TabIndex = 1;
            label1.Text = "Modifier secret";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(52, 149);
            label2.Name = "label2";
            label2.Size = new Size(35, 17);
            label2.TabIndex = 2;
            label2.Text = "Titre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(52, 242);
            label3.Name = "label3";
            label3.Size = new Size(66, 17);
            label3.TabIndex = 2;
            label3.Text = "Categorie";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(243, 149);
            label4.Name = "label4";
            label4.Size = new Size(76, 17);
            label4.TabIndex = 2;
            label4.Text = "Description";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(243, 242);
            label5.Name = "label5";
            label5.Size = new Size(92, 17);
            label5.TabIndex = 2;
            label5.Text = "Valeur secrète";
            // 
            // txtTitre
            // 
            txtTitre.Location = new Point(52, 187);
            txtTitre.Name = "txtTitre";
            txtTitre.Size = new Size(100, 23);
            txtTitre.TabIndex = 3;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(243, 187);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(100, 23);
            txtDescription.TabIndex = 3;
            // 
            // txtValeurSecrete
            // 
            txtValeurSecrete.Location = new Point(243, 281);
            txtValeurSecrete.Multiline = true;
            txtValeurSecrete.Name = "txtValeurSecrete";
            txtValeurSecrete.Size = new Size(100, 23);
            txtValeurSecrete.TabIndex = 3;
            txtValeurSecrete.UseSystemPasswordChar = true;
            // 
            // cmbCategorie
            // 
            cmbCategorie.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategorie.FormattingEnabled = true;
            cmbCategorie.Location = new Point(52, 281);
            cmbCategorie.Name = "cmbCategorie";
            cmbCategorie.Size = new Size(121, 23);
            cmbCategorie.TabIndex = 4;
            // 
            // btnAnnuler
            // 
            btnAnnuler.BackColor = SystemColors.ActiveBorder;
            btnAnnuler.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAnnuler.Location = new Point(57, 349);
            btnAnnuler.Name = "btnAnnuler";
            btnAnnuler.Size = new Size(75, 33);
            btnAnnuler.TabIndex = 5;
            btnAnnuler.Text = "Annuler";
            btnAnnuler.UseVisualStyleBackColor = false;
            btnAnnuler.Click += btnAnnuler_Click_1;
            // 
            // btnEnregistrer
            // 
            btnEnregistrer.BackColor = Color.FromArgb(255, 128, 0);
            btnEnregistrer.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEnregistrer.ForeColor = Color.White;
            btnEnregistrer.Location = new Point(250, 347);
            btnEnregistrer.Name = "btnEnregistrer";
            btnEnregistrer.Size = new Size(75, 35);
            btnEnregistrer.TabIndex = 6;
            btnEnregistrer.Text = "Modifier";
            btnEnregistrer.UseVisualStyleBackColor = false;
            btnEnregistrer.Click += btnEnregistrer_Click;
            // 
            // ModifierSecretForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(389, 392);
            Controls.Add(btnEnregistrer);
            Controls.Add(btnAnnuler);
            Controls.Add(cmbCategorie);
            Controls.Add(txtValeurSecrete);
            Controls.Add(txtDescription);
            Controls.Add(txtTitre);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ModifierSecretForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "ModifierSecretForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtTitre;
        private TextBox txtDescription;
        private TextBox txtValeurSecrete;
        private ComboBox cmbCategorie;
        private Button btnAnnuler;
        private Button btnEnregistrer;
    }
}