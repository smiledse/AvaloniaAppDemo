using System;
using System.Threading.Tasks;
using Avalonia.Threading;
using AvaloniaAppDemo.ViewModel;
using CommunityToolkit.Mvvm.ComponentModel;

namespace AvaloniaAppDemo.Views.Pages;

public partial class HomeViewModel : PageViewModel
{
    private readonly TimeSpan _interval = TimeSpan.FromMilliseconds(500);

    [ObservableProperty]
    private double _cpu;
    
    public HomeViewModel()
    {
        Cpu = SimulateCpuSample();
    }

    private static double SimulateCpuSample()
    {
        return Math.Round(Random.Shared.NextDouble() * 100, 1); 
    }
}