using ToDoApp.ViewModel;

namespace ToDoApp.Views;

public partial class MainView : ContentPage
{
	public MainView(MainViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}