using System.ComponentModel;
using Medi2020.Models;

namespace Medi2020.ViewInterfaces
{
    public interface IDoctorView
    {
        doctor doctor { get; set; }
        BindingList<specialization> specializations { get; set; }
    }
}
