using System.Drawing;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace ButtonControl
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            CreateButton();
        }

        private void CreateButton()
        {
            // Button with string content
            Button helloButton = new Button();
            helloButton.Margin = new Thickness(10, 10, 350, 310);
            helloButton.Content = "Hello XAML";

            // Button with a UIElement
            Button buttonWithRectangle = new Button();
            buttonWithRectangle.Height = 80;
            buttonWithRectangle.Margin = new Thickness(10, 80, 300, 170);
            // Create a Rectangle
            System.Windows.Shapes.Rectangle greenRectangle = new System.Windows.Shapes.Rectangle();
            greenRectangle.Height = 60;
            greenRectangle.Width = 120;
            greenRectangle.Fill = Brushes.Green;
            // Set Rectangle as Button.Content
            buttonWithRectangle.Content = greenRectangle;


            // Button with a Container, StackPanel
            Button buttonWithStackPanel = new Button();
            buttonWithStackPanel.Margin = new Thickness(10, 10, 350, 310);
            // Create a StackPanel and set its orinetation to horizontal
            StackPanel stackPanel = new StackPanel();
            stackPanel.Orientation = Orientation.Horizontal;
            // Create an Ellipse
            Ellipse redEllipse = new Ellipse();
            redEllipse.Width = 60;
            redEllipse.Height = 60;
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
            System.Windows.Shapes.Rectangle greenRectangle2 = new System.Windows.Shapes.Rectangle();
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
            LayoutRoot.Children.Add(helloButton);
            LayoutRoot.Children.Add(buttonWithRectangle);
            LayoutRoot.Children.Add(buttonWithStackPanel);
        }
    }
}
