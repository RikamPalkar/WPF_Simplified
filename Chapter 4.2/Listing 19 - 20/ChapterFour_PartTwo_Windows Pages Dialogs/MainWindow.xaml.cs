using System.Windows;
using System.Windows.Input;
using System.Windows.Media;

namespace ChapterFour_PartTwo_Windows_Pages_Dialogs
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
        /// MouseLeftButtonDown
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        /// <summary>
        /// CloseButton_Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// BlackNWhiteButton_Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BlackNWhiteButton_Click(object sender, RoutedEventArgs e)
        {
            // Create a linear gradient brush with five stops  
            LinearGradientBrush blacknwhiteBrush = new LinearGradientBrush();
            blacknwhiteBrush.StartPoint = new Point(0, 0);
            blacknwhiteBrush.EndPoint = new Point(1, 1);
            // Create and add Gradient stops
            GradientStop blackGS = new GradientStop();
            blackGS.Color = Colors.Black;
            blackGS.Offset = 0.0;
            blacknwhiteBrush.GradientStops.Add(blackGS);
            GradientStop whiteGS = new GradientStop();
            whiteGS.Color = Colors.White;
            whiteGS.Offset = 1.0;
            blacknwhiteBrush.GradientStops.Add(whiteGS);
            UIPath.Fill = blacknwhiteBrush;
        }
    }
}
