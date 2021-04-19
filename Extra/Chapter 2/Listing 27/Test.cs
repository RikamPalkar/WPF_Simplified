using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWPFSample
{
    public class Multiplewindows
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            // Get CommandLine Arguments
            var fullScreen = e.Args.Any(arg => arg == "");

            // Set Application level data properties
            Properties["Login"] = "DonJoe";
            Properties["Password"] = "pwd";

            // Create a Window, set its properties and display it
            var window = new SecondWindow();
            if (fullScreen)
            {
                window.WindowState = WindowState.Minimized;
            }
            window.Show();
        }
    }
}
