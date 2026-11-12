using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;
using Mon_Secret.Views.Auth;
using Mon_Secret.Views.Contacts;
using Mon_Secret.Views.Secrets;

namespace Mon_Secret.Views.Dashboard
{

    public partial class DashboardControl : System.Windows.Forms.UserControl
    {
        private int userId;
        public DashboardControl()
        {
            InitializeComponent();
            ArrondirPanel(panel1, 8);
            ArrondirPanel(panel2, 13);
            ArrondirPanel(panel3, 13);
            ArrondirPanel(panel4, 13);
            ArrondirPanel(panel5, 13);

        }

        public DashboardControl(int userId) : this()
        {
            this.userId = userId;


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

        private void btnAccederSecret_Click(object sender, EventArgs e)
        {

            if (userId <= 0)
            {
                MessageBox.Show(
                    "Aucun utilisateur connecté.",
                    "Accès refusé",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            // Demander le PIN
            using (PinForm pinForm = new PinForm(userId))
            {
                if (pinForm.ShowDialog(this) == DialogResult.OK)
                {
                    MessageBox.Show(
                        "Vous pouvez maintenant accéder à vos secrets.",
                        "Accès autorisé",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    OuvrirSecrets();
                }
            }

        }

        private void OuvrirSecrets()
        {
            Accueill accueil = this.FindForm() as Accueill;

            if (accueil != null)
            {
                accueil.OuvrirSecrets();
            }
        }

        private void btnAccederActivite_Click(object sender, EventArgs e)
        {
            OuvrirActivites();
        }

        private void btnAccederContact_Click(object sender, EventArgs e)
        {
            OuvrirContacts();
        }

        private void OuvrirActivites()
        {
            Accueill accueil = this.FindForm() as Accueill;
            accueil?.OuvrirActivites();
        }

        private void OuvrirContacts()
        {
            Accueill accueil = this.FindForm() as Accueill;
            accueil?.OuvrirContacts();
        }
    }
}
