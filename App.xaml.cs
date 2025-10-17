using MVVM_PELP.MVVM.Views;

namespace MVVM_PELP
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new ComandosView();
        }
    }
}
