using Microsoft.Toolkit.Mvvm.Input;
using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace ChatAlkalmazasGUI
{
    public class MainWindowViewModel 
    {

        public RestCollection<Message> Messages { get; set; }

        public ICommand SendMessage { get; set; }

        public static bool IsInDesignMode
        {
            get
            {
                var prop = DesignerProperties.IsInDesignModeProperty;
                return (bool)DependencyPropertyDescriptor.FromProperty(prop, typeof(FrameworkElement)).Metadata.DefaultValue;
            }
        }




        private string name ;

        public string Name
        {
            get
            {
                
                return name=="" ? "Unknown" : name; 
            }
            set { name = value; }
        }


        private string actualMessage;

        public string ActualMessage
        {
            get { return actualMessage; }
            set { actualMessage = value; }
        }


        public MainWindowViewModel()
        {

            if (!IsInDesignMode)
            {
                Name = "Unknown";

                Messages = new RestCollection<Message>("http://localhost:33653/", "message", "hub");

                Messages.Add(new Message()
                {
                    Sender = "Jack",
                    SentMessage = "Hi all"
                });


                SendMessage = new RelayCommand(() =>
                {
                    Messages.Add(new Message()
                    {
                        Sender = Name,
                        SentMessage = ActualMessage
                    });
                });


            }
           
        }

    }
}
