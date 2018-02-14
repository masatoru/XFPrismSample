using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using Reactive.Bindings;
using System.Reactive.Linq;
using XFPrismSample.Models;

namespace XFPrismSample.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        public ReactiveCommand DetailPageCommand { get; private set; } /*= new ReactiveCommand();*/
        public ObservableCollection<Person> PeopleList { get; set; }
        public ReactiveProperty<Person> SelectedPerson { get; set; } = new ReactiveProperty<Person>();

        public MainPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "Main Page";

            PeopleList = new ObservableCollection<Person>()
            {
                new Person {Id = 1, Name = "Ohtani"},
                new Person {Id = 2, Name = "Darvish"},
                new Person {Id = 3, Name = "Tanaka"},
            };

            this.DetailPageCommand = this.SelectedPerson
                .Select(x => x != null) // 選択されていれば
                .ToReactiveCommand(); // 実行可能なCommandを作る

            this.DetailPageCommand.Subscribe(async _ => await NavigationService.NavigateAsync("DetailPage"));
        }
    }
}