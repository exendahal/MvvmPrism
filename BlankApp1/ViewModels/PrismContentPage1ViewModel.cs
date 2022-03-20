using Prism.Commands;
using Prism.Events;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BlankApp1.ViewModels
{
    public class PrismContentPage1ViewModel : BindableBase,INavigationAware
    {
        public PrismContentPage1ViewModel(IEventAggregator e)
        {
            e.GetEvent<MessageSentEvent>().Subscribe(messageReceived);
        }

        private void messageReceived(string obj)
        {
            var value = obj;
        }

        public void OnNavigatedFrom(INavigationParameters parameters)
        {
            var navigationMode = parameters.GetNavigationMode();
        }

        public void OnNavigatedTo(INavigationParameters parameters)
        {
            var aa = parameters.GetValue<string>("title");
        }

        public void OnNavigatingTo(INavigationParameters parameters)
        {
            throw new NotImplementedException();
        }
    }
}
