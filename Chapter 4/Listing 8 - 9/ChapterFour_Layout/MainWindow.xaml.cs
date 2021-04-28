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

        private void DynamicallyHorizontalAlignment()
        {
            Button ButtonFirst = new Button();
            ButtonFirst.Width = 150;
            ButtonFirst.Height = 50;
            ButtonFirst.Background = new SolidColorBrush(Colors.LightBlue);
            ButtonFirst.Content = "Left Aligned";
            ButtonFirst.HorizontalAlignment = HorizontalAlignment.Left;
            StackPanelOuter.Children.Add(ButtonFirst);

            Button ButtonSecond = new Button();
            ButtonSecond.Width = 150;
            ButtonSecond.Height = 50;
            ButtonSecond.Background = new SolidColorBrush(Colors.LightGreen);
            ButtonSecond.Content = "Center Aligned";
            ButtonSecond.HorizontalAlignment = HorizontalAlignment.Center;
            StackPanelOuter.Children.Add(ButtonSecond);

            Button ButtonThird = new Button();
            ButtonThird.Width = 150;
            ButtonThird.Height = 50;
            ButtonThird.Background = new SolidColorBrush(Colors.LightCyan);
            ButtonThird.Content = "Right Aligned";
            ButtonThird.HorizontalAlignment = HorizontalAlignment.Right;
            StackPanelOuter.Children.Add(ButtonThird);

            Button ButtonFourth = new Button();
            ButtonFourth.Height = 50;
            ButtonFourth.Background = new SolidColorBrush(Colors.LightPink);
            ButtonFourth.Content = "Stretch Aligned";
            ButtonFourth.HorizontalAlignment = HorizontalAlignment.Stretch;
            StackPanelOuter.Children.Add(ButtonFourth);
        }

    }
}
