using System;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using Avalonia.Metadata;
using AvaloniaAppDemo.MainApp;
using AvaloniaAppDemo.ViewModel;
using AvaloniaAppDemo.views;
using AvaloniaAppDemo.Views;
using AvaloniaAppDemo.Views.Pages;
using AvaloniaAppDemo.Views.Pages.Actions;
using AvaloniaAppDemo.Views.Pages.Settings;
using Microsoft.Extensions.DependencyInjection;
[assembly: XmlnsDefinition("https://github.com/avaloniaui", "AvaloniaAppDemo.Controls")]
namespace AvaloniaAppDemo {
    public partial class App : Application {
        public override void Initialize()
        {
            AvaloniaXamlLoader.Load(this);
        }
        
        public override void OnFrameworkInitializationCompleted()
        {
            var services = new ServiceCollection();
            AddServices(services);
            
            // 菜单路由部分
            services.AddScoped<Func<Type, PageViewModel>>((sp) => (x) =>
            {
                return x switch
                {
                    _ when x == typeof(HomeViewModel) => sp.GetRequiredService<HomeViewModel>(),
                    _ when x == typeof(HistoryViewModel) => sp.GetRequiredService<HistoryViewModel>(),
                    _ when x == typeof(ActionsViewModel) => sp.GetRequiredService<ActionsViewModel>(),
                    _ when x == typeof(SettingsViewModel) => sp.GetRequiredService<SettingsViewModel>(),
                    _ => throw new ArgumentException($"未定义 {nameof(x)} ViewModel 类型")
                };
            });
            
            var serviceProvider = services.BuildServiceProvider();
            
            if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
            {
                desktop.MainWindow = new MainWindow();
                desktop.MainWindow.DataContext = serviceProvider.GetRequiredService<MainWindowViewModel>();
            }
            base.OnFrameworkInitializationCompleted();
        }

        private void AddServices(IServiceCollection services)
        {
            services.AddSingleton<MainWindowViewModel>();
            services.AddTransient<HomeViewModel>();
            services.AddTransient<HistoryViewModel>();
            services.AddTransient<ActionsViewModel>();
            services.AddTransient<SettingsViewModel>();

            services.AddSingleton<PageFactory>();
        }
    }
}