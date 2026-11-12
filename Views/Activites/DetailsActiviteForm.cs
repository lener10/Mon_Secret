using System;
using System.Windows.Forms;
using Mon_Secret.Controllers;
using Mon_Secret.Models;

namespace Mon_Secret.Views.Activites
{
    public partial class DetailsActiviteForm : Form
    {
        private readonly int userId;
        private readonly int activiteId;
        private readonly ActiviteController activiteController;

        public DetailsActiviteForm()
        {
            InitializeComponent();
        }

        public DetailsActiviteForm(int userId, int activiteId)
        {
            InitializeComponent();

            this.userId = userId;
            this.activiteId = activiteId;
            activiteController = new ActiviteController();

            ConfigurerAffichage();
            ChargerActivite();

            btnFermer.Click += btnFermer_Click;
        }

        private void ConfigurerAffichage()
        {
            textBox1.ReadOnly = true;
            textBox2.ReadOnly = true;
            comboBox1.Enabled = false;
            comboBox2.Enabled = false;
            dateTimePicker1.Enabled = false;
            Text = "Détails de l'activité";
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
                    MessageBox.Show(
                        message,
                        "Information",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    DialogResult = DialogResult.Cancel;
                    Close();
                    return;
                }

                textBox1.Text = activite.Title;
                textBox2.Text = activite.Description;
                comboBox1.Items.Clear();
                comboBox1.Items.Add(activite.Category);
                comboBox1.SelectedIndex = 0;
                dateTimePicker1.Value = activite.DateHeure;
                comboBox2.Items.Clear();
                comboBox2.Items.Add(activite.Status);
                comboBox2.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Erreur lors du chargement : " + ex.Message,
                    "Erreur",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                DialogResult = DialogResult.Cancel;
                Close();
            }
        }

        private void btnFermer_Click(object? sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
