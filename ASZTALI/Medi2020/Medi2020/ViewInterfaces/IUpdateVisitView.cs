using System.ComponentModel;
using Medi2020.ViewModels;

namespace Medi2020.ViewInterfaces
{
    public interface IUpdateVisitView
    {
        VisitVM visitVM { get; set; }
        BindingList<string> services { set; }
    }
}
