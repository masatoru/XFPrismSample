using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Reactive.Bindings;

using System.Reactive.Linq;

namespace XFPrismSample.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        public ReactiveCommand NextPageCommand { get; private set; }
        public ReactiveProperty<string> Password { get;private set; }=new ReactiveProperty<string>("");

        public MainPageViewModel(INavigationService navigationService) 
            : base (navigationService)
        {
            Title = "Main Page";

            this.NextPageCommand = this.Password
                .Select(x => x== $"arrows") // 暗号が合っていれば
                .ToReactiveCommand(); // 実行可能なCommandを作る
            this.NextPageCommand.Subscribe(async _ => await NavigationService.NavigateAsync("SecondPage"));
        }


    }
}
