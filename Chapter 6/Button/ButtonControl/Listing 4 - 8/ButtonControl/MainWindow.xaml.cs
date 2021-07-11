using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace ButtonControl
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            CreateAButton();
        }

        private void CreateAButton()
        {
            Button btn = new Button();
            btn.Height = 40;
            btn.Width = 120;
            btn.Content = "Click Me";
            btn.Margin = new Thickness(50,75,0,0);
            btn.Background = new SolidColorBrush(Colors.Orange);
            btn.Foreground = new SolidColorBrush(Colors.Black);
            LayoutRoot.Children.Add(btn);
        }

    }
}
