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

namespace ItemsControlApp
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        public PersonList List { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            List = new PersonList();
            this.DataContext = this;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            var btn = sender as Button;
            MessageBox.Show(btn.DataContext.ToString());
        }
    }


    public class StrList : ObservableCollection<string>
    {
        public string ListName => "연습용 리스트";
        public StrList()
        {
            Add("ABC");
            Add("DEF");
            Add("GIH");
        }
    }

    public class PersonList : ObservableCollection<Person>
    {
        public string ListName => "연습용 리스트";
        public PersonList()
        {
            Add(new Person() { Name = "고영희", Age = 23, Clr = Colors.Beige });
            Add(new Person() { Name = "강아쥐", Age = 41, Clr = Colors.Violet });
            Add(new Person() { Name = "햄스톨", Age = 18, Clr = Colors.SkyBlue });

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
        public event PropertyChangedEventHandler PropertyChanged;

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
            return $"Name : {Name}, Age : {Age}, Color : {Clr}";
        }
    }

    public class ColorConverter : IValueConverter
    {
        //소스 -> 타겟 
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            Color Clr = (Color)value;
            return new SolidColorBrush(Clr);
        }


        //타겟 -> 소스
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value;
        }
    }
}