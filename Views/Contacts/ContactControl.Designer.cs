namespace Mon_Secret.Views.Contacts
{
    partial class ContactControl
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
            dataGridView1 = new DataGridView();
            colNom = new DataGridViewTextBoxColumn();
            colPrenom = new DataGridViewTextBoxColumn();
            colTelephone = new DataGridViewTextBoxColumn();
            colEmail = new DataGridViewTextBoxColumn();
            colAdresse = new DataGridViewTextBoxColumn();
            colActions = new DataGridViewTextBoxColumn();
            btnAjouterContact = new Button();
            textRecherche = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colNom, colPrenom, colTelephone, colEmail, colAdresse, colActions });
            dataGridView1.Location = new Point(8, 104);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(724, 270);
            dataGridView1.TabIndex = 0;
            // 
            // colNom
            // 
            colNom.HeaderText = "Nom";
            colNom.Name = "colNom";
            colNom.ReadOnly = true;
            // 
            // colPrenom
            // 
            colPrenom.HeaderText = "Prenom";
            colPrenom.Name = "colPrenom";
            colPrenom.ReadOnly = true;
            // 
            // colTelephone
            // 
            colTelephone.HeaderText = "Téléphone";
            colTelephone.Name = "colTelephone";
            colTelephone.ReadOnly = true;
            // 
            // colEmail
            // 
            colEmail.HeaderText = "Email";
            colEmail.Name = "colEmail";
            colEmail.ReadOnly = true;
            // 
            // colAdresse
            // 
            colAdresse.HeaderText = "Adresse";
            colAdresse.Name = "colAdresse";
            colAdresse.ReadOnly = true;
            // 
            // colActions
            // 
            colActions.HeaderText = "Actions";
            colActions.Name = "colActions";
            colActions.ReadOnly = true;
            // 
            // btnAjouterContact
            // 
            btnAjouterContact.BackColor = Color.ForestGreen;
            btnAjouterContact.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAjouterContact.ForeColor = Color.White;
            btnAjouterContact.Image = Properties.Resources.favicon_32x3210;
            btnAjouterContact.ImageAlign = ContentAlignment.MiddleLeft;
            btnAjouterContact.Location = new Point(24, 52);
            btnAjouterContact.Name = "btnAjouterContact";
            btnAjouterContact.Size = new Size(145, 31);
            btnAjouterContact.TabIndex = 1;
            btnAjouterContact.Text = "       Ajouter Contact";
            btnAjouterContact.UseVisualStyleBackColor = false;
            // 
            // textRecherche
            // 
            textRecherche.BackColor = Color.White;
            textRecherche.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textRecherche.ForeColor = Color.Black;
            textRecherche.Location = new Point(577, 52);
            textRecherche.Name = "textRecherche";
            textRecherche.PlaceholderText = "Recherche";
            textRecherche.Size = new Size(126, 23);
            textRecherche.TabIndex = 2;
            // 
            // ContactControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(textRecherche);
            Controls.Add(btnAjouterContact);
            Controls.Add(dataGridView1);
            Name = "ContactControl";
            Size = new Size(747, 387);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn colNom;
        private DataGridViewTextBoxColumn colPrenom;
        private DataGridViewTextBoxColumn colTelephone;
        private DataGridViewTextBoxColumn colEmail;
        private DataGridViewTextBoxColumn colAdresse;
        private DataGridViewTextBoxColumn colActions;
        private Button btnAjouterContact;
        private TextBox textRecherche;
    }
}
