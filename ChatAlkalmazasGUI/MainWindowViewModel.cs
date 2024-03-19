﻿using Microsoft.Toolkit.Mvvm.Input;
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

        public string Name { get; set; }

        public string ActualMessage { get; set; }

        public MainWindowViewModel()
        {
            if (!IsInDesignMode)
            {
                Messages = new RestCollection<Message>("http://localhost:33653/", "message", "hub");

                Messages.Add(new Message()
                {
                    Sender = "Jack",
                    SentMessage = "Hi all"
                });

                if (Name == null)
                {
                    Name = "Unknown";
                }

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
