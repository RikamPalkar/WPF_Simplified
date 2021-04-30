using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ChapterFour_Layout
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

        /// <summary>
        /// Listing 42
        /// </summary>
        private void CreateDynamicStackPanel()
        {
            // Create a StackPanel and set its properties
            StackPanel dynamicStackPanel = new StackPanel();
            dynamicStackPanel.Background = new SolidColorBrush(Colors.LightBlue);
            dynamicStackPanel.Orientation = Orientation.Horizontal;

            // Create Ellipses and add to StackPanel
            Ellipse redCircle = new Ellipse();
            redCircle.Width = 100;
            redCircle.Height = 100;
            redCircle.Fill = new SolidColorBrush(Colors.Red);
            dynamicStackPanel.Children.Add(redCircle);

            Ellipse orangeCircle = new Ellipse();
            orangeCircle.Width = 80;
            orangeCircle.Height = 80;
            orangeCircle.Fill = new SolidColorBrush(Colors.Orange);
            dynamicStackPanel.Children.Add(orangeCircle);

            Ellipse yellowCircle = new Ellipse();
            yellowCircle.Width = 60;
            yellowCircle.Height = 60;
            yellowCircle.Fill = new SolidColorBrush(Colors.Yellow);
            dynamicStackPanel.Children.Add(yellowCircle);

            Ellipse greenCircle = new Ellipse();
            greenCircle.Width = 40;
            greenCircle.Height = 40;
            greenCircle.Fill = new SolidColorBrush(Colors.Green);
            dynamicStackPanel.Children.Add(greenCircle);

            Ellipse blueCircle = new Ellipse();
            blueCircle.Width = 20;
            blueCircle.Height = 20;
            blueCircle.Fill = new SolidColorBrush(Colors.Blue);
            dynamicStackPanel.Children.Add(blueCircle);

        }

    }
}
