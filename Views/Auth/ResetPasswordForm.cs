using Mon_Secret.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Mon_Secret.Views.Auth
{
    public partial class ResetPasswordForm : Form
    {
        private AuthController authController;

        public ResetPasswordForm()
        {
            InitializeComponent();
            authController = new AuthController();

            txtPin.MaxLength = 6;
            txtPin.UseSystemPasswordChar = true;

            txtNouveauPassword.UseSystemPasswordChar = true;
            txtConfirmPassword.UseSystemPasswordChar = true;
        }

        private void btnReinitialiser_Click(object sender, EventArgs e)
        {
            bool resultat = authController.ResetPassword(
       txtUsername.Text,
       txtPin.Text,
       txtNouveauPassword.Text,
       txtConfirmPassword.Text,
       out string message
   );

            if (resultat)
            {
                MessageBox.Show(
                    message,
                    "Réinitialisation réussie",
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
            }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
