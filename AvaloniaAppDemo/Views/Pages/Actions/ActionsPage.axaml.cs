using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using AvaloniaAppDemo.ViewModel;
using AvaloniaAppDemo.Views.Pages.Actions.Partials;

namespace AvaloniaAppDemo.Views.Pages.Actions;

public partial class ActionsPage : UserControl
{
    public ActionsPage()
    {
        InitializeComponent();
    }

    private void SelectingItemsControl_OnSelectionChanged(object? sender, SelectionChangedEventArgs e)
    {
        if (Equals(e.Source, ActionsTabControl))
        {
            OnTabChanged();
        }
    }

    private void OnTabChanged()
    {
        var selectedPage = (ActionsTabControl?.SelectedItem as TabItem)?.Content as Control;

        if (selectedPage == null)
            return;

        var actionsPage = selectedPage switch
        {
            ActionsPrintView => ActionsPageName.Print,
            _ => ActionsPageName.Unknown
        };

        var viewModel = selectedPage.DataContext as ActionsViewModel;
        viewModel?.OnRefreshCommand(actionsPage);
    }

    protected override void OnInitialized()
    {
        OnTabChanged();
        
        base.OnInitialized();
    }
}