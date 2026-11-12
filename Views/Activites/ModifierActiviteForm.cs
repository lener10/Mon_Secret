using System;
using System.Windows.Forms;
using Mon_Secret.Controllers;
using Mon_Secret.Models;

namespace Mon_Secret.Views.Activites
{
    public partial class ModifierActiviteForm : Form
    {
        private readonly int userId;
        private readonly int activiteId;
        private readonly ActiviteController activiteController;

        public ModifierActiviteForm(int userId, int activiteId)
        {
            InitializeComponent();

            this.userId = userId;
            this.activiteId = activiteId;
            activiteController = new ActiviteController();

            ConfigurerCategories();
            ConfigurerStatuts();
            ChargerActivite();

            btnAnnuler.Click += btnAnnuler_Click;
            btnModifier.Click += btnModifier_Click;
        }

        private void ConfigurerCategories()
        {
            cmbCategorieModification.Items.AddRange(
                new object[] { "Personnel", "Études", "Travail", "Urgent" });
        }

        private void ConfigurerStatuts()
        {
            cmbStatutModification.Items.AddRange(
                new object[] { "À faire", "En cours", "Terminée" });
        }

        private void ChargerActivite()
        {
            try
            {
                if (!activiteController.VoirActivite(
                    activiteId,
                    userId,
                    out Activite activite,
                    out string message))
                {
                    MessageBox.Show(message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    DialogResult = DialogResult.Cancel;
                    Close();
                    return;
                }

                txtTitre.Text = activite.Title;
                txtDescription.Text = activite.Description;
                dateTimePicker1.Value = activite.DateHeure;
                cmbCategorieModification.SelectedItem = activite.Category;
                cmbStatutModification.SelectedItem = activite.Status;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Erreur lors du chargement : " + ex.Message,
                    "Erreur",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                DialogResult = DialogResult.Cancel;
                Close();
            }
        }

        private void btnAnnuler_Click(object? sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnModifier_Click(object? sender, EventArgs e)
        {
            try
            {
                bool resultat = activiteController.ModifierActivite(
                    activiteId,
                    userId,
                    txtTitre.Text,
                    txtDescription.Text,
                    dateTimePicker1.Value,
                    cmbCategorieModification.Text,
                    cmbStatutModification.Text,
                    out string message
                );

                MessageBox.Show(
                    message,
                    resultat ? "Succès" : "Attention",
                    MessageBoxButtons.OK,
                    resultat ? MessageBoxIcon.Information : MessageBoxIcon.Warning
                );

                if (resultat)
                {
                    DialogResult = DialogResult.OK;
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Erreur lors de la modification : " + ex.Message,
                    "Erreur",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
    }
}
