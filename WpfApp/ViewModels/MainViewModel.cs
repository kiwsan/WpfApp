using WpfApp1.Services;

namespace WpfApp1.ViewModels
{
    public interface IMainViewModel
    {
        string Title { get; }

    }

    public class MainViewModel : IMainViewModel
    {

        private readonly IHelloService _helloService;
        public MainViewModel(IHelloService _helloService)
        {
            this._helloService = _helloService;
        }

        public string Title { get => _helloService.Say(); }

    }
}
