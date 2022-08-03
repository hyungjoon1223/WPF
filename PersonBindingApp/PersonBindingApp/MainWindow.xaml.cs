using System;
using System.Collections.Generic;
using System.Globalization;
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

namespace PersonBindingApp
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = new Person() { Name="홍길동",Age=25,Clr=Colors.DarkGreen};
        }
    }

    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Color Clr { get; set; }
        public Person() 
        {
            Name = "noname";
            Age = 0;
            Clr = Colors.White;
        }
    }
    public class ColorConverter : IValueConverter
    {
        //소스에서 타겟으로 감 소스 -> 타겟
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            Color clr = (Color)value;
            MessageBox.Show(clr.ToString());
            return new SolidColorBrush(clr);
        }
        // 타겟 -> 소스
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value;
        }
    }
}
