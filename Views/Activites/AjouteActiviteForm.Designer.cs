namespace Mon_Secret.Views.Activites
{
    partial class AjouteActiviteForm
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
            label6 = new Label();
            texTitre = new TextBox();
            texDescription = new TextBox();
            cbmCategorie = new ComboBox();
            cbmStatus = new ComboBox();
            dateHeure = new DateTimePicker();
            btnAnnuler = new Button();
            btnEnregistre = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.reminder1;
            pictureBox1.Location = new Point(12, 91);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(131, 161);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(12, 44);
            label1.Name = "label1";
            label1.Size = new Size(150, 20);
            label1.TabIndex = 1;
            label1.Text = "Ajouter une Activite";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(187, 41);
            label2.Name = "label2";
            label2.Size = new Size(37, 17);
            label2.TabIndex = 2;
            label2.Text = "Titre";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(187, 103);
            label3.Name = "label3";
            label3.Size = new Size(79, 17);
            label3.TabIndex = 3;
            label3.Text = "Description";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(187, 162);
            label4.Name = "label4";
            label4.Size = new Size(67, 17);
            label4.TabIndex = 4;
            label4.Text = "Categorie";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(179, 218);
            label5.Name = "label5";
            label5.Size = new Size(92, 17);
            label5.TabIndex = 5;
            label5.Text = "Date et heure";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(191, 284);
            label6.Name = "label6";
            label6.Size = new Size(46, 17);
            label6.TabIndex = 6;
            label6.Text = "Status";
            label6.Click += label6_Click;
            // 
            // texTitre
            // 
            texTitre.Location = new Point(278, 41);
            texTitre.Name = "texTitre";
            texTitre.Size = new Size(100, 23);
            texTitre.TabIndex = 7;
            // 
            // texDescription
            // 
            texDescription.Location = new Point(278, 103);
            texDescription.Name = "texDescription";
            texDescription.Size = new Size(100, 23);
            texDescription.TabIndex = 8;
            // 
            // cbmCategorie
            // 
            cbmCategorie.FormattingEnabled = true;
            cbmCategorie.Location = new Point(271, 160);
            cbmCategorie.Name = "cbmCategorie";
            cbmCategorie.Size = new Size(121, 23);
            cbmCategorie.TabIndex = 9;
            // 
            // cbmStatus
            // 
            cbmStatus.FormattingEnabled = true;
            cbmStatus.Location = new Point(271, 281);
            cbmStatus.Name = "cbmStatus";
            cbmStatus.Size = new Size(121, 23);
            cbmStatus.TabIndex = 10;
            // 
            // dateHeure
            // 
            dateHeure.CustomFormat = "dd/MM/yyyy HH:mm";
            dateHeure.Format = DateTimePickerFormat.Custom;
            dateHeure.Location = new Point(277, 215);
            dateHeure.Name = "dateHeure";
            dateHeure.Size = new Size(121, 23);
            dateHeure.TabIndex = 13;
            // 
            // btnAnnuler
            // 
            btnAnnuler.BackColor = SystemColors.ActiveBorder;
            btnAnnuler.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAnnuler.Location = new Point(51, 350);
            btnAnnuler.Name = "btnAnnuler";
            btnAnnuler.Size = new Size(75, 25);
            btnAnnuler.TabIndex = 11;
            btnAnnuler.Text = "Annuler";
            btnAnnuler.UseVisualStyleBackColor = false;
            // 
            // btnEnregistre
            // 
            btnEnregistre.BackColor = Color.DodgerBlue;
            btnEnregistre.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEnregistre.ForeColor = Color.White;
            btnEnregistre.Location = new Point(271, 348);
            btnEnregistre.Name = "btnEnregistre";
            btnEnregistre.Size = new Size(75, 27);
            btnEnregistre.TabIndex = 12;
            btnEnregistre.Text = "Valider";
            btnEnregistre.UseVisualStyleBackColor = false;
            // 
            // AjouteActiviteForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(404, 395);
            Controls.Add(btnEnregistre);
            Controls.Add(btnAnnuler);
            Controls.Add(cbmStatus);
            Controls.Add(dateHeure);
            Controls.Add(cbmCategorie);
            Controls.Add(texDescription);
            Controls.Add(texTitre);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AjouteActiviteForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "AjouteActiviteForm";
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
        private Label label6;
        private TextBox texTitre;
        private TextBox texDescription;
        private ComboBox cbmCategorie;
        private ComboBox cbmStatus;
        private DateTimePicker dateHeure;
        private Button btnAnnuler;
        private Button btnEnregistre;
    }
}