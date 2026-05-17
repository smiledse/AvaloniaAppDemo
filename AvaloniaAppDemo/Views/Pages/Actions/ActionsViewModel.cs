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

    [ObservableProperty] private ActionPrintViewModel _selectedPrint = new();
    
    private void FetchPrintList()
    {
        PrintList = [
            new ActionPrintViewModel()
            {
                Id = "1", 
                JobName = "Print Only Drawings",
                Description = "description",
                IsModels = true,
                IsDrawings = true,
                PringPage = "1",
                DrawingExclusionIsWhiteList = true,
                DrawingExclusionList = ""
            },
            new ActionPrintViewModel()
            {
                Id = "2", 
                JobName = "Print Only Drawings2",
                Description = "description",
                IsModels = true,
                IsDrawings = true,
                PringPage = "1",
                DrawingExclusionIsWhiteList = true,
                DrawingExclusionList = ""
            },
            new ActionPrintViewModel()
            {
                Id = "3", 
                JobName = "Print Only Drawings3",
                Description = "description",
                IsModels = true,
                IsDrawings = true,
                PringPage = "1",
                DrawingExclusionIsWhiteList = true,
                DrawingExclusionList = ""
            },
        ];
        SelectedPrint = PrintList[2];
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