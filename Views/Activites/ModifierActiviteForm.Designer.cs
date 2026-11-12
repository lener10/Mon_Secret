namespace Mon_Secret.Views.Activites
{
    partial class ModifierActiviteForm
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
            txtTitre = new TextBox();
            txtDescription = new TextBox();
            cmbCategorieModification = new ComboBox();
            cmbStatutModification = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            btnAnnuler = new Button();
            btnModifier = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.pencil1;
            pictureBox1.Location = new Point(25, 45);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(134, 106);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(37, 189);
            label1.Name = "label1";
            label1.Size = new Size(112, 17);
            label1.TabIndex = 1;
            label1.Text = "Modifier Activite";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(183, 40);
            label2.Name = "label2";
            label2.Size = new Size(37, 17);
            label2.TabIndex = 2;
            label2.Text = "Titre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(183, 159);
            label3.Name = "label3";
            label3.Size = new Size(67, 17);
            label3.TabIndex = 3;
            label3.Text = "Categorie";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(183, 95);
            label4.Name = "label4";
            label4.Size = new Size(79, 17);
            label4.TabIndex = 4;
            label4.Text = "Description";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(183, 223);
            label5.Name = "label5";
            label5.Size = new Size(78, 17);
            label5.TabIndex = 5;
            label5.Text = "Date Heure";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(183, 276);
            label6.Name = "label6";
            label6.Size = new Size(46, 17);
            label6.TabIndex = 6;
            label6.Text = "Status";
            // 
            // txtTitre
            // 
            txtTitre.Location = new Point(267, 45);
            txtTitre.Name = "txtTitre";
            txtTitre.Size = new Size(100, 23);
            txtTitre.TabIndex = 7;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(269, 95);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(100, 23);
            txtDescription.TabIndex = 8;
            // 
            // cmbCategorieModification
            // 
            cmbCategorieModification.FormattingEnabled = true;
            cmbCategorieModification.Location = new Point(256, 159);
            cmbCategorieModification.Name = "cmbCategorieModification";
            cmbCategorieModification.Size = new Size(121, 23);
            cmbCategorieModification.TabIndex = 9;
            // 
            // cmbStatutModification
            // 
            cmbStatutModification.FormattingEnabled = true;
            cmbStatutModification.Location = new Point(248, 276);
            cmbStatutModification.Name = "cmbStatutModification";
            cmbStatutModification.Size = new Size(121, 23);
            cmbStatutModification.TabIndex = 10;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(264, 223);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(124, 23);
            dateTimePicker1.TabIndex = 11;
            // 
            // btnAnnuler
            // 
            btnAnnuler.BackColor = SystemColors.ActiveBorder;
            btnAnnuler.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAnnuler.Location = new Point(38, 336);
            btnAnnuler.Name = "btnAnnuler";
            btnAnnuler.Size = new Size(75, 23);
            btnAnnuler.TabIndex = 12;
            btnAnnuler.Text = "Annuler";
            btnAnnuler.UseVisualStyleBackColor = false;
            // 
            // btnModifier
            // 
            btnModifier.BackColor = Color.FromArgb(255, 128, 0);
            btnModifier.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnModifier.ForeColor = Color.White;
            btnModifier.Location = new Point(249, 338);
            btnModifier.Name = "btnModifier";
            btnModifier.Size = new Size(75, 23);
            btnModifier.TabIndex = 13;
            btnModifier.Text = "Modifier";
            btnModifier.UseVisualStyleBackColor = false;
            // 
            // ModifierActiviteForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(391, 379);
            Controls.Add(btnModifier);
            Controls.Add(btnAnnuler);
            Controls.Add(dateTimePicker1);
            Controls.Add(cmbStatutModification);
            Controls.Add(cmbCategorieModification);
            Controls.Add(txtDescription);
            Controls.Add(txtTitre);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ModifierActiviteForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "ModifierActiviteForm";
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
        private TextBox txtTitre;
        private TextBox txtDescription;
        private ComboBox cmbCategorieModification;
        private ComboBox cmbStatutModification;
        private DateTimePicker dateTimePicker1;
        private Button btnAnnuler;
        private Button btnModifier;
    }
}