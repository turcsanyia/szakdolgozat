using System;
using System.ComponentModel;
using System.Windows.Forms;
using Medi2020.Presenters;
using Medi2020.ViewInterfaces;
using Medi2020.ViewModels;

namespace Medi2020.Views
{
    public partial class FormUpdateVisit : Form, IUpdateVisitView
    {
        private UpdateVisitPresenter presenter;

        private int visitId;
        private string betegTaj;
        private string betegNeve;
        private int orvosId;
        private string orvosNeve;

        public FormUpdateVisit()
        {
            InitializeComponent();
            presenter = new UpdateVisitPresenter(this);
            presenter.LoadData();
        }

        public VisitVM visitVM
        {
            get
            {
                var idopont = dateTimePickerIdopont.Value;
                var szolgaltatasNev = comboBoxSzolgaltatas.SelectedItem.ToString();

                return new VisitVM(visitId, idopont, betegTaj, betegNeve, orvosId, orvosNeve, szolgaltatasNev);
            }
            set
            {
                visitId = value.VisitId;
                betegTaj = value.BetegTaj;
                betegNeve = value.BetegNeve;
                orvosId = value.OrvosId;
                orvosNeve = value.OrvosNeve;

                dateTimePickerIdopont.Value = value.Idopont;
                comboBoxSzolgaltatas.SelectedItem = value.SzolgaltatasNev;
            }
        }

        public BindingList<string> services
        {
            set => comboBoxSzolgaltatas.DataSource = value;
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
