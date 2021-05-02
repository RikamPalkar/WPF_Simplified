using System;
using System.Windows;
using System.Windows.Data;
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
        /// Window_Loaded
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Window_Loaded");
        }

        /// <summary>
        /// Window_ContentRendered
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Window_ContentRendered(object sender, EventArgs e)
        {
            MessageBox.Show("Window_ContentRendered");
        }

        /// <summary>
        /// Window_Activated
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Window_Activated(object sender, EventArgs e)
        {
             MessageBox.Show("Window_Activated");
        }

        /// <summary>
        /// Window_Closed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Window_Closed(object sender, EventArgs e)
        {
            MessageBox.Show("Are you sure?");
        }

        /// <summary>
        /// Window_Closing
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            MessageBox.Show("Window_Closing");
        }

        /// <summary>
        /// Window_Deactivated
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Window_Deactivated(object sender, EventArgs e)
        {
            MessageBox.Show("Window_Deactivated");
        }

        /// <summary>
        /// Window_Initialized
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Window_Initialized(object sender, EventArgs e)
        {
            MessageBox.Show("Window_Initialized");
        }

        /// <summary>
        /// Window_LayoutUpdated
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Window_LayoutUpdated(object sender, EventArgs e)
        {
            MessageBox.Show("Window_ContentRendered");
        }

        /// <summary>
        /// Window_LocationChanged
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Window_LocationChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Window_LocationChanged");
        }

        /// <summary>
        /// Window_SizeChanged
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Window_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            MessageBox.Show("Window_SizeChanged");
        }

        /// <summary>
        /// Window_SourceInitialized
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Window_SourceInitialized(object sender, EventArgs e)
        {
            MessageBox.Show("Window_SourceInitialized");
        }

        /// <summary>
        /// Window_StateChanged
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Window_StateChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Window_StateChanged");
        }

        /// <summary>
        /// Window_SourceUpdated
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Window_SourceUpdated(object sender, DataTransferEventArgs e)
        {
            MessageBox.Show("Window_SourceUpdated");
        }

        /// <summary>
        /// Window_Unloaded
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Window_Unloaded(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Window_Unloaded");
        }

    }
}
