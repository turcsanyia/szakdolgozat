using System;
using System.Security.Cryptography;
using System.Windows.Forms;
using Medi2020.Models;
using Medi2020.Presenters;
using Medi2020.ViewInterfaces;

namespace Medi2020.Views
{
    public partial class FormPatient : Form, IPatientView
    {
        private PatientPresenter presenter;

        public patient patient
        {
            get
            {
                string taj = textBoxTaj.Text;
                string jelszo = textBoxJelszo.Text;
                string vezeteknev = textBoxVezeteknev.Text;
                string keresztnev = textBoxKeresztnev.Text;
                int.TryParse(textBoxIranyitoszam.Text, out int iranyitoszam);
                string telepules = textBoxTelepules.Text;
                string lakcim = textBoxLakcim.Text;
                string email = textBoxEmail.Text;
                string telefon = textBoxTelefon.Text;

                return new patient(taj, jelszo, vezeteknev, keresztnev, iranyitoszam, telepules, lakcim, email,
                    telefon);
            }
            set
            {
                if (string.IsNullOrEmpty(value.Taj))
                {
                    textBoxTaj.Text = value.Taj;
                }
                else
                {
                    textBoxTaj.Text = value.Taj;
                    textBoxTaj.Enabled = false;
                }

                if (string.IsNullOrEmpty(value.Jelszo))
                {
                    textBoxJelszo.Text = value.Taj;
                }
                else
                {
                    textBoxJelszo.Text = value.Taj;
                    textBoxJelszo.Enabled = false;
                }

                textBoxJelszo.Text = value.Jelszo;
                textBoxVezeteknev.Text = value.Vezeteknev;
                textBoxKeresztnev.Text = value.Keresztnev;
                textBoxIranyitoszam.Text = value.Iranyitoszam.ToString();
                textBoxTelepules.Text = value.Telepules;
                textBoxLakcim.Text = value.Lakcim;
                textBoxEmail.Text = value.Email;
                textBoxTelefon.Text = value.Telefon;
            }
        }

        public FormPatient()
        {
            InitializeComponent();
            presenter = new PatientPresenter(this);
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            try
            {
                presenter.Validate(patient);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DialogResult = DialogResult.None;
                return;
            }

            if (presenter.IsExisting(patient.Taj, textBoxTaj.Enabled))
            {
                errorProviderTaj.SetError(buttonOk, "Létező taj szám!");
                this.DialogResult = DialogResult.None;
                return;
            }

            this.DialogResult = DialogResult.OK;
        }
    }
}
