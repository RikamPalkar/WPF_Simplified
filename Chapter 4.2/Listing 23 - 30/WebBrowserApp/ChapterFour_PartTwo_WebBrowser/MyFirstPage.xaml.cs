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

namespace ChapterFour_PartTwo_WebBrowser
{
    /// <summary>
    /// Interaction logic for MyFirstPage.xaml
    /// </summary>
    public partial class MyFirstPage : Page
    {
        public MyFirstPage()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Listing 27, 29
        /// </summary>
        private void CreateDynamicPage()
        {
            // Listing 27
            Page dynamicPage = new Page();
            dynamicPage.Name = "FirstBrowserPage";
            dynamicPage.Title = "Dynamic Page";

            /*
            //Listing 29
            Page dynamicPage = new Page();
            dynamicPage.Name = "FirstBrowserPage";
            dynamicPage.Title = "Page Title";
            dynamicPage.Background = new SolidColorBrush(Colors.LightBlue);
            dynamicPage.Foreground = new SolidColorBrush(Colors.DarkBlue);
            dynamicPage.Width = 500;
            dynamicPage.Height = 300;
            dynamicPage.FontFamily = new FontFamily("Verdana");
            dynamicPage.FontSize = 12;
            dynamicPage.WindowWidth = 400;
            dynamicPage.WindowHeight = 300;
            dynamicPage.WindowTitle = "Window Title";
            dynamicPage.KeepAlive = true;
            */
        }
    }
}
