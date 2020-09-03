using System;
using System.Linq;
using Medi2020.Models;
using Medi2020.Repositories;
using Medi2020.ViewInterfaces;

namespace Medi2020.Presenters
{
    public class PatientsListPresenter
    {
        private IDataGridList<patient> view;
        private PatientRepository repository = new PatientRepository();

        public PatientsListPresenter(IDataGridList<patient> param)
        {
            view = param;
        }

        public void LoadData()
        {
            view.bindingList = repository.GetAllPatients(view.pageNumber, view.itemsPerPage, view.search, view.sortBy,
                view.ascending);
            view.totalItems = repository.Count();
        }

        public void Add(patient patient)
        {
            try
            {
                repository.Insert(patient);
                view.bindingList.Add(patient);
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
            var patient = view.bindingList.ElementAt(index);

            using (var visitRepository = new VisitRepository())
            {
                foreach (var visitVM in visitRepository.GetAllVisits())
                {
                    if (visitVM.BetegTaj == patient.Taj)
                    {
                        throw new Exception("Az adott beteg volt már rendelésen, nem törölhetők az adatai.");
                    }
                }
            }

            repository.Delete(patient.Taj);
            view.bindingList.RemoveAt(index);
        }

        public void Modify(patient patient, int index)
        {
            repository.Update(patient);
            view.bindingList.RemoveAt(index);
            view.bindingList.Insert(index, patient);
        }
    }
}
