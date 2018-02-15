using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;

namespace XFPrismSample.Models
{
    public interface IPersonManager
    {
        ObservableCollection<Person> PeopleList { get; set; }
    }
}
