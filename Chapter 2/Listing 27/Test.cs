using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWPFSample
{
    class Test
    {
        private void Application_Startup(object sender, StartupEventArgs e)
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
            SecondWindow window = new SecondWindow();
            if (fullScreen)
            {
                window.WindowState = WindowState.Minimized;
            }
            window.Show();
        }
    }
}
