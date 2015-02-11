using Codeplex.Reactive;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App13.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        public ReactiveProperty<string> Label { get; private set; }

        public ReactiveCommand AlertCommand { get; private set; }

        public MainViewModel()
        {
            this.Label = new ReactiveProperty<string>("Hello world");

            this.AlertCommand = new ReactiveCommand();
            this.AlertCommand.Subscribe(_ => this.MessengerInstance.Send(new NotificationMessage("こんにちは！")));
        }
    }
}
