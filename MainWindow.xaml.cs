using System.Windows;

namespace Social_Blade_Dashboard
{
  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  public partial class MainWindow : Window
  {
    public MainWindow()
    {
      InitializeComponent();
    }

    private void Window_Loaded(object sender, RoutedEventArgs e)
    {
      RenderPages.Children.Clear();
      RenderPages.Children.Add(new Dashboard());
    }

    private void BtnExit_Click(object sender, RoutedEventArgs e)
    {
      Application.Current.Shutdown();
    }
  }
}
