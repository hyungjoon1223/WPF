using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
            //this.DataContext = this;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Person per = this.DataContext as Person;
            per.Age++;
        }
        private void Button_MouseEnter(object sender, MouseEventArgs e)
        {
            Button btn = sender as Button;
            btn.Background = new SolidColorBrush(Colors.Yellow);
        }

        private void Button_MouseLeave(object sender, MouseEventArgs e)
        {
            Button btn = sender as Button;
            btn.Background = new SolidColorBrush(Colors.LightGreen);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("첫 번째 버튼 클릭!");
        }
        public void Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("두 번째 버튼 클릭!");
        }
    }
    public class Notifier : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string propName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }
    }

    public class Person : Notifier
    {
        public void Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Person 두 번째 버튼 클릭!");
        }
        private string name;
        public string Name 
        {
            get { return name; }
            set 
            {
                name = value;
                OnPropertyChanged("Name");
            } 
        }
        private int age;
        public int Age 
        {
            get { return age; }
            set 
            {
                age = value;
                OnPropertyChanged("Age");
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
                OnPropertyChanged("Clr");
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
            return $"Name:{Name},Age:{Age},Color:{Clr}";
        }
    }
    public class ColorConverter : IValueConverter
    {
        //소스 -> 타겟
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            Color clr = (Color)value;
            return new SolidColorBrush(clr);
        }
        //타겟 -> 소스
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value;
        }
    }

    class PersonList : ObservableCollection<Person>
    {
        public PersonList()
        {
            Add(new Person() { Name = "홍길동", Age = 25, Clr = Colors.Black });
            Add(new Person() { Name = "염홍길", Age = 25, Clr = Colors.Gray });
            Add(new Person() { Name = "강호동", Age = 25, Clr = Colors.Yellow });
            Add(new Person() { Name = "하지원", Age = 40, Clr = Colors.Green });
            Add(new Person() { Name = "원빈", Age = 38, Clr = Colors.AliceBlue });
        }
    }
}
