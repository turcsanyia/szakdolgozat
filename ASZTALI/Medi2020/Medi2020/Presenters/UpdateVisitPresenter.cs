using System.ComponentModel;
using Medi2020.Repositories;
using Medi2020.ViewInterfaces;

namespace Medi2020.Presenters
{
    public class UpdateVisitPresenter
    {
        private IUpdateVisitView view;

        public UpdateVisitPresenter(IUpdateVisitView param)
        {
            view = param;
        }

        public void LoadData()
        {
            using (var serviceRepository = new ServiceRepository())
            {
                var services = new BindingList<string>();

                foreach (var service in serviceRepository.GetAllServices(sortBy: "Nev"))
                {
                    services.Add(service.Nev);
                }

                view.services = services;
            }
        }
    }
}
