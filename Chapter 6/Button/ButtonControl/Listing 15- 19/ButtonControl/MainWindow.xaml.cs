using System.Drawing;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;

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
        }

        private void DrawCircleButton_Click(object sender, RoutedEventArgs e)
        {
            // creates a Circle
            Ellipse circle = new Ellipse();
            circle.Width = 200;
            circle.Height = 200;
            circle.Fill = new SolidColorBrush(Colors.Yellow);
            circle.Stroke = new SolidColorBrush(Colors.Black);
            circle.StrokeThickness = 4;
            LayoutRoot.Children.Add(circle);
        }

        private void DrawCircleButton_MouseEnter(object sender, MouseEventArgs e)
        {
            DrawCircleButton.Background = new SolidColorBrush(Colors.Yellow);
            DrawCircleButton.Foreground = new SolidColorBrush(Colors.Green);
        }

        private void DrawCircleButton_MouseLeave(object sender, MouseEventArgs e)
        {
            DrawCircleButton.Background = new SolidColorBrush(Colors.Red);
            DrawCircleButton.Foreground = new SolidColorBrush(Colors.Purple);
        }

    }
}
