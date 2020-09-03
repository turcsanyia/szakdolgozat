using System;
using System.Windows.Forms;
using Medi2020.Presenters;
using Medi2020.ViewInterfaces;

namespace Medi2020.Views
{
    public partial class FormMain : Form, IMainView
    {
        private MainPresenter presenter;

        public double HaviBevetel { get; set; }
        public double OsszesBevetel { get; set; }

        public FormMain()
        {
            InitializeComponent();
            presenter = new MainPresenter(this);
        }

        private void toolStripMenuItemBetegfelvetel_Click(object sender, EventArgs e)
        {
            var formPatients = new FormPatientsList();
            formPatients.MdiParent = this;
            formPatients.Show();
        }

        private void toolStripMenuItemOrvosok_Click(object sender, EventArgs e)
        {
            var formDoctors = new FormDoctorsList();
            formDoctors.MdiParent = this;
            formDoctors.Show();
        }

        private void toolStripMenuItemOrvosiRendelesek_Click(object sender, EventArgs e)
        {
            var formVisits = new FormVisitsList();
            formVisits.MdiParent = this;
            formVisits.Show();
        }

        private void toolStripMenuItemKilepes_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void toolStripMenuItemPenzugyek_Click(object sender, EventArgs e)
        {
            presenter.LoadData();

            MessageBox.Show("Ehavi bevétel (" + DateTime.Now.Month + ". hónap):\n" +
                            HaviBevetel.ToString("C0") + "\n\nÖsszes bevétel:\n" +
                            OsszesBevetel.ToString("C0"), "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
