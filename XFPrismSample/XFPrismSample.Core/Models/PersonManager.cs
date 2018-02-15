using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;

namespace XFPrismSample.Models
{
    public class PersonManager : IPersonManager
    {
        public ObservableCollection<Person> PeopleList { get; set; }
        public PersonManager()
        {
            PeopleList = new ObservableCollection<Person>()
            {
                new Person{Id=1,Name="Ohtani"},
                new Person{Id=2,Name="Darvish"},
                new Person{Id=3,Name="Tanaka"},
            };
        }
    }
}
