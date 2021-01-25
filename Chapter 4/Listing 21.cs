using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF_Hierarchy
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

        private void CreateADockPanelDynamically()
        {
            // Create a DockPanel
            DockPanel dcPanel = new DockPanel();

            // Create a button 
            Button TopRect = new Button();
            TopRect.Background = new SolidColorBrush(Colors.LightGreen);
            TopRect.Height = 50;
            TopRect.Content = "Top";
            // Dock button to top
            DockPanel.SetDock(TopRect, Dock.Top);
            // Add docked button to DockPanel
            dcPanel.Children.Add(TopRect);

            // Create a button 
            Button LeftRect = new Button();
            LeftRect.Background = new SolidColorBrush(Colors.LightBlue);
            LeftRect.Width = 50;
            LeftRect.Content = "Left";
            // Dock button to left
            DockPanel.SetDock(LeftRect, Dock.Left);
            // Add docked button to DockPanel
            dcPanel.Children.Add(LeftRect);

            // Create a button 
            Button RightRect = new Button();
            RightRect.Background = new SolidColorBrush(Colors.LightSalmon);
            RightRect.Width = 50;
            RightRect.Content = "Right";
            // Dock button to left
            DockPanel.SetDock(RightRect, Dock.Right);
            // Add docked button to DockPanel
            dcPanel.Children.Add(RightRect);

            // Create a button 
            Button BottomRect = new Button();
            BottomRect.Background = new SolidColorBrush(Colors.LightCyan);
            BottomRect.Height = 50;
            BottomRect.Content = "Bottom";
            // Dock button to left
            DockPanel.SetDock(BottomRect, Dock.Bottom);
            // Add docked button to DockPanel
            dcPanel.Children.Add(BottomRect);

            // Create a fill button 
            Button FillRect = new Button();
            FillRect.Background = new SolidColorBrush(Colors.LightGray);
            FillRect.Content = "Center";

            // Add docked button to DockPanel
            dcPanel.Children.Add(FillRect);

            RootWindow.Content = dcPanel;

        }

    }
}
