using System;
using Avalonia.Controls;
using AvaloniaAppDemo.MainApp;
using AvaloniaAppDemo.ViewModel;
using AvaloniaAppDemo.Views.Pages;
using AvaloniaAppDemo.Views.Pages.Settings;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace AvaloniaAppDemo.views;

public partial class MainWindowViewModel : BaseViewModel
{
    [ObservableProperty] private string _title = "Hello World";
    
    [ObservableProperty] 
    [NotifyPropertyChangedFor(nameof(HomePageIsActive))]
    [NotifyPropertyChangedFor(nameof(ActionsPageIsActive))]
    [NotifyPropertyChangedFor(nameof(SettingPageIsActive))]
    private PageViewModel _currentPage;
    
    [ObservableProperty] 
    [NotifyPropertyChangedFor(nameof(SideMenuWidth))]
    [NotifyPropertyChangedFor(nameof(SideMenuIcon))]
    private bool _expendSideMenu = false;
    
    private readonly PageFactory _pageFactory;

    public double SideMenuWidth => ExpendSideMenu == true ? 200 : 40;
    public string SideMenuIcon => ExpendSideMenu ? "\\uea1c" : "\\uea2c";

    public bool HomePageIsActive => CurrentPage.PageName == "Home";
    public bool ActionsPageIsActive => CurrentPage.PageName == "Actions";
    public bool SettingPageIsActive => CurrentPage.PageName == "Settings";
    
    public MainWindowViewModel(PageFactory pageFactory)
    {
        _pageFactory = pageFactory;
        // 默认初始页
        CurrentPage = _pageFactory.GetPageViewModel(typeof(SettingsViewModel));
        CurrentPage.PageName = "Settings";
    }

    public MainWindowViewModel()
    {
        CurrentPage = new SettingsViewModel();
        CurrentPage.PageName = "Settings";
    }
    
    
    
    [RelayCommand]
    public void GoPage(Type pageType)
    {
        CurrentPage = _pageFactory.GetPageViewModel(pageType);
    }

    [RelayCommand]
    public void ToogleSideMenu()
    {
        ExpendSideMenu = !ExpendSideMenu;
    }
}