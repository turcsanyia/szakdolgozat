using System;
using System.ComponentModel;
using System.Windows.Forms;
using Medi2020.Models;
using Medi2020.Presenters;
using Medi2020.ViewInterfaces;
using Medi2020.ViewModels;

namespace Medi2020.Views
{
    public partial class FormVisitsList : Form, IDataGridList<VisitVM>
    {
        private VisitsListPresenter presenter;

        private int pageCount;
        private int sortIndex;

        public BindingList<VisitVM> bindingList
        {
            get => (BindingList<VisitVM>) dataGridViewVisits.DataSource;
            set => dataGridViewVisits.DataSource = value;
        }

        public int pageNumber { get; set; } = 1;
        public int itemsPerPage { get; set; } = 20;
        public string search
        {
            get => toolStripTextBoxSearch.Text;
        }
        public string sortBy { get; set; } = "Id";
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

        public FormVisitsList()
        {
            InitializeComponent();
            presenter = new VisitsListPresenter(this);
            dataGridViewVisits.AutoGenerateColumns = false;
        }

        private void FormVisits_Load(object sender, EventArgs e)
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

        private void dataGridViewVisits_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (sortIndex == e.ColumnIndex)
            {
                ascending = !ascending;
            }

            switch (e.ColumnIndex)
            {
                case 1:
                    sortBy = "Beteg neve";
                    break;
                case 2:
                    sortBy = "Orvos neve";
                    break;
                case 3:
                    sortBy = "Igénybe vett szolgáltatás";
                    break;
                default:
                    sortBy = "Rendelés időpontja";
                    break;
            }

            sortIndex = e.ColumnIndex;
            presenter.LoadData();
        }

        private void szerkesztésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridViewVisits.SelectedRows != null)
            {
                var sorIndex = dataGridViewVisits.SelectedCells[0].RowIndex;
                dataGridViewVisits.ClearSelection();
                dataGridViewVisits.Rows[sorIndex].Selected = true;
            }

            int index = dataGridViewVisits.SelectedRows[0].Index;
            var visitVM = (VisitVM) dataGridViewVisits.Rows[index].DataBoundItem;

            if (visitVM != null)
            {
                using (var formVisit = new FormUpdateVisit())
                {
                    formVisit.visitVM = visitVM;
                    DialogResult dr = formVisit.ShowDialog(this);

                    if (dr == DialogResult.OK)
                    {
                        try
                        {
                            presenter.Modify(formVisit.visitVM, index);
                            formVisit.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void törlésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridViewVisits.SelectedRows != null)
            {
                var sorIndex = dataGridViewVisits.SelectedCells[0].RowIndex;
                dataGridViewVisits.ClearSelection();
                dataGridViewVisits.Rows[sorIndex].Selected = true;

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

        private void hozzáadásToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var formVisit = new FormAddVisit())
            {
                DialogResult dr = formVisit.ShowDialog(this);

                if (dr == DialogResult.OK)
                {
                    try
                    {
                        presenter.Add(formVisit.visitVM);
                        formVisit.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void toolStripButtonSave_Click(object sender, EventArgs e)
        {
            presenter.Save();
        }
    }
}
