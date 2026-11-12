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
    public partial class DetailsSecretForm : Form
    {
        private int userId;
        private int secretId;
        private SecretController secretController;

        private bool valeurVisible = false;

        public DetailsSecretForm(int userId, int secretId)
        {
            InitializeComponent();
           

            this.userId = userId;
            this.secretId = secretId;

            secretController = new SecretController();

            ChargerSecret();

            btnAfficher.Click += btnAfficher_Click;
            btnFermer.Click += btnFermer_Click;

        }

    

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
                    txtCategorie.Text = secret.Category;
                    txtDescription.Text = secret.Description;
                    txtValeurSecrete.Text = secret.SecretValue;
                    txtDateAjout.Text = secret.CreatedAt.ToString("dd/MM/yyyy HH:mm");

                    txtValeurSecrete.UseSystemPasswordChar = true;
                    btnAfficher.Text = "Afficher";
                }
                else
                {
                    MessageBox.Show(
                        message,
                        "Information",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    DialogResult = DialogResult.Cancel;
                    Close();
                }
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

        private void btnAfficher_Click(object sender, EventArgs e)
        {
            valeurVisible = !valeurVisible;

            txtValeurSecrete.UseSystemPasswordChar = !valeurVisible;

            btnAfficher.Text = valeurVisible ? "Masquer" : "Afficher";
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}

