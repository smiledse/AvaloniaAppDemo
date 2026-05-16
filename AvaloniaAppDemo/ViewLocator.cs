using System;
using Avalonia.Controls;
using Avalonia.Controls.Templates;
using AvaloniaAppDemo.ViewModel;

namespace AvaloniaAppDemo;

public class ViewLocator : IDataTemplate
{ 

    public bool Match(object? data) => data is PageViewModel;
    public Control? Build(object? param)
    {
        if (param is null) return null;

        var viewName =
            param.GetType().FullName!.Replace("ViewModel", "Page", StringComparison.CurrentCultureIgnoreCase);

        var type = Type.GetType(viewName);
        if (type is null)
        {
            return null;
        }

        if (param is PageViewModel viewModel)
        {
            viewModel.PageName = param.GetType().Name.Replace("ViewModel", "", StringComparison.CurrentCultureIgnoreCase);
        }
        var control = (Control)Activator.CreateInstance(type)!;
        control.DataContext = param;
        return control;
    }
}