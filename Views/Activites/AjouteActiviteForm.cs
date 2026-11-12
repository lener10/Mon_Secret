using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Mon_Secret.Controllers;

namespace Mon_Secret.Views.Activites
{
    public partial class AjouteActiviteForm : Form
    {
        private readonly int userId;
        private readonly ActiviteController activiteController;

        public AjouteActiviteForm(int userId)
        {
            InitializeComponent();

            this.userId = userId;
            activiteController = new ActiviteController();

            cbmCategorie.Items.AddRange(
                new object[] { "Personnel", "Études", "Travail", "Urgent" });
            cbmStatus.Items.AddRange(
                new object[] { "À faire", "En cours", "Terminée" });

            cbmCategorie.SelectedIndex = 0;
            cbmStatus.SelectedIndex = 0;

            btnAnnuler.Click += btnAnnuler_Click;
            btnEnregistre.Click += btnEnregistre_Click;
        }

        private void btnAnnuler_Click(object? sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnEnregistre_Click(object? sender, EventArgs e)
        {
            bool resultat = activiteController.AjouterActivite(
                userId,
                texTitre.Text,
                texDescription.Text,
                dateHeure.Value,
                cbmCategorie.Text,
                cbmStatus.Text,
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

        private void label2_Click(object? sender, EventArgs e)
        {
        }

        private void label4_Click(object? sender, EventArgs e) { }

        private void label6_Click(object? sender, EventArgs e) { }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
