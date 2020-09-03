using Medi2020.Repositories;
using Medi2020.ViewInterfaces;

namespace Medi2020.Presenters
{
    public class DoctorPresenter
    {
        private IDoctorView view;

        public DoctorPresenter(IDoctorView param)
        {
            view = param;
        }

        public void LoadData()
        {
            using (var specializationRepository = new SpecializationRepository())
            {
                view.specializations = specializationRepository.GetAllSpecializations();
            }
        }
    }
}
