﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Services
{
    public class HelloService : IHelloService
    {
        public string Say()
        {
            return "Hello Wpf";
        }
    }
}
