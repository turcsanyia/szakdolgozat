using Medi2020.Models;
using Medi2020.Repositories;
using Medi2020.ViewInterfaces;

namespace Medi2020.Presenters
{
    public class AddVisitPresenter
    {
        private IAddVisitView view;

        public AddVisitPresenter(IAddVisitView param)
        {
            view = param;
        }

        public void LoadData()
        {
            using (var doctorRepository = new DoctorRepository())
            {
                view.doctors = doctorRepository.GetAllDoctors(sortBy: "Vezetéknév");
            }

            using (var patientRepository = new PatientRepository())
            {
                view.patients = patientRepository.GetAllPatients(sortBy: "Vezetéknév");
            }

            using (var serviceRepository = new ServiceRepository())
            {
                view.services = serviceRepository.GetAllServices(sortBy: "Nev");
            }
        }
    }
}
