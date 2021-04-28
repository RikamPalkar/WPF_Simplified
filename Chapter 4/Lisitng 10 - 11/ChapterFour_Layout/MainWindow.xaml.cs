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
        private void DynamicallyVerticalAlignment()
        {
            Button ButtonFirst = new Button();
            ButtonFirst.Width = 100;
            ButtonFirst.Height = 30;
            ButtonFirst.Background = new SolidColorBrush(Colors.LightBlue);
            ButtonFirst.Content = "Top Aligned";
            ButtonFirst.VerticalAlignment = VerticalAlignment.Top;
            GridMain.Children.Add(ButtonFirst);

            Button ButtonSecond = new Button();
            ButtonSecond.Width = 100;
            ButtonSecond.Height = 30;
            ButtonSecond.Background = new SolidColorBrush(Colors.LightGreen);
            ButtonSecond.Content = "Center Aligned";
            ButtonSecond.VerticalAlignment = VerticalAlignment.Center;
            GridMain.Children.Add(ButtonSecond);

            Button ButtonThird = new Button();
            ButtonThird.Width = 100;
            ButtonThird.Height = 30;
            ButtonThird.Background = new SolidColorBrush(Colors.LightCyan);
            ButtonThird.Content = "Bottom Aligned";
            ButtonThird.VerticalAlignment = VerticalAlignment.Bottom;
            GridMain.Children.Add(ButtonThird);

            Button ButtonFour = new Button();
            ButtonFour.Width = 100;
            ButtonFour.Background = new SolidColorBrush(Colors.LightPink);
            ButtonFour.Content = "Stretch Aligned";
            ButtonFour.VerticalAlignment = VerticalAlignment.Stretch;
            GridMain.Children.Add(ButtonFour);
        }

    }
}
