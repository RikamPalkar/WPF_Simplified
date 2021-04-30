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
        /// Listing 50
        /// </summary>
        private void CreateDynamicBorder()
        {
            Border border = new Border();
            border.Background = new SolidColorBrush(Colors.LightGray);
            border.BorderThickness = new Thickness(5);
            border.BorderBrush = new SolidColorBrush(Colors.Green);
            border.CornerRadius = new CornerRadius(15);
            border.Width = 270;
            border.Height = 250;

            Canvas cnvas = new Canvas();
            Rectangle rect = new Rectangle();
            rect.Width = 200;
            rect.Height = 200;
            rect.Fill = new SolidColorBrush(Colors.Black);
            rect.StrokeThickness = 10d;
            cnvas.Children.Add(rect);

            border.Child = cnvas;
        }

    }
}
