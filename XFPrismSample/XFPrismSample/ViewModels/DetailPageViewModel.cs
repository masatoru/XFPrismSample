using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using Prism.Navigation;
using Reactive.Bindings;
using XFPrismSample.Models;

namespace XFPrismSample.ViewModels
{
    public class DetailPageViewModel : BindableBase, INavigationAware
    {
        public ReactiveProperty<int> Id { get; set; } = new ReactiveProperty<int>();
        public ReactiveProperty<string> Name { get; set; } = new ReactiveProperty<string>();

        public DetailPageViewModel()
        {
        }

        public void OnNavigatedFrom(NavigationParameters parameters)
        {
        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {
            if (parameters.ContainsKey("person"))
            {
                var person = (Person) parameters["person"];
                Id.Value = person.Id;
                Name.Value = person.Name;
            }
        }

        public void OnNavigatingTo(NavigationParameters parameters)
        {
        }
    }
}