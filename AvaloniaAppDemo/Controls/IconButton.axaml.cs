using Avalonia;
using Avalonia.Controls;
using ExCSS;

namespace AvaloniaAppDemo.Controls;

public class IconButton : Button
{
    public static readonly StyledProperty<HorizontalAlignment> ContentAlignProperty = AvaloniaProperty.Register<IconButton, HorizontalAlignment>(
        nameof(ContentAlignProperty));

    public HorizontalAlignment ContentAlign
    {
        get => this.GetValue(ContentAlignProperty);
        set => SetValue(ContentAlignProperty, value);
    }
    
    public static readonly StyledProperty<string> IconProperty = AvaloniaProperty.Register<IconButton, string>(nameof(IconProperty));

    public string Icon
    {
        get => this.GetValue(IconProperty);
        set => SetValue(IconProperty, value);
    }
}