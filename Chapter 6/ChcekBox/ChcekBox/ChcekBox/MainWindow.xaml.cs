using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace ChcekBox
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

        private void CheckBoxControl_Checked(object sender, RoutedEventArgs e)
        {
            CheckBoxControl.Content = "Checked";
        }

        private void CheckBoxControl_Unchecked(object sender, RoutedEventArgs e)
        {
            CheckBoxControl.Content = "UnChecked";
        }

        private void CreateCheckboxDynamicaly()
        {
            CheckBox chb = new CheckBox();
            chb.Content = "Click me";
            chb.IsChecked = true;
            chb.Foreground = new SolidColorBrush(Colors.Orange);
            chb.IsChecked = true;
            LayoutRoot.Children.Add(chb);
        }

    }
}
