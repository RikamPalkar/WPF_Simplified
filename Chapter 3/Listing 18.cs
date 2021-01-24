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

        // Button with string content
        Button helloButton = new Button();
        helloButton.Content = "I am Content"; 
helloButton.Height = 50;
helloButton.Width = 200;


// Button with a UIElement
Button buttonWithRectangle = new Button();
        buttonWithRectangle.Height = 80; 
buttonWithRectangle.Width = 200;

// Create a Rectangle
Rectangle LightSalmon = new Rectangle();
        LightSalmon.Height = 40; 
LightSalmon.Width = 100;
LightSalmon.Fill = Brushes.LightSalmon;
// Set Rectangle as Button.Content
buttonWithRectangle.Content = greenRectangle;


// Button with a Container, StackPanel
Button buttonWithStackPanel = new Button();
        buttonWithStackPanel.Height = 150; 
buttonWithStackPanel.Width = 400;

// Create a StackPanel and set its orinetation to horizontal
StackPanel stackPanel = new StackPanel();
        stackPanel.Height = 100;
stackPanel.Width = 360;

stackPanel.Orientation = Orientation.Horizontal;
// Create an Ellipse
Ellipse redEllipse = new Ellipse();
        redEllipse.Height = 60;
redEllipse.Width = 60;
redEllipse.Fill = Brushes.Red;
// Add to StackPanel
stackPanel.Children.Add(redEllipse);

// Create a TextBlock
TextBlock textBlock1 = new TextBlock();
        textBlock1.TextAlignment = TextAlignment.Left;
textBlock1.Text = "Red Circle";
// Add to StackPanel
stackPanel.Children.Add(textBlock1);

// Create a TextBlock
TextBlock space = new TextBlock();
        space.TextAlignment = TextAlignment.Center;
space.Text = "       ";
// Add to StackPanel
stackPanel.Children.Add(space);

// Create a Rectangle
Rectangle greenRectangle2 = new Rectangle();
        greenRectangle2.Height = 60;
greenRectangle2.Width = 120;
greenRectangle2.Fill = Brushes.Green;
// Add to StackPanel
stackPanel.Children.Add(greenRectangle2);

// Create a TextBlock
TextBlock textBlock2 = new TextBlock();
        textBlock2.TextAlignment = TextAlignment.Left;
textBlock2.Text = "Green Rectangle";
// Add to StackPanel
stackPanel.Children.Add(textBlock2);

// Set StackPaenl as Button.Content
buttonWithStackPanel.Content = stackPanel;

// Add dynamic button controls to the Window
ParentGrid.Children.Add(helloButton);
ParentGrid.Children.Add(buttonWithRectangle);
ParentGrid.Children.Add(buttonWithStackPanel);

    }
}
