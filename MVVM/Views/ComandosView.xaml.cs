using MVVM_PELP.MVVM.ViewModels;
namespace MVVM_PELP.MVVM.Views;

public partial class ComandosView : ContentPage
{
	public ComandosView()
	{
		InitializeComponent();

        BindingContext = new ComandosViewModel();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {

    }
}