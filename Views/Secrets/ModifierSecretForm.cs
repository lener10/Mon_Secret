using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Mon_Secret.Controllers;
using Mon_Secret.Models;

namespace Mon_Secret.Views.Secrets
{
    public partial class ModifierSecretForm : Form
    {
        private int userId;
        private int secretId;
        private SecretController secretController;

        public ModifierSecretForm(int userId, int secretId)
        {
            InitializeComponent();

            this.userId = userId;
            this.secretId = secretId;

            secretController = new SecretController();

            ConfigurerCategories();
            ChargerSecret();

            btnAnnuler.Click += btnAnnuler_Click_1;
            btnEnregistrer.Click += btnEnregistrer_Click;
        }

        // =========================================
        // CONFIGURATION DES CATÉGORIES
        // =========================================

        private void ConfigurerCategories()
        {
            cmbCategorie.Items.Clear();

            cmbCategorie.Items.Add("Mots de passe");
            cmbCategorie.Items.Add("Informations bancaires");
            cmbCategorie.Items.Add("Clés API");
            cmbCategorie.Items.Add("Identifications");
        }

        // =========================================
        // CHARGER LES INFORMATIONS DU SECRET
        // =========================================

        private void ChargerSecret()
        {
            try
            {
                if (secretController.VoirSecret(
                    secretId,
                    userId,
                    out Secret secret,
                    out string message))
                {
                    txtTitre.Text = secret.Title;

                    cmbCategorie.SelectedItem = secret.Category;

                    txtDescription.Text = secret.Description;

                    txtValeurSecrete.Text = secret.SecretValue;
                }
                else
                {
                    MessageBox.Show(
                        message,
                        "Information",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    this.DialogResult = DialogResult.Cancel;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Erreur",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }

        // =========================================
        // BOUTON ANNULER
        // =========================================



        private void btnAnnuler_Click_1(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            try
            {
                string titre = txtTitre.Text.Trim();
                string categorie = cmbCategorie.Text;
                string description = txtDescription.Text.Trim();
                string valeurSecrete = txtValeurSecrete.Text;

                bool resultat = secretController.ModifierSecret(
                    secretId,
                    userId,
                    titre,
                    categorie,
                    description,
                    valeurSecrete,
                    out string message
                );

                if (resultat)
                {
                    MessageBox.Show(
                        message,
                        "Succès",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show(
                        message,
                        "Attention",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Une erreur est survenue : " + ex.Message,
                    "Erreur",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
    }
}
