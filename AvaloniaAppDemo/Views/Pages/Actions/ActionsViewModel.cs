using System.Collections.ObjectModel;
using AvaloniaAppDemo.ViewModel;
using AvaloniaAppDemo.Views.Pages.Actions.Partials;
using CommunityToolkit.Mvvm.ComponentModel;

namespace AvaloniaAppDemo.Views.Pages.Actions;

public partial class ActionsViewModel() : PageViewModel("Actions")
{
    [ObservableProperty]
    private ObservableCollection<ActionPrintViewModel> _printList;

    
    [ObservableProperty]
    private string _jobName = "";
    
    private void FetchPrintList()
    {
        PrintList = [
            new ActionPrintViewModel(){Id = "1", JobName = "Print Only Drawings"},
            new ActionPrintViewModel(){Id = "1", JobName = "Print All Drawings Scale To Fit"},
            new ActionPrintViewModel(){Id = "1", JobName = "Print 39 Models A3"}
        ];

        JobName = "dawdwadawd";
    }
    

    protected override void DesignTimeConstruction()
    {
        FetchPrintList();
    }
}