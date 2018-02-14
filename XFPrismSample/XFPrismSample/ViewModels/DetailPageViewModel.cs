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
        public ReactiveProperty<Person> DetailPerson { get; set; } = new ReactiveProperty<Person>();
        public DetailPageViewModel()
        {

        }

        public void OnNavigatedFrom(NavigationParameters parameters)
        {
        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {
            if (parameters.ContainsKey("person"))
                DetailPerson.Value = (Person)parameters["person"];
        }

        public void OnNavigatingTo(NavigationParameters parameters)
        {
        }
    }
}
