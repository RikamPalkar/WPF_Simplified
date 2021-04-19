using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Resources;

namespace HelloWPFSample
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //Listing 21
            Application app = new Application();
            app.Run();


            //Listing 22
            Application app1 = new Application();
            app.Run(new MainWindow());

        }

        /// <summary>
        /// Listing 24, 25, 45
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void Application_Startup(object sender, StartupEventArgs e)
        {
            // Get CommandLine Arguments
            bool fullScreen = false;
            foreach (string arg in e.Args)
            {
                if (arg == "")
                    fullScreen = true;
            }

            // Set Application level data properties
            this.Properties["Login"] = "DonJoe";
            this.Properties["Password"] = "pwd";

            // Create a Window, set its properties and display it
            //splash screen Listing 44
            SecondWindow window = new SecondWindow();
            window.Top = 100;
            window.Left = 400;
            window.Show();

            if (fullScreen)
            {
                window.WindowState = WindowState.Minimized;
            }
            window.Show();

            //Getting Command Line Arguments 
            // CommandLine Arguments found?
            if (e.Args.Length > 0)
            {
                // Loop through all command-line arguments
                // which is an array of strings
                foreach (string arg in e.Args)
                {
                    MessageBox.Show("Arg =" + arg);
                }
            }
        }

        /// <summary>
        /// Listing 27, 28
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Application_Activated(object sender, EventArgs e)
        {
            MessageBox.Show("Activated event fired.");
        }

        /// <summary>
        /// Listing 27, 28
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Application_Deactivated(object sender, EventArgs e)
        {
            MessageBox.Show("Deactivated event fired.");
        }


        /// <summary>
        /// Listing 30, 31
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Application_SessionEnding(object sender, SessionEndingCancelEventArgs e)
        {
            string msg = string.Format("{0}. Do you want to close this session?", e.ReasonSessionEnding);
            MessageBoxResult result = MessageBox.Show(msg, "Session Ending Event Fired.", MessageBoxButton.YesNo);

            if (result == MessageBoxResult.No)
            {
                e.Cancel = true;
            }
        }

        /// <summary>
        /// Listing 33
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Application_Exit(object sender, ExitEventArgs e)
        {

        }

        /// <summary>
        /// Listing 35, 36
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Application_DispatcherUnhandledException(object sender, System.Windows.Threading.DispatcherUnhandledExceptionEventArgs e)
        {
            // Do something about the exception
            MessageBox.Show("Exception occured while dividing by zero!");
            e.Handled = true;
        }
    }
}