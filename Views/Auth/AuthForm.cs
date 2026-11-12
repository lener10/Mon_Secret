using Mon_Secret.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Mon_Secret.Models;

namespace Mon_Secret.Views.Auth
{
    public partial class AuthForm : Form
    {
        private AuthController authController;
        internal User UtilisateurConnecte { get; private set; }
        public AuthForm()
        {
            InitializeComponent();
            txtIdentifiant.Text = Properties.Settings.Default.NomUtilisateur;
            chkSouvenir.Checked = !string.IsNullOrWhiteSpace(
                Properties.Settings.Default.NomUtilisateur
            );

            authController = new AuthController();

            // Vérifier si un compte existe déjà
            if (authController.HasUser())
            {
                AfficherConnexion();
            }
            else
            {
                AfficherInscription();
            }
        }

        private void AfficherConnexion()
        {
            panelConnexion.Visible = true;
            panelInscription.Visible = false;
            panelConnexion.BringToFront();
        }

        private void AfficherInscription()
        {
            panelInscription.Visible = true;
            panelConnexion.Visible = false;
            panelInscription.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool resultat = authController.Register(
        txtNomComplet.Text,
        txtUsername.Text,
        txtPassword.Text,
        txtConfirmPassword.Text,
        txtCodeSecret.Text,
        txtConfirmCodeSecret.Text,
        out string message
               );

            if (resultat)
            {
                MessageBox.Show(
                    message,
                    "Inscription réussie",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                // Vider les champs
                txtNomComplet.Clear();
                txtUsername.Clear();
                txtPassword.Clear();
                txtConfirmPassword.Clear();
                txtCodeSecret.Clear();
                txtConfirmCodeSecret.Clear();

                // Afficher le panneau de connexion
                AfficherConnexion();
            }
            else
            {
                MessageBox.Show(
                    message,
                    "Erreur d'inscription",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
        }

        private void btnSeConnecter_Click(object sender, EventArgs e)
        {
            bool resultat = authController.Login(
        txtIdentifiant.Text,
        txtMotDePasse.Text,
        out User user,
        out string message
    );

            if (resultat)
            {
                if (chkSouvenir.Checked)
                {
                    Properties.Settings.Default.NomUtilisateur = txtIdentifiant.Text;
                }
                else
                {
                    Properties.Settings.Default.NomUtilisateur = "";
                }

                Properties.Settings.Default.Save();

                MessageBox.Show(
                    message,
                    "Connexion réussie",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                // Conserver l'utilisateur connecté
                UtilisateurConnecte = user;

                // Ouvrir Accueill en transmettant l'utilisateur
                Accueill accueil = new Accueill(UtilisateurConnecte.Id);

                accueil.FormClosed += (s, args) => this.Close();

                accueil.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show(
                    message,
                    "Erreur de connexion",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtMotDePasse.Clear();
                txtMotDePasse.Focus();
            }
        }

        private void btnMotOublie_Click(object sender, EventArgs e)
        {
            using (ResetPasswordForm resetForm = new ResetPasswordForm())
            {
                if (resetForm.ShowDialog(this) == DialogResult.OK)
                {
                    MessageBox.Show(
                        "Vous pouvez maintenant vous connecter avec votre nouveau mot de passe.",
                        "Information",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    txtMotDePasse.Clear();
                    txtMotDePasse.Focus();
                }
            }
        }
    }
}
