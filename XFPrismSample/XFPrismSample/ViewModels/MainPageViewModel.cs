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
    public class MainPageViewModel : BindableBase, INavigationAware
    {
        protected INavigationService NavigationService { get; private set; }
        public ReactiveCommand DetailPageCommand { get; private set; } /*= new ReactiveCommand();*/
        public ObservableCollection<Person> PeopleList { get; set; }
        public ReactiveProperty<Person> SelectedPerson { get; set; } = new ReactiveProperty<Person>();
        public ReactiveProperty<string> Title { get; set; } = new ReactiveProperty<string>();

        public MainPageViewModel(INavigationService navigationService)
        {
            NavigationService = navigationService;
            Title.Value = "Main Page";

            PeopleList = new ObservableCollection<Person>()
            {
                new Person {Id = 1, Name = "Ohtani"},
                new Person {Id = 2, Name = "Darvish"},
                new Person {Id = 3, Name = "Tanaka"},
            };

            // 選択されていればDetailPageをタップできる
            this.DetailPageCommand = this.SelectedPerson
                .Select(x => x != null)
                .ToReactiveCommand();

            // DetailPageを表示する
            // 選択されたPseronを引数にに渡す
            this.DetailPageCommand.Subscribe(async _ =>
            {
                var navigationParameters = new NavigationParameters();
                navigationParameters.Add("person", SelectedPerson.Value);
                // MainPageの次にDetailPageがスタックされる（MainPageに戻るボタンが表示される）
                // "/DetailPage"だと1枚目になる
                await NavigationService.NavigateAsync("DetailPage", navigationParameters);
            });
        }

        public void OnNavigatedFrom(NavigationParameters parameters)
        {
        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {
        }

        public void OnNavigatingTo(NavigationParameters parameters)
        {
        }
    }
}