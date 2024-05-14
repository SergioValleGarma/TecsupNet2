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
using System.Windows.Shapes;

namespace Clase20240510
{
    /// <summary>
    /// Lógica de interacción para Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            StackPanel stackPanel = new StackPanel();
            TextBlock textBlock = new TextBlock(); 
            stackPanel.Children.Add(textBlock);

            for (int i = 0; i < 3; i++)
            {
                Button button = new Button();
                stackPanel.Children.Add((Button)button);
            }

            this.Content = stackPanel;
        }
    }
}
