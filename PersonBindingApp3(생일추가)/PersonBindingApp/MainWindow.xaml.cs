using System;
using System.Collections.Generic;
using System.ComponentModel;
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
            this.DataContext = new Person() { Name = "홍길동", Age = 25, Clr = Colors.DarkGreen };
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Person per = this.DataContext as Person;
            per.Age++;

        }
    }

    public class Person : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private string name;
        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Name"));
            }
        }
        private int age;
        public int Age
        {
            get { return age; }
            set
            {
                age = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Age"));
                //부가적인 작업
            }
        }
        private Color clr;
        public Color Clr
        {
            get { return clr; }
            set
            {
                clr = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Clr"));


            }

        }
        public Person() 
        {
            Name = "noname";
            Age = 0;
            Clr = Colors.White;
        }
        public override string ToString()
        {
            return $"Name:{Name}, Age:{Age}, Color:{Clr}";
        }
    }
    public class ColorConverter : IValueConverter
    {
        //소스에서 타겟으로 감 소스 -> 타겟
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            Color clr = (Color)value;
            return new SolidColorBrush(clr);
        }
        // 타겟 -> 소스
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value;
        }
    }
}
