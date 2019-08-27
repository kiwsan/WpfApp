using System.Collections.ObjectModel;
using System.Windows.Input;
using WpfApp1.Domain.Models;
using WpfApp1.Services;
using WpfApp1.Services.Interfaces;
using WpfApp1.ViewModels.Interfaces;

namespace WpfApp1.ViewModels.Implements
{
    public class MainViewModel : ViewModelBase, IMainViewModel
    {

        private readonly IPersonService _personService;
        private readonly IHelloService _helloService;
        public MainViewModel(IPersonService _personService,
            IHelloService _helloService)
        {
            this._personService = _personService;
            this._helloService = _helloService;

            UpdatePersonCommand = new RelayCommand<Person>(SelectedPerson);

            var remotePersons = _personService.GetAll();

            Persons = new ObservableCollection<Person>(remotePersons);
        }

        public string Title
            => "Hello MVVM";

        public ObservableCollection<Person> Persons { get; set; }
        public ICommand UpdatePersonCommand { get; set; }
        public string SelectedPersonName { get; set; }

        private void SelectedPerson(Person person)
        {
            if (person != null)
            {
                this.SelectedPersonName = person.Name;
                // better to go for full property instead of calling property change here 
                this.RaisePropertyChanged(nameof(SelectedPersonName));
            }
        }

    }
}
