using MVVM_PELP.MVVM.ViewModels;

namespace MVVM_PELP.MVVM.Views;

public partial class GenteView : ContentPage
{
	public GenteView()
	{
		InitializeComponent();

		BindingContext = new GenteViewModel();
	}
}