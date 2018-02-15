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
        public ReadOnlyObservableCollection<Person> PeopleList { get; set; }
        public ReactiveProperty<Person> SelectedPerson { get; set; } = new ReactiveProperty<Person>();
        public ReactiveProperty<string> Title { get; set; } = new ReactiveProperty<string>();
        private IPersonManager PersonManager { get; set; }

        /// <summary>
        /// App.xaml.csでRegisterしたインタフェースを引数で受け取ることができる（DIの機能）
        /// </summary>
        /// <param name="navigationService"></param>
        /// <param name="personManager"></param>
        public MainPageViewModel(INavigationService navigationService, IPersonManager personManager)
        {
            Title.Value = "Main Page";

            NavigationService = navigationService;
            PersonManager = personManager;
            PeopleList = PersonManager.PeopleList.ToReadOnlyReactiveCollection();

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