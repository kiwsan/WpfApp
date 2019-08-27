using System.Collections.ObjectModel;
using System.Windows.Input;
using WpfApp1.Domain.Models;

namespace WpfApp1.ViewModels.Interfaces
{
    public interface IMainViewModel
    {
        string Title { get; }
        ObservableCollection<Person> Persons { get; set; }
        ICommand UpdatePersonCommand { get; set; }
        string SelectedPersonName { get; set; }
    }
}
