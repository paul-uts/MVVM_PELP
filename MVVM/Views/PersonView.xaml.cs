using MVVM_PELP.MVVM.ViewModels;

namespace MVVM_PELP.MVVM.Views;

public partial class PersonView : ContentPage
{
	public PersonView()
	{
		InitializeComponent();

		BindingContext = new PersonViewModel();
	}
}