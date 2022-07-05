using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApp.ViewModel
{
    [QueryProperty("MyTask", "MyTask")]
    public partial class TaskDetailViewModel : ObservableObject
    {
        [ObservableProperty]
        string myTask;

        [ICommand]
        async Task GoBack()
        {
            await Shell.Current.GoToAsync("..");
        }
    }
}
