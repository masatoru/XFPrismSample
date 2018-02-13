using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Reactive.Bindings;

namespace XFPrismSample.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        public ReactiveCommand NextPageCommand { get; private set; }=new ReactiveCommand();

        public MainPageViewModel(INavigationService navigationService) 
            : base (navigationService)
        {
            Title = "Main Page";

            //this.ClearCommand = this.Input
            //    .Select(x => !string.IsNullOrWhiteSpace(x)) // Input.Valueが空じゃないとき
            //    .ToReactiveCommand(); // 実行可能なCommandを作る
            this.NextPageCommand.Subscribe(async _ => await NavigationService.NavigateAsync("SecondPage"));
        }


    }
}
