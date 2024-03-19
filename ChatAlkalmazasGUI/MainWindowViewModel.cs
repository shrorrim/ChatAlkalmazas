using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ChatAlkalmazasGUI
{
    public class MainWindowViewModel 
    {

        public RestCollection<Message> Messages { get; set; }

        public ICommand SendMessage { get; set; }


        public MainWindowViewModel()
        {
           Messages = new RestCollection<Message>("http://localhost:33653/","message","hub");
        }

    }
}
