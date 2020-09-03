using System;
using Medi2020.Models;
using Medi2020.Repositories;
using Medi2020.ViewInterfaces;

namespace Medi2020.Presenters
{
    public class PatientPresenter
    {
        private IPatientView view;
        private PatientRepository repository = new PatientRepository();

        public PatientPresenter(IPatientView param)
        {
            view = param;
        }

        public void Validate(patient patient)
        {
            try
            {
                repository.ValidatePatient(patient);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool IsExisting(string taj, bool hozzaadas)
        {
            if (hozzaadas)
            {
                return repository.IsExisting(taj);
            }

            return false;
        }
    }
}
