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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //CreateDynamicUI();
        }

        private void AddItemClick(object sender, RoutedEventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
        }

        /*
        #region UI Properties
        /// <summary>
        /// The TextBox control
        /// </summary>
        protected TextBox textBox1;

        /// <summary>
        /// The Button control
        /// </summary>
        protected Button button1;

        /// <summary>
        /// The ListBox Control
        /// </summary>
        protected ListBox listBox1;
        #endregion

        #region Methods
        /// <summary>
        /// This method creates UI controls and set their properties
        /// </summary>
        private void CreateDynamicUI()
        {
            // Create a TextBox
            textBox1 = new TextBox();
            textBox1.Name = "textBox1";
            textBox1.Width = 207;
            textBox1.Height = 28;
            textBox1.Margin = new Thickness(13, 17, 0, 0);
            textBox1.HorizontalAlignment = System.Windows.HorizontalAlignment.Left;
            textBox1.VerticalAlignment = System.Windows.VerticalAlignment.Top;
            // Add to Grid
            RootLayout.Children.Add(textBox1);

            // Create a Button
            button1 = new Button();
            button1.Name = "textBox1";
            button1.Content = "Add Item";
            button1.Width = 107;
            button1.Height = 30;
            button1.Margin = new Thickness(235, 15, 0, 0);
            button1.HorizontalAlignment = System.Windows.HorizontalAlignment.Left;
            button1.VerticalAlignment = System.Windows.VerticalAlignment.Top;
            button1.Click += new RoutedEventHandler(AddItemClick);
            // Add to Grid
            RootLayout.Children.Add(button1);

            // Create a ListBox
            listBox1 = new ListBox();
            listBox1.Name = "listBox1";
            listBox1.Width = 327;
            listBox1.Height = 102;
            listBox1.Margin = new Thickness(15, 57, 0, 0);
            listBox1.HorizontalAlignment = System.Windows.HorizontalAlignment.Left;
            listBox1.VerticalAlignment = System.Windows.VerticalAlignment.Top;

            // Add children to the Grid
            RootLayout.Children.Add(listBox1);
        }
        #endregion

        #region Event-Handlers
        /// <summary>
        /// Event-handlder for add button's click event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddItemClick(object sender, RoutedEventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
        }
        #endregion

        */
    }
}
