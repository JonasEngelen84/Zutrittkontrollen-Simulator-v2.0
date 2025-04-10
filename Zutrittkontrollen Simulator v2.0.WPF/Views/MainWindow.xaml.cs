using System.Windows;
using System.Windows.Input;
using System.Windows.Media.Imaging;

namespace Zutrittkontrollen_Simulator_v2._0.Views
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void DragWindow(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void CloseAppClick(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void MinimizeAppClick(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void MaximizeAppClick(object sender, RoutedEventArgs e)
        {
            if (WindowState == WindowState.Normal)
            {
                WindowState = WindowState.Maximized;

                MaximizePNG.Source = new BitmapImage(new Uri("pack://application:,,,/Resources/Images/Normalize.png"));
                MaximizePNG.Width = 17;
                MaximizePNG.Height = 17;
            }                
            else
            {
                WindowState = WindowState.Normal;

                MaximizePNG.Source = new BitmapImage(new Uri("pack://application:,,,/Resources/Images/Maximize.png"));
                MaximizePNG.Width = 14;
                MaximizePNG.Height = 14;
            }
        }
    }
}