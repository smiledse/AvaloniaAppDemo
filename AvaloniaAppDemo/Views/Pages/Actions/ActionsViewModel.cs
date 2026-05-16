using System.Collections.ObjectModel;
using AvaloniaAppDemo.ViewModel;
using AvaloniaAppDemo.Views.Pages.Actions.Partials;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace AvaloniaAppDemo.Views.Pages.Actions;

public partial class ActionsViewModel() : PageViewModel("Actions")
{
    [ObservableProperty]
    private ObservableCollection<ActionPrintViewModel> _printList = [];
    
    private void FetchPrintList()
    {
        PrintList = [
            new ActionPrintViewModel(){Id = "1", JobName = "Print Only Drawings"},
            new ActionPrintViewModel(){Id = "1", JobName = "Print All Drawings Scale To Fit"},
            new ActionPrintViewModel(){Id = "1", JobName = "Print 39 Models A3"}
        ];
    }
    

    protected override void DesignTimeConstruction()
    {
        FetchPrintList();
    }
    
    [RelayCommand]
    public void OnRefreshCommand(ActionsPageName actionsPageName)
    {
        switch (actionsPageName)
        {
            case ActionsPageName.Print: FetchPrintList(); break;
        }
    }
}