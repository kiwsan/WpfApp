using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.Services;
using WpfApp1.ViewModels.Interfaces;

namespace WpfApp1.ViewModels.Implements
{
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
