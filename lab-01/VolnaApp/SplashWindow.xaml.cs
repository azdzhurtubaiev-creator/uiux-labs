using System.Threading.Tasks;
using System.Windows;

namespace VolnaApp;

public partial class SplashWindow : Window
{
    public SplashWindow()
    {
        InitializeComponent();
        Loaded += OnLoaded;
    }

    private async void OnLoaded(object sender, RoutedEventArgs e)
    {
        await InitializeAppAsync();

        var main = new MainWindow();
        main.Show();
        Close();
    }

    private static Task InitializeAppAsync() => Task.Delay(2000);
}