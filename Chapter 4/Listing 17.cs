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

        private void CreateDynamicPanel()
        {
            // Create a Grid Panel control 
            Grid gridPanel = new Grid();

            // Set Grid Panel properties
            gridPanel.Background = new SolidColorBrush(Colors.Blue);
            gridPanel.Width = 250;
            gridPanel.Height = 200;
            gridPanel.HorizontalAlignment = HorizontalAlignment.Left;
            gridPanel.VerticalAlignment = VerticalAlignment.Top;
            gridPanel.FlowDirection = FlowDirection.LeftToRight;

            // Set Grid Panel as the content of the Window
            RootWindow.Content = gridPanel;
        }

    }
}
