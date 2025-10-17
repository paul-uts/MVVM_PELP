using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_PELP.MVVM.ViewModels
{
    internal class GenteViewModel
    {
        public List<string> Gente { get; set; }

        public GenteViewModel()
        {
            Gente = new List<string>
            {
                "Ana",
                "Carlos",
                "Remigio",
                "Chepe",
                "Ulises",
                "Ernesto"
            };
        }
    }
}
