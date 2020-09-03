using System;
using System.Linq;
using Medi2020.Repositories;
using Medi2020.ViewInterfaces;
using Medi2020.ViewModels;

namespace Medi2020.Presenters
{
    public class VisitsListPresenter
    {
        private IDataGridList<VisitVM> view;
        private VisitRepository repository = new VisitRepository();

        public VisitsListPresenter(IDataGridList<VisitVM> param)
        {
            view = param;
        }

        public void LoadData()
        {
            view.bindingList = repository.GetAllVisits(view.pageNumber, view.itemsPerPage, view.search, view.sortBy,
                view.ascending);
            view.totalItems = repository.Count();
        }

        public void Add(VisitVM visitVM)
        {
            try
            {
                repository.Insert(visitVM);
                view.bindingList.Add(visitVM);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Remove(int index)
        {
            var visitVM = view.bindingList.ElementAt(index);

            if (visitVM.VisitId > 0)
            {
                try
                {
                    repository.Delete(visitVM.VisitId);
                    view.bindingList.RemoveAt(index);
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        public void Modify(VisitVM visitVM, int index)
        {
            using (var serviceRepository = new ServiceRepository())
            {
                visitVM.SzolgaltatasId = serviceRepository.GetServiceByName(visitVM.SzolgaltatasNev).Id;
            }

            try
            {
                repository.Update(visitVM);
                view.bindingList.RemoveAt(index);
                view.bindingList.Insert(index, visitVM);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Save()
        {
            repository.Save();
        }
    }
}
