using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVM_PELP.MVVM.Views
{
    public class ComandosViewModel
    {
        public ICommand ClickCommand { get; }

        public ICommand SearchCommand { get; }

        public string SearchData { get; set; }

        public ComandosViewModel()
        {
            ClickCommand = new Command(() =>
            {
                App.Current.MainPage.DisplayAlert("Comando", "Has presionado el botón", "OK");
            });

            SearchCommand = new Command(() =>
            {
                var data = SearchData;
            });
        }

        private void Alert()
        {

        }
    }

    
}
