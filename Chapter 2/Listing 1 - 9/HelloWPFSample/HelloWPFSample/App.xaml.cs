using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace HelloWPFSample
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        #region ApplicationLevelProperties
        string uid = Application.Current.Properties["Login"].ToString();
        string pwd = Application.Current.Properties["Password"].ToString();
        #endregion

        /// <summary>
        /// App_Startup
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void App_Startup(object sender, StartupEventArgs e)
        {
            this.Properties["Login"] = "Peter";
            this.Properties["Password"] = "12345";

            // Create and store an object in Properties
            Author author = new Author("Peter", 33, "Programming");
            this.Properties["CurrentAuthor"] = author;

        }

    }
}
