using System;
using System.ComponentModel;
using System.Windows.Forms;
using Medi2020.Models;
using Medi2020.Presenters;
using Medi2020.ViewInterfaces;

namespace Medi2020.Views
{
    public partial class FormDoctor : Form, IDoctorView
    {
        private DoctorPresenter presenter;
        private int id;

        public doctor doctor
        {
            get
            {
                var vezeteknev = textBoxVezeteknev.Text;
                var keresztnev = textBoxKeresztnev.Text;
                var specialization = (specialization) comboBoxSzakterulet.SelectedItem;

                return new doctor(id, vezeteknev, keresztnev, specialization.Id, specialization);
            }
            set
            {
                id = value.Id;
                textBoxVezeteknev.Text = value.Vezeteknev;
                textBoxKeresztnev.Text = value.Keresztnev;
                comboBoxSzakterulet.SelectedValue = value.specialization.Nev;
            }
        }

        public BindingList<specialization> specializations
        {
            get => (BindingList<specialization>) comboBoxSzakterulet.DataSource;
            set
            {
                comboBoxSzakterulet.DataSource = value;
                comboBoxSzakterulet.DisplayMember = "Szakterület";
                comboBoxSzakterulet.Name = "szakteruletNev";
                comboBoxSzakterulet.ValueMember = "Nev";
            }
        }

        public FormDoctor()
        {
            InitializeComponent();
            presenter = new DoctorPresenter(this);
            presenter.LoadData();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
