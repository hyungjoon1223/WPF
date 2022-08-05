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
        private PersonList perList = new PersonList();
        public PersonList PerList => perList;

        private Person addPerson = new Person();
        public Person AddPerson => addPerson;

        public MainWindow()
        {
            InitializeComponent();
            AddPerson.Name = "홍길동";
            AddPerson.Age = 20;
            AddPerson.Clr = Colors.Blue;

            this.DataContext = this;
            //this.DataContext = this;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            PerList.Add(AddPerson);
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (lb1.SelectedIndex >= 0)
                PerList.RemoveAt(lb1.SelectedIndex);
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
            MessageBox.Show("Person 두번째 버튼 클릭");
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

    public class PersonList : ObservableCollection<Person>
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
