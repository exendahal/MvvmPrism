using BlankApp1.Views;
using Prism.Commands;
using Prism.Events;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlankApp1.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {

        IEventAggregator _e;
        public DelegateCommand SubmitCommand { get; private set; }
        private readonly INavigationService _navigationService;
        public MainPageViewModel(IEventAggregator e, INavigationService navigationService)
            : base(navigationService)
        {
            _navigationService = navigationService;
            _e = e;
            Title = "Main Page";
            SubmitCommand = new DelegateCommand(Submit);
        }
        async void Submit()
        {
            //implement logic
            var p = new NavigationParameters();
            p.Add("title","Page 2");
            var response=await _navigationService.NavigateAsync("PrismContentPage1", p);

            //Event Aggregrator
            _e.GetEvent<MessageSentEvent>().Publish("Hello from page 1");

        }

       
    }
}
