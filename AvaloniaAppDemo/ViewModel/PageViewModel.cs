using Avalonia.Controls;
using CommunityToolkit.Mvvm.ComponentModel;

namespace AvaloniaAppDemo.ViewModel;

public partial class PageViewModel : BaseViewModel
{
    [ObservableProperty] private string _pageName  = "";

    public PageViewModel(string pageName)
    {
        PageName = pageName;

        if (Design.IsDesignMode)
        {
            DesignTimeConstruction();
        }
    }

    protected PageViewModel()
    {
    }
    
    /// <summary>
    /// 供Avalonia设计器使用
    /// </summary>
    protected virtual void DesignTimeConstruction()
    {
    }
}