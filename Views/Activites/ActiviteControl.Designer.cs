namespace Mon_Secret.Views.Contacts
{
    partial class dgvActivites
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            label2 = new Label();
            panel3 = new Panel();
            label3 = new Label();
            panel4 = new Panel();
            label4 = new Label();
            dataGridView1 = new DataGridView();
            colTitre = new DataGridViewTextBoxColumn();
            colDescription = new DataGridViewTextBoxColumn();
            colDateHeure = new DataGridViewTextBoxColumn();
            colCategorie = new DataGridViewTextBoxColumn();
            colStatut = new DataGridViewTextBoxColumn();
            ColActions = new DataGridViewTextBoxColumn();
            txtRecherche = new TextBox();
            cmbStatut = new ComboBox();
            cmbCategorie = new ComboBox();
            btnAjouterActivite = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.Captura_de_pantalla_2026_11_09_1233273;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(20, 19);
            panel1.Name = "panel1";
            panel1.Size = new Size(152, 59);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Blue;
            label1.ForeColor = Color.White;
            label1.Location = new Point(88, 27);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackgroundImage = Properties.Resources.Captura_de_pantalla_2026_11_08_1902111;
            panel2.Controls.Add(label2);
            panel2.Location = new Point(210, 19);
            panel2.Name = "panel2";
            panel2.Size = new Size(152, 59);
            panel2.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Blue;
            label2.ForeColor = Color.White;
            label2.Location = new Point(125, 29);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackgroundImage = Properties.Resources.Captura_de_pantalla_2026_11_10_0957092;
            panel3.Controls.Add(label3);
            panel3.Location = new Point(402, 19);
            panel3.Name = "panel3";
            panel3.Size = new Size(152, 59);
            panel3.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Blue;
            label3.ForeColor = Color.White;
            label3.Location = new Point(127, 29);
            label3.Name = "label3";
            label3.Size = new Size(0, 15);
            label3.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.BackgroundImage = Properties.Resources.Captura_de_pantalla_2026_11_10_1000573;
            panel4.Controls.Add(label4);
            panel4.Location = new Point(582, 19);
            panel4.Name = "panel4";
            panel4.Size = new Size(152, 59);
            panel4.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Blue;
            label4.ForeColor = Color.White;
            label4.Location = new Point(117, 27);
            label4.Name = "label4";
            label4.Size = new Size(0, 15);
            label4.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colTitre, colDescription, colDateHeure, colCategorie, colStatut, ColActions });
            dataGridView1.Location = new Point(15, 137);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(719, 233);
            dataGridView1.TabIndex = 2;
            // 
            // colTitre
            // 
            colTitre.HeaderText = "Titre";
            colTitre.Name = "colTitre";
            // 
            // colDescription
            // 
            colDescription.HeaderText = "Description";
            colDescription.Name = "colDescription";
            // 
            // colDateHeure
            // 
            colDateHeure.HeaderText = "Date Heure";
            colDateHeure.Name = "colDateHeure";
            // 
            // colCategorie
            // 
            colCategorie.HeaderText = "Categorie";
            colCategorie.Name = "colCategorie";
            // 
            // colStatut
            // 
            colStatut.HeaderText = "Statut";
            colStatut.Name = "colStatut";
            // 
            // ColActions
            // 
            ColActions.HeaderText = "Actions";
            ColActions.Name = "ColActions";
            ColActions.ReadOnly = true;
            ColActions.Resizable = DataGridViewTriState.True;
            ColActions.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // txtRecherche
            // 
            txtRecherche.Location = new Point(614, 104);
            txtRecherche.Name = "txtRecherche";
            txtRecherche.PlaceholderText = "Recherche";
            txtRecherche.Size = new Size(100, 23);
            txtRecherche.TabIndex = 3;
            // 
            // cmbStatut
            // 
            cmbStatut.FormattingEnabled = true;
            cmbStatut.Location = new Point(469, 104);
            cmbStatut.Name = "cmbStatut";
            cmbStatut.Size = new Size(121, 23);
            cmbStatut.TabIndex = 4;
            // 
            // cmbCategorie
            // 
            cmbCategorie.FormattingEnabled = true;
            cmbCategorie.Location = new Point(332, 104);
            cmbCategorie.Name = "cmbCategorie";
            cmbCategorie.Size = new Size(121, 23);
            cmbCategorie.TabIndex = 5;
            // 
            // btnAjouterActivite
            // 
            btnAjouterActivite.BackColor = Color.ForestGreen;
            btnAjouterActivite.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAjouterActivite.ForeColor = Color.White;
            btnAjouterActivite.Image = Properties.Resources.favicon_32x3210;
            btnAjouterActivite.ImageAlign = ContentAlignment.MiddleLeft;
            btnAjouterActivite.Location = new Point(15, 98);
            btnAjouterActivite.Name = "btnAjouterActivite";
            btnAjouterActivite.Size = new Size(145, 33);
            btnAjouterActivite.TabIndex = 6;
            btnAjouterActivite.Text = "       Ajouter activite";
            btnAjouterActivite.UseVisualStyleBackColor = false;
            btnAjouterActivite.Click += btnAjouterActivite_Click;
            // 
            // dgvActivites
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(cmbCategorie);
            Controls.Add(cmbStatut);
            Controls.Add(txtRecherche);
            Controls.Add(btnAjouterActivite);
            Controls.Add(dataGridView1);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "dgvActivites";
            Size = new Size(747, 387);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn colTitre;
        private DataGridViewTextBoxColumn colDescription;
        private DataGridViewTextBoxColumn colDateHeure;
        private DataGridViewTextBoxColumn colCategorie;
        private DataGridViewTextBoxColumn colStatut;
        private DataGridViewTextBoxColumn ColActions;
        private TextBox txtRecherche;
        private ComboBox cmbStatut;
        private ComboBox cmbCategorie;
        private Button btnAjouterActivite;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}
