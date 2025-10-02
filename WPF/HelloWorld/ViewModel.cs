using Prism;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace HelloWorld {
    class ViewModel : BindableBase {
        public ViewModel() {
            ChangeMessageCommand = new DelegateCommand<string>(
                (par) => GreetingMessage = par,
                (par) => GreetingMessage != par)
                .ObservesProperty(() => GreetingMessage);
        }

        private string _greetingMessage = "Hello World";
        public string GreetingMessage {
            get => _greetingMessage;
            set => SetProperty(ref _greetingMessage, value);        


            }
        //    {
        //    if (_greetingMessage != value) {
        //        _greetingMessage = value;
        //        PropertyChanged?.Invoke(
        //             this, new PropertyChangedEventArgs(nameof(GreetingMessage)));
        //    }
        //}

        private bool _canChangeMessage = true;
        public bool CanChangeMessage {
            get => _canChangeMessage;
            private set => SetProperty(ref _canChangeMessage, value);
        }
        public string NewMessage1 { get; } = "I will kill you";
        public string NewMessage2 { get; } = "You asshole";
        public DelegateCommand<string> ChangeMessageCommand { get; }

        //public event PropertyChangedEventHandler? PropertyChanged;
    }
}
