using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoApp.Views;

namespace ToDoApp.ViewModel
{
    public partial class MainViewModel : ObservableObject
    {
        public MainViewModel(IConnectivity connectivity)
        {
            tasks = new ObservableCollection<string>();
            this.connectivity = connectivity;
        }

        [ObservableProperty]
        ObservableCollection<string> tasks;

        [ObservableProperty]
        string myTask;
        private readonly IConnectivity connectivity;

        [ICommand]
        async Task Add()
        {
            if(connectivity.NetworkAccess != NetworkAccess.Internet)
            {
                await Shell.Current.DisplayAlert("ERROR", "No Internet", "OK");
                return;
            }

            if (!string.IsNullOrWhiteSpace(MyTask))
            {
                Tasks.Add(MyTask);
                MyTask = string.Empty;
            }
        }

        [ICommand]
        void Delete(string task)
        {
            Tasks.Remove(task);
        }

        [ICommand]
        async Task Tap(string task)
        {
            await Shell.Current.GoToAsync($"{nameof(TaskDetailPage)}?MyTask={task}");
        }
    }
}
