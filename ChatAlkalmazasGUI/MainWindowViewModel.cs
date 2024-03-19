using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatAlkalmazasGUI
{
    public class MainWindowViewModel 
    {

        public RestCollection<Message> Messages { get; set; }



        public MainWindowViewModel()
        {
            //Messages = new RestCollection<Message>();
        }

    }
}
