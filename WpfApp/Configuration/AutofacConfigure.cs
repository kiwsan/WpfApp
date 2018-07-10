using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.Services;
using WpfApp1.ViewModels.Implements;
using WpfApp1.ViewModels.Interfaces;
using WpfApp1.Views.Implements;
using WpfApp1.Views.Interfaces;

namespace WpfApp1.Configuration
{
    public class AutofacConfigure
    {

        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<MainWindow>().As<IMainWindow>().SingleInstance();
            builder.RegisterType<MainViewModel>().As<IMainViewModel>().SingleInstance();

            builder.RegisterType<HelloService>().As<IHelloService>();

            return builder.Build();
        }

    }
}
