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

        public ComandosViewModel()
        {
            ClickCommand = new Command(() =>
            {
                App.Current.MainPage.DisplayAlert("Comando", "Has presionado el botón", "OK");
            });
        }

        private void Alert()
        {

        }
    }

    
}
