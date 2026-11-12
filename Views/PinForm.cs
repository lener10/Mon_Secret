using Mon_Secret.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Mon_Secret.Views
{
    public partial class PinForm : Form
    {
        private AuthController authController;
        private int userId;

        public PinForm(int userId)
        {
            InitializeComponent();

            this.userId = userId;
            authController = new AuthController();

            txtPin.MaxLength = 6;
            txtPin.UseSystemPasswordChar = true;
        }

        private void btnValide_Click(object sender, EventArgs e)
        {
            bool resultat = authController.VerifyPin(
               userId,
               txtPin.Text,
               out string message
           );

            if (resultat)
            {
                MessageBox.Show(
                    message,
                    "Accès autorisé",
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
                    "Accès refusé",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtPin.Clear();
                txtPin.Focus();
            }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
