using System;
using Medi2020.Repositories;
using Medi2020.ViewInterfaces;

namespace Medi2020.Presenters
{
    public class MainPresenter
    {
        private IMainView view;

        public MainPresenter(IMainView view)
        {
            this.view = view;
        }

        public void LoadData()
        {
            using (var visitRepository = new VisitRepository())
            {
                view.HaviBevetel = visitRepository.GetHaviBevetel(DateTime.Now.Month);
                view.OsszesBevetel = visitRepository.GetOsszesBevetel();
            }
        }
    }
}
