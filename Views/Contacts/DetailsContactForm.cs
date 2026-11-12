using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Mon_Secret.Controllers;
using Mon_Secret.Models;

namespace Mon_Secret.Views.Contacts
{
    public partial class DetailsContactForm : Form
    {
        private readonly int userId;
        private readonly int contactId;
        private readonly ContactController contactController;

        public DetailsContactForm() : this(0, 0)
        {
        }

        public DetailsContactForm(int userId, int contactId)
        {
            InitializeComponent();
            this.userId = userId;
            this.contactId = contactId;
            contactController = new ContactController();
            btnFermer.Click += (_, _) => { DialogResult = DialogResult.Cancel; Close(); };
            ChargerContact();
        }

        private void ChargerContact()
        {
            if (!contactController.VoirContact(contactId, userId, out Contact contact, out string message))
            {
                MessageBox.Show(message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                DialogResult = DialogResult.Cancel;
                Close();
                return;
            }

            foreach (TextBox textBox in new[] { textBox1, textBox2, textBox3, textBox4, textBox5 })
                textBox.ReadOnly = true;

            textBox1.Text = contact.Nom;
            textBox2.Text = contact.Prenom;
            textBox3.Text = contact.Telephone;
            textBox4.Text = contact.Email;
            textBox5.Text = contact.Adresse;
        }
    }
}
