using System;
using System.Linq;
using Medi2020.Models;
using Medi2020.Repositories;
using Medi2020.ViewInterfaces;

namespace Medi2020.Presenters
{
    public class DoctorsListPresenter
    {
        private IDataGridList<doctor> view;
        private DoctorRepository repository = new DoctorRepository();


        public DoctorsListPresenter(IDataGridList<doctor> view)
        {
            this.view = view;
        }

        public void LoadData()
        {
            view.bindingList = repository.GetAllDoctors(view.pageNumber, view.itemsPerPage, view.search, view.sortBy,
                view.ascending);
            view.totalItems = repository.Count();
        }

        public void Add(doctor doctor)
        {
            try
            {
                repository.Insert(doctor);
                view.bindingList.Add(doctor);
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

        public void Remove(int index)
        {
            var doctor = view.bindingList.ElementAt(index);

            using (var visitRepository = new VisitRepository())
            {
                foreach (var visitVM in visitRepository.GetAllVisits())
                {
                    if (visitVM.OrvosId == doctor.Id)
                    {
                        throw new Exception("Az adott orvosnak volt rendelése, nem törölhetők az adatai.");
                    }
                }
            }

            repository.Delete(doctor.Id);
            view.bindingList.RemoveAt(index);
        }

        public void Modify(doctor doctor, int index)
        {
            try
            {
                repository.Update(doctor);
                view.bindingList.RemoveAt(index);
                view.bindingList.Insert(index, doctor);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
