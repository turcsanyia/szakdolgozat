using Medi2020.Presenters;
using Medi2020.ViewInterfaces;
using System;
using System.ComponentModel;
using System.Windows.Forms;
using Medi2020.Models;

namespace Medi2020.Views
{
    public partial class FormDoctorsList : Form, IDataGridList<doctor>
    {
        private DoctorsListPresenter presenter;

        private int pageCount;
        private int sortIndex;

        public BindingList<doctor> bindingList
        {
            get => (BindingList<doctor>) dataGridViewDoctors.DataSource;
            set => dataGridViewDoctors.DataSource = value;
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

        public FormDoctorsList()
        {
            InitializeComponent();
            presenter = new DoctorsListPresenter(this);
            dataGridViewDoctors.AutoGenerateColumns = false;
        }

        private void FormDoctors_Load(object sender, EventArgs e)
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

        private void dataGridViewDoctors_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (sortIndex == e.ColumnIndex)
            {
                ascending = !ascending;
            }

            switch (e.ColumnIndex)
            {
                case 1:
                    sortBy = "Keresztnév";
                    break;
                case 2:
                    sortBy = "Szakterület";
                    break;
                default:
                    sortBy = "Vezetéknév";
                    break;
            }

            sortIndex = e.ColumnIndex;
            presenter.LoadData();
        }

        private void hozzáadásToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var formDoctor = new FormDoctor())
            {
                DialogResult dr = formDoctor.ShowDialog(this);

                if (dr == DialogResult.OK)
                {
                    try
                    {
                        presenter.Add(formDoctor.doctor);
                        formDoctor.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void szerkesztésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridViewDoctors.SelectedRows != null)
            {
                var sorIndex = dataGridViewDoctors.SelectedCells[0].RowIndex;
                dataGridViewDoctors.ClearSelection();
                dataGridViewDoctors.Rows[sorIndex].Selected = true;
            }

            int index = dataGridViewDoctors.SelectedRows[0].Index;
            var doctor = (doctor) dataGridViewDoctors.Rows[index].DataBoundItem;

            if (doctor != null)
            {
                using (var formDoctor = new FormDoctor())
                {
                    formDoctor.doctor = doctor;
                    DialogResult dr = formDoctor.ShowDialog(this);

                    if (dr == DialogResult.OK)
                    {
                        try
                        {
                            presenter.Modify(formDoctor.doctor, index);
                            formDoctor.Close();
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
            if (dataGridViewDoctors.SelectedRows != null)
            {
                var sorIndex = dataGridViewDoctors.SelectedCells[0].RowIndex;
                dataGridViewDoctors.ClearSelection();
                dataGridViewDoctors.Rows[sorIndex].Selected = true;

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
