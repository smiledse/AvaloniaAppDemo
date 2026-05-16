using AvaloniaAppDemo.ViewModel;
using CommunityToolkit.Mvvm.ComponentModel;

namespace AvaloniaAppDemo.Views.Pages.Actions.Partials;

public partial class ActionPrintViewModel : BaseViewModel
{
    [ObservableProperty] private string _id = "";
    [ObservableProperty] private string _jobName = "";
}