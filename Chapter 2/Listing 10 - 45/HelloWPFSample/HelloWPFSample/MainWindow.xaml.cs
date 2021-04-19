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
using System.Windows.Resources;
using System.Windows.Shapes;

namespace HelloWPFSample
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
        /// Listing 38
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //initialize window specific resources here.
        }

        /// <summary>
        /// Listing 38
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Window_Unloaded(object sender, RoutedEventArgs e)
        {
            //release window specific resources here.
        }

        /// <summary>
        /// Listing 11
        /// </summary>
        private void FindResourceMethod()
        {
            try
            {
                object res = Application.Current.FindResource("YellowSolidBrush");
                SolidColorBrush yellowBrush = (SolidColorBrush)res;
            }
            catch (ResourceReferenceKeyNotFoundException resExp)
            {
                MessageBox.Show("Resource not found." + resExp.Message);
            }
        }

        /// <summary>
        /// Listing 12
        /// </summary>
        private void TryFindResourceMethod()
        {
            object res1 = Application.Current.TryFindResource("YellowSolidBrush");
            if (res1 != null)
            {
                SolidColorBrush yellowBrush = (SolidColorBrush)res1;
            }
        }

        /// <summary>
        /// Listing 14, Listing 15
        /// </summary>
        private void ShutdownModeMethod()
        {
            Application curApp = Application.Current;
            curApp.ShutdownMode = ShutdownMode.OnLastWindowClose;

            Application curApp1 = Application.Current;
            curApp1.Shutdown();
        }

        /// <summary>
        /// Listing 16
        /// </summary>
        private void StartupMethod()
        {
            Application curApp = Application.Current;
            curApp.StartupUri = new Uri("SecondWindow.xaml", UriKind.RelativeOrAbsolute);
        }

        /// <summary>
        /// Listing 18, Listing 19
        /// </summary>
        private void ManagingCookies()
        {
            string simpleCookie = "CSCUser1=DonJoe";
            string cookieWithExpiration = "CSCUser2=DonJoe;expires=Mon, 1-Mar-2021 00:00:00 GMT";

            Uri simpleCookieUri = new Uri(@"C:\Junk\SimpleCookie");
            Uri persistenetCookieUri = new Uri(@"C:\Junk\PersistentCookie");

            Application.SetCookie(simpleCookieUri, simpleCookie);
            Application.SetCookie(persistenetCookieUri, cookieWithExpiration);

            //Application.GetCookie
            Uri cookiePath = new Uri(@"C:\Junk\SimpleCookie");
            string cookie = Application.GetCookie(cookiePath);
            MessageBox.Show(cookie);
        }

        /// <summary>
        /// Listing 39
        /// </summary>
        private void GetResourceStream()
        {
            Uri uri = new Uri("/ResourceFile.xaml", UriKind.Relative);
            StreamResourceInfo info = Application.GetResourceStream(uri);
        }

        /// <summary>
        /// Listing 40
        /// </summary>
        private void GetContentStream()
        {
            Uri uri = new Uri("/ContentFile.xaml", UriKind.Relative);
            StreamResourceInfo info = Application.GetContentStream(uri);
        }

        /// <summary>
        /// Listing 41
        /// </summary>
        private void GetRemoteStream()
        {
            Uri uri = new Uri("/SOOFile.xaml", UriKind.Relative);
            StreamResourceInfo info = Application.GetRemoteStream(uri);
        }

        private void LoadComponent()
        {
            object comp = Application.LoadComponent(
            new Uri("C:/MyProject/SecondWindow.xaml", System.UriKind.RelativeOrAbsolute));
        }
    }
}
