using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Views
{
    public interface IMainWindow
    {

        void Close();
        void Hide();
        void Show();
        bool? ShowDialog();

    }
}
