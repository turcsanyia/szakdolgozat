using Medi2020.Presenters;
using Medi2020.ViewInterfaces;
using System;
using System.ComponentModel;
using System.Windows.Forms;
using Medi2020.Models;

namespace Medi2020.Views
{
    public partial class FormPatientsList : Form, IDataGridList<patient>
    {
        private PatientsListPresenter presenter;

        private int pageCount;
        private int sortIndex = 0;

        public BindingList<patient> bindingList
        {
            get => (BindingList<patient>) dataGridViewPatients.DataSource;
            set => dataGridViewPatients.DataSource = value;
        }

        public int pageNumber { get; set; } = 1;
        public int itemsPerPage { get; set; } = 20;

        public string search
        {
            get => toolStripTextBoxSearch.Text;
        }

        public string sortBy { get; set; } = "Taj";
        public bool ascending { get; set; } = true;

        public int totalItems
        {
            set
            {
                pageCount = (value - 1) / itemsPerPage + 1;
                label1.Text = pageNumber.ToString() + "/" + pageCount.ToString();
                OsszesLabel.Text = "Összesen: " + value.ToString();
            }
        }

        public FormPatientsList()
        {
            InitializeComponent();
            presenter = new PatientsListPresenter(this);
            dataGridViewPatients.AutoGenerateColumns = false;
        }

        private void FormPatiens_Load(object sender, EventArgs e)
        {
            presenter.LoadData();
        }

        private void FirstButton_Click(object sender, EventArgs e)
        {
            pageNumber = 1;
            presenter.LoadData();
        }

        private void PrevButton_Click(object sender, EventArgs e)
        {
            if (pageNumber != 1)
            {
                pageNumber--;
                presenter.LoadData();
            }
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            if (pageNumber != pageCount)
            {
                pageNumber++;
                presenter.LoadData();
            }
        }

        private void LastButton_Click(object sender, EventArgs e)
        {
            pageNumber = pageCount;
            presenter.LoadData();
        }

        private void toolStripButtonSearch_Click(object sender, EventArgs e)
        {
            presenter.LoadData();
        }

        private void dataGridViewPatients_ColumnHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (sortIndex == e.ColumnIndex)
            {
                ascending = !ascending;
            }

            switch (e.ColumnIndex)
            {
                case 1:
                    sortBy = "Vezetéknév";
                    break;
                case 2:
                    sortBy = "Keresztnév";
                    break;
                case 3:
                    sortBy = "Irányítószám";
                    break;
                case 4:
                    sortBy = "Település";
                    break;
                case 5:
                    sortBy = "Lakcím";
                    break;
                case 6:
                    sortBy = "E-mail cím";
                    break;
                case 7:
                    sortBy = "Telefon";
                    break;
                default:
                    sortBy = "TAJ szám";
                    break;
            }

            sortIndex = e.ColumnIndex;
            presenter.LoadData();
        }

        private void hozzáadásToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var formPatient = new FormPatient())
            {
                DialogResult dr = formPatient.ShowDialog(this);

                if (dr == DialogResult.OK)
                {
                    presenter.Add(formPatient.patient);
                    formPatient.Close();
                }
            }
        }

        private void szerkesztésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridViewPatients.SelectedRows != null)
            {
                var sorIndex = dataGridViewPatients.SelectedCells[0].RowIndex;
                dataGridViewPatients.ClearSelection();
                dataGridViewPatients.Rows[sorIndex].Selected = true;
            }

            int index = dataGridViewPatients.SelectedRows[0].Index;
            var patient = (patient) dataGridViewPatients.Rows[index].DataBoundItem;

            if (patient != null)
            {
                using (var formPatient = new FormPatient())
                {
                    formPatient.patient = patient;
                    DialogResult dr = formPatient.ShowDialog(this);

                    if (dr == DialogResult.OK)
                    {
                        presenter.Modify(formPatient.patient, index);
                        formPatient.Close();
                    }
                }
            }
        }

        private void törlésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridViewPatients.SelectedRows != null)
            {
                var sorIndex = dataGridViewPatients.SelectedCells[0].RowIndex;
                dataGridViewPatients.ClearSelection();
                dataGridViewPatients.Rows[sorIndex].Selected = true;

                try
                {
                    presenter.Remove(sorIndex);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void toolStripButtonSave_Click(object sender, EventArgs e)
        {
            presenter.Save();
        }
    }
}
