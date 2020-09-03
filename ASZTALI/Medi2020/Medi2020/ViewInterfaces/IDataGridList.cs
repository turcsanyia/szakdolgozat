using System.ComponentModel;

namespace Medi2020.ViewInterfaces
{
    public interface IDataGridList<G>
    {
        BindingList<G> bindingList { get; set; }
        int pageNumber { get; set; }
        int itemsPerPage { get; set; }
        string search { get; }
        string sortBy { get; set; }
        bool ascending { get; set; }
        int totalItems { set; }
    }
}
