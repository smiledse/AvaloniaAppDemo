using System.ComponentModel;
using System.Text.Json;
using System.Text.Json.Serialization;
using AvaloniaAppDemo.ViewModel;
using CommunityToolkit.Mvvm.ComponentModel;

namespace AvaloniaAppDemo.Views.Pages.Actions.Partials;

public partial class ActionPrintViewModel : BaseViewModel
{
    [ObservableProperty] private string _id = "";

    [ObservableProperty] private string _jobName = "";

    [ObservableProperty] private string _description = "";

    [ObservableProperty] private string _pringPage = "";

    [ObservableProperty] private bool _checked = false;

    [ObservableProperty] private bool _isModels;

    [ObservableProperty] private bool _isDrawings;

    [ObservableProperty] private string _selectedPrinterSettingId = "";

    [ObservableProperty] private bool _drawingExclusionIsWhiteList;

    [ObservableProperty] private string _drawingExclusionList = "";

    [ObservableProperty] private bool _hasChanged;

    [ObservableProperty] [JsonIgnore] private bool _isNewItem;

    protected override void OnPropertyChanging(PropertyChangingEventArgs e)
    {
        base.OnPropertyChanging(e);
        if (e.PropertyName != nameof(HasChanged))
        {
            HasChanged = true;
        }
    }
}