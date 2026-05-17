using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace AvaloniaAppDemo.Views.Pages.Actions.Partials;

public partial class ActionsPrintView : UserControl
{
    public ActionsPrintView()
    {
        InitializeComponent();
    }

    private void SelectingItemsControl_OnSelectionChanged(object? sender, SelectionChangedEventArgs e)
    {
        var context = DataContext as ActionsViewModel;
        if(context is null) return;

        var selectedItem = (e.AddedItems[0] as ActionPrintViewModel)!;
        context.SelectedPrint = selectedItem;
    }
}