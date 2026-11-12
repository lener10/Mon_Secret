using Mon_Secret.Controllers;
using Mon_Secret.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;



namespace Mon_Secret.Views.Secrets
{
    public partial class SecretControl : System.Windows.Forms.UserControl
    {
        private int userId;
        private SecretController secretController = null!;
        private DataTable secretsTable = null!;
        public SecretControl(int userId)
        {
            InitializeComponent();

            ArrondirPanel(panelMotsDePasse, 8);
            ArrondirPanel(panelBanques, 8);
            ArrondirPanel(panelIdentifications, 8);
            ArrondirPanel(panelClesAPI, 8);


            this.userId = userId;
            secretController = new SecretController();

            // Configuration du tableau
            ConfigurerDataGridView();

            // Préparer les catégories
            ConfigurerCategories();

            // Événements de recherche et de filtrage
            txtRecherche.TextChanged += txtRecherche_TextChanged;
            cmbCategorie.SelectedIndexChanged += cmbCategorie_SelectedIndexChanged;
            // Événement des boutons du tableau

            dgvSecrets.CellMouseClick += dgvSecrets_CellContentClick;
            dgvSecrets.CellPainting += dgvSecrets_CellPainting;
            // Charger les secrets
            ChargerSecrets();
        }





        private void ArrondirPanel(Panel panel, int rayon)
        {
            GraphicsPath path = new GraphicsPath();

            int diametre = rayon * 2;

            path.AddArc(0, 0, diametre, diametre, 180, 90);
            path.AddArc(panel.Width - diametre, 0,
                diametre, diametre, 270, 90);

            path.AddArc(panel.Width - diametre,
                panel.Height - diametre,
                diametre, diametre, 0, 90);

            path.AddArc(0, panel.Height - diametre,
                diametre, diametre, 90, 90);

            path.CloseFigure();

            panel.Region = new Region(path);
        }

        private void ConfigurerDataGridView()
        {
            // Apparence générale
            dgvSecrets.BackgroundColor = Color.White;
            dgvSecrets.BorderStyle = BorderStyle.None;

            // En-tête des colonnes
            dgvSecrets.ColumnHeadersDefaultCellStyle.BackColor = Color.MidnightBlue;
            dgvSecrets.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvSecrets.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 10, FontStyle.Bold);

            // Style des cellules
            dgvSecrets.DefaultCellStyle.Font =
                new Font("Segoe UI", 9, FontStyle.Regular);

            dgvSecrets.DefaultCellStyle.SelectionBackColor = Color.LightSteelBlue;
            dgvSecrets.DefaultCellStyle.SelectionForeColor = Color.Black;

            // Comportement
            dgvSecrets.EnableHeadersVisualStyles = false;
            dgvSecrets.RowHeadersVisible = false;
            dgvSecrets.AllowUserToAddRows = false;
            dgvSecrets.AllowUserToDeleteRows = false;
            dgvSecrets.AllowUserToResizeRows = false;

            dgvSecrets.ReadOnly = true;
            dgvSecrets.MultiSelect = false;
            dgvSecrets.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            // Dimensions générales
            dgvSecrets.Size = new Size(709, 230);

            dgvSecrets.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.None;

            dgvSecrets.ColumnHeadersHeight = 40;
            dgvSecrets.RowTemplate.Height = 35;

            // Largeur des colonnes
            dgvSecrets.Columns["colTitre"].Width = 105;
            dgvSecrets.Columns["colCategorie"].Width = 125;
            dgvSecrets.Columns["colDescription"].Width = 140;
            dgvSecrets.Columns["colDateAjout"].Width = 110;

            dgvSecrets.Columns["ColActions"].Width = 135;
            dgvSecrets.Columns["ColActions"].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;

            // Associer les colonnes aux champs de la base de données
            dgvSecrets.Columns["colTitre"].DataPropertyName = "title";
            dgvSecrets.Columns["colCategorie"].DataPropertyName = "category";
            dgvSecrets.Columns["colDescription"].DataPropertyName = "description";
            dgvSecrets.Columns["colDateAjout"].DataPropertyName = "created_at";
        }

        private void dgvSecrets_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0 ||
                dgvSecrets.Columns[e.ColumnIndex].Name != "ColActions")
                return;

            e.PaintBackground(e.CellBounds, true);
            using Font font = new Font("Segoe UI Symbol", 14, FontStyle.Bold);
            TextRenderer.DrawText(e.Graphics, "◉", font,
                new Point(e.CellBounds.Left + 13, e.CellBounds.Top + 7), Color.DodgerBlue);
            TextRenderer.DrawText(e.Graphics, "✎", font,
                new Point(e.CellBounds.Left + 55, e.CellBounds.Top + 7), Color.DarkOrange);
            TextRenderer.DrawText(e.Graphics, "✖", font,
                new Point(e.CellBounds.Left + 97, e.CellBounds.Top + 7), Color.Crimson);
            e.Handled = true;
        }


        private void ConfigurerCategories()
        {
            cmbCategorie.Items.Clear();

            cmbCategorie.Items.Add("Toutes les catégories");
            cmbCategorie.Items.Add("Mots de passe");
            cmbCategorie.Items.Add("Informations bancaires");
            cmbCategorie.Items.Add("Clés API");
            cmbCategorie.Items.Add("Identifications");

            cmbCategorie.SelectedIndex = 0;
        }

        private void ChargerSecrets()
        {
            try
            {
                secretsTable = secretController.AfficherSecrets(userId);

                // Afficher les données dans le tableau
                dgvSecrets.DataSource = secretsTable;

                // Formater les dates
                dgvSecrets.Columns["colDateAjout"]
                    .DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";

                // Mettre à jour les statistiques
                ActualiserStatistiques();

                // Appliquer les filtres
                AppliquerFiltres();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Erreur",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // =========================================
        // STATISTIQUES DES SECRETS
        // =========================================

        private void ActualiserStatistiques()
        {
            int motsDePasse = 0;
            int banques = 0;
            int clesAPI = 0;
            int identifications = 0;

            foreach (DataRow ligne in secretsTable.Rows)
            {
                string categorie = Convert.ToString(ligne["category"]) ?? string.Empty;

                if (categorie == "Mots de passe")
                    motsDePasse++;

                else if (categorie == "Informations bancaires")
                    banques++;

                else if (categorie == "Clés API")
                    clesAPI++;

                else if (categorie == "Identifications")
                    identifications++;
            }

            lblNbMotsDePasse.Text = motsDePasse.ToString();
            lblNbBanques.Text = banques.ToString();
            lblNbClesAPI.Text = clesAPI.ToString();
            lblNbIdentifications.Text = identifications.ToString();
        }

        // =========================================
        // RECHERCHE
        // =========================================

        private void txtRecherche_TextChanged(object sender, EventArgs e)
        {
            AppliquerFiltres();
        }

        // =========================================
        // FILTRAGE PAR CATÉGORIE
        // =========================================

        private void cmbCategorie_SelectedIndexChanged(
            object sender,
            EventArgs e)
        {
            AppliquerFiltres();
        }

        // =========================================
        // APPLIQUER LES FILTRES
        // =========================================

        private void AppliquerFiltres()
        {
            if (secretsTable == null)
                return;

            string recherche = txtRecherche.Text.Trim();
            string categorie = cmbCategorie.Text;

            string filtreRecherche = "";
            string filtreCategorie = "";

            if (!string.IsNullOrWhiteSpace(recherche))
            {
                string texte = recherche.Replace("'", "''");

                filtreRecherche =
                    $"(title LIKE '%{texte}%' " +
                    $"OR description LIKE '%{texte}%')";
            }

            if (!string.IsNullOrWhiteSpace(categorie) &&
                categorie != "Toutes les catégories")
            {
                string texteCategorie = categorie.Replace("'", "''");

                filtreCategorie =
                    $"category = '{texteCategorie}'";
            }

            string filtreFinal = "";

            if (filtreRecherche != "")
                filtreFinal = filtreRecherche;

            if (filtreCategorie != "")
            {
                if (filtreFinal != "")
                    filtreFinal += " AND ";

                filtreFinal += filtreCategorie;
            }

            secretsTable.DefaultView.RowFilter = filtreFinal;
        }

        private void btnAjouterSecret_Click(object sender, EventArgs e)
        {
            using (AjouterSecretForm form = new AjouterSecretForm(userId))
            {
                if (form.ShowDialog(this) == DialogResult.OK)
                {
                    ChargerSecrets();
                }
            }
        }

        private void dgvSecrets_CellContentClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            if (dgvSecrets.Columns[e.ColumnIndex].Name != "ColActions")
                return;

            DataGridViewRow ligne = dgvSecrets.Rows[e.RowIndex];
            if (ligne.DataBoundItem is not DataRowView data)
                return;

            int secretId = Convert.ToInt32(data["id"]);
            int largeurAction = dgvSecrets.Columns[e.ColumnIndex].Width;

            if (e.X < largeurAction / 3)
            {
                using (DetailsSecretForm form = new DetailsSecretForm(userId, secretId))
                {
                    form.ShowDialog(this);
                }
            }
            else if (e.X < largeurAction * 2 / 3)
            {
                using (ModifierSecretForm form = new ModifierSecretForm(userId, secretId))
                {
                    if (form.ShowDialog(this) == DialogResult.OK)
                        ChargerSecrets();
                }
            }
            else
            {
                DialogResult confirmation = MessageBox.Show(
                    "Voulez-vous vraiment supprimer ce secret ?",
                    "Confirmation de suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirmation == DialogResult.Yes)
                {
                    bool resultat = secretController.SupprimerSecret(secretId, userId, out string message);
                    MessageBox.Show(message, resultat ? "Succès" : "Attention", MessageBoxButtons.OK,
                        resultat ? MessageBoxIcon.Information : MessageBoxIcon.Warning);
                    if (resultat)
                        ChargerSecrets();
                }
            }
        }


    }
}
