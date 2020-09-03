using System;
using System.ComponentModel;
using System.Windows.Forms;
using Medi2020.Models;
using Medi2020.Presenters;
using Medi2020.ViewInterfaces;
using Medi2020.ViewModels;

namespace Medi2020.Views
{
    public partial class FormAddVisit : Form, IAddVisitView
    {
        private AddVisitPresenter presenter;
        private int visitId;

        public VisitVM visitVM
        {
            get
            {
                var idopont = dateTimePickerIdopont.Value;
                var patient = (patient) comboBoxBeteg.SelectedItem;
                var doctor = (doctor) comboBoxOrvos.SelectedItem;
                var service = (service) comboBoxSzolgaltatas.SelectedItem;

                string betegTaj = patient.Taj;
                string betegNeve = patient.Vezeteknev + " " + patient.Keresztnev;
                int orvosId = doctor.Id;
                string orvosNeve = doctor.Vezeteknev + " " + doctor.Keresztnev;
                int szolgaltatasId = service.Id;
                string szolgaltatasNev = service.Nev;

                return new VisitVM(visitId, idopont, betegTaj, betegNeve, orvosId, orvosNeve, szolgaltatasId,
                    szolgaltatasNev);
            }
            set
            {
                visitId = value.VisitId;
                comboBoxBeteg.SelectedItem = value;
                comboBoxOrvos.SelectedItem = value;
                comboBoxSzolgaltatas.SelectedItem = value;
            }
        }

        public BindingList<patient> patients
        {
            get => (BindingList<patient>) comboBoxBeteg.DataSource;
            set => comboBoxBeteg.DataSource = value;
        }

        public BindingList<doctor> doctors
        {
            get => (BindingList<doctor>) comboBoxOrvos.DataSource;
            set => comboBoxOrvos.DataSource = value;
        }

        public BindingList<service> services
        {
            get => (BindingList<service>) comboBoxSzolgaltatas.DataSource;
            set => comboBoxSzolgaltatas.DataSource = value;
        }

        public FormAddVisit()
        {
            InitializeComponent();
            presenter = new AddVisitPresenter(this);
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void FormVisit_Load(object sender, EventArgs e)
        {
            presenter.LoadData();
        }
    }
}
