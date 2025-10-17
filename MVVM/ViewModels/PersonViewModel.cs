using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVVM_PELP.MVVM.Models;

namespace MVVM_PELP.MVVM.ViewModels
{
    internal class PersonViewModel
    {
        public Person Person { get; set; }
        public PersonViewModel()
        {
            Person = new Person()
            {
                Name = "paúl",
                Age = 27,
                Married = false,
                Birthday = new DateTime(1999, 3, 1),
                Weight = 90,
                LunchTime = new TimeSpan(14, 0, 0)
            };
        }
    }
}
