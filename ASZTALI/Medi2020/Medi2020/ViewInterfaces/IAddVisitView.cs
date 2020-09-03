using System.ComponentModel;
using Medi2020.Models;
using Medi2020.ViewModels;

namespace Medi2020.ViewInterfaces
{
    public interface IAddVisitView
    {
        VisitVM visitVM { get; set; }
        BindingList<patient> patients { get; set; }
        BindingList<doctor> doctors { get; set; }
        BindingList<service> services { get; set; }
    }
}
