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


        private void AddResourcesToApplication()
        {
            Application curApp = Application.Current;
            curApp.Resources.Add("YellowSolidBrush", new SolidColorBrush(Colors.Yellow));
            curApp.Resources.Add("GrayBorderBrush", new SolidColorBrush(Colors.Gray));
        }



    }
}
