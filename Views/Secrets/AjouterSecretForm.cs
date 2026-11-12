using Mon_Secret.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Mon_Secret.Views.Secrets
{
    public partial class AjouterSecretForm : Form
    {
        private int userId;
        private SecretController secretController;

        public AjouterSecretForm(int userId)
        {
            InitializeComponent();

            this.userId = userId;
            secretController = new SecretController();

            ConfigurerCategories();

            txtValeurSecrete.UseSystemPasswordChar = true;

            txtTitre.MaxLength = 100;
        }

        private void ConfigurerCategories()
        {
            cmbCategorie.Items.Clear();

            cmbCategorie.Items.Add("Mots de passe");
            cmbCategorie.Items.Add("Informations bancaires");
            cmbCategorie.Items.Add("Clés API");
            cmbCategorie.Items.Add("Identifications");

            cmbCategorie.DropDownStyle =
                ComboBoxStyle.DropDownList;

            cmbCategorie.SelectedIndex = 0;
        }



        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            bool resultat = secretController.AjouterSecret(
               userId,
               txtTitre.Text,
               cmbCategorie.Text,
               txtDescription.Text,
               txtValeurSecrete.Text,
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
                    "Erreur",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtTitre.Focus();
            }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();

        }
    }
}
