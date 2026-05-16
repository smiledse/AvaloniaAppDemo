using Avalonia.Controls;
using Avalonia.Interactivity;
using AvaloniaAppDemo.views;

namespace AvaloniaAppDemo.Views;
public partial class MainWindow : Window {
    public MainWindow()
    {
        InitializeComponent();
    }

    private void Button_OnClick(object? sender, RoutedEventArgs e)
    {
        (DataContext as MainWindowViewModel)?.ToogleSideMenuCommand?.Execute(null);
    }
}
