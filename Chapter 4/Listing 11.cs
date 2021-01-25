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

        private void DynamicallyVerticalAlignment()
        {
            Button btn1 = new Button();
            btn1.Width = 100;
            btn1.Height = 30;
            btn1.Background = new SolidColorBrush(Colors.LightBlue);
            btn1.Content = "Top Aligned";
            btn1.VerticalAlignment = VerticalAlignment.Top;
            Grid1.Children.Add(btn1);

            Button btn2 = new Button();
            btn2.Width = 100;
            btn2.Height = 30;
            btn2.Background = new SolidColorBrush(Colors.LightGreen);
            btn2.Content = "Center Aligned";
            btn2.VerticalAlignment = VerticalAlignment.Center;
            Grid1.Children.Add(btn2);

            Button btn3 = new Button();
            btn3.Width = 100;
            btn3.Height = 30;
            btn3.Background = new SolidColorBrush(Colors.LightCyan);
            btn3.Content = "Bottom Aligned";
            btn3.VerticalAlignment = VerticalAlignment.Bottom;
            Grid1.Children.Add(btn3);

            Button btn4 = new Button();
            btn4.Width = 100;
            btn4.Background = new SolidColorBrush(Colors.LightPink);
            btn4.Content = "Stretch Aligned";
            btn4.VerticalAlignment = VerticalAlignment.Stretch;
            Grid1.Children.Add(btn4);
        }

    }
}
