using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace RoutedEventApp
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Trace.WriteLine("Window_MouseDown");
        }

        private void Window_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            Trace.WriteLine("Window_PreviewMouseDown");

        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Trace.WriteLine("Grid_MouseDown");
        }

        private void Grid_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            Trace.WriteLine("Grid_PreviewMouseDown");
        }

        private void StackPanel_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            Trace.WriteLine("StackPanel_PreviewMouseDown");
            e.Handled = true;
        }

        private void StackPanel_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Trace.WriteLine("StackPanel_MouseDown");
        }

        private void Ellipse_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Trace.WriteLine("Ellipse_MouseDown");
            e.Handled = true;
        }

        private void Ellipse_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            Trace.WriteLine("Ellipse_PreviewMouseDown");
        }

        private void Button_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Trace.WriteLine("Button_MouseDoubleClick");
        }

        private void Button_PreviewMouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Trace.WriteLine("Button_PreviewMouseDoubleClick");
        }

        private void Button_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            Trace.WriteLine("Button_PreviewMouseDown");

        }
    }
}
