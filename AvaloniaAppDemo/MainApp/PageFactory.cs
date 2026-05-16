using System;
using AvaloniaAppDemo.ViewModel;

namespace AvaloniaAppDemo.MainApp;

public class PageFactory(Func<Type, PageViewModel> factory)
{
      public PageViewModel GetPageViewModel(Type type) => factory(type);
}