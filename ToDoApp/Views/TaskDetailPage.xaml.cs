using ToDoApp.ViewModel;

namespace ToDoApp.Views;

public partial class TaskDetailPage : ContentPage
{
	public TaskDetailPage(TaskDetailViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}