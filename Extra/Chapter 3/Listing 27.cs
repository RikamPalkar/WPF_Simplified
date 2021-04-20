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

        // Create a Dynamic Button.
        Button helloButton = new Button();
        helloButton.Height = 50;
        helloButton.Width = 100;
        helloButton.Background = Brushes.AliceBlue;
        helloButton.Content = "Click Me";

        // Save the Button to a string. 
        string dynamicXAML = XamlWriter.Save(helloButton);

    }
}
