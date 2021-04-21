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

namespace HelloXAML
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

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            ListBoxBeverages.Items.Add(TextBoxUserInput.Text);
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            ListBoxBeverages.Items.RemoveAt
                (ListBoxBeverages.Items.IndexOf(ListBoxBeverages.SelectedItem));
        }


    }
}
