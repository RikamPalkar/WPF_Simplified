using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF_Hierarchy
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
        private void CreateDynamicWrapPanel()
        {
            // Create a WrapPanel and set its properties
            WrapPanel dynamicWrapPanel = new WrapPanel();
            dynamicWrapPanel.Orientation = Orientation.Horizontal;

            // Create Ellipses and add to StackPanel
            Ellipse redCircle = new Ellipse();
            redCircle.Width = 100;
            redCircle.Height = 100;
            redCircle.Fill = new SolidColorBrush(Colors.Red);
            dynamicWrapPanel.Children.Add(redCircle);

            Ellipse orangeCircle = new Ellipse();
            orangeCircle.Width = 80;
            orangeCircle.Height = 80;
            orangeCircle.Fill = new SolidColorBrush(Colors.Orange);
            dynamicWrapPanel.Children.Add(orangeCircle);

            Ellipse yellowCircle = new Ellipse();
            yellowCircle.Width = 60;
            yellowCircle.Height = 60;
            yellowCircle.Fill = new SolidColorBrush(Colors.Yellow);
            dynamicWrapPanel.Children.Add(yellowCircle);

            Ellipse greenCircle = new Ellipse();
            greenCircle.Width = 40;
            greenCircle.Height = 40;
            greenCircle.Fill = new SolidColorBrush(Colors.Green);
            dynamicWrapPanel.Children.Add(greenCircle);

            Ellipse blueCircle = new Ellipse();
            blueCircle.Width = 20;
            blueCircle.Height = 20;
            blueCircle.Fill = new SolidColorBrush(Colors.Blue);
            dynamicWrapPanel.Children.Add(blueCircle);

            // Display WrapPanel into a Window
            RootWindow.Content = dynamicWrapPanel;
        }


    }
}
