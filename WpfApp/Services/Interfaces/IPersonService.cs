using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.Domain.Models;

namespace WpfApp1.Services.Interfaces
{
    public interface IPersonService
    {
        IEnumerable<Person> GetAll();
    }
}
