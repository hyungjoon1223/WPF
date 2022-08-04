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
using System.Windows.Controls;

namespace _220804_황형준_Silder
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            txtRed.Text = "0";
            txtGreen.Text = "0";
            txtBlue.Text = "0";
            scrR.Value = 0;
            scrG.Value = 0;
            scrB.Value = 0;
        }
        private void Scr_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            byte valueR = (byte)(scrR.Value);
            byte valueG = (byte)(scrG.Value);
            byte valueB = (byte)(scrB.Value);
            txtRed.Text = valueR.ToString();
            txtGreen.Text = valueG.ToString();
            txtBlue.Text = valueB.ToString();
            bgCanvas.Background = new SolidColorBrush(Color.FromArgb(255, valueR, valueG, valueB));
        }
        private void RedTextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtRed.Text == "")
                return;
            scrR.Value = int.Parse(txtRed.Text);
            bgCanvas.Background = new SolidColorBrush(Color.FromArgb(255,
              (byte)scrR.Value, (byte)scrG.Value, (byte)scrB.Value));
        }

        private void GreenTextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtGreen.Text == "")
                return;
            scrG.Value = int.Parse(txtGreen.Text);
            bgCanvas.Background = new SolidColorBrush(Color.FromArgb(255,
              (byte)scrR.Value, (byte)scrG.Value, (byte)scrB.Value));
        }

        private void BlueTextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtBlue.Text == "")
                return;
            scrB.Value = int.Parse(txtBlue.Text);
            bgCanvas.Background = new SolidColorBrush(Color.FromArgb(255,
              (byte)scrR.Value, (byte)scrG.Value, (byte)scrB.Value));
        }
    }
}
