using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace CommandApp
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        public Person Person { get; set; }
        public PersonInfoCommand PerInfoCommand { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            Person = new Person("홍길동", 30);
            PerInfoCommand = new PersonInfoCommand(Action_PersonInfo);

            this.DataContext = this;
        }
        public void Action_PersonInfo(object param)
        {
            MessageBox.Show(Person.ToString());
        }
        public void Action_CallMethod(object sender, RoutedEventArgs e)
        {
            ++Person.Age;
        }
    }
    public class Person : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private string name = null;
        public string Name { get { return name; }
            set
            {
                name = value;
                PropertyChanged?.Invoke(this , new PropertyChangedEventArgs("Name"));
            }
        }
        private int age = 0;
        public int Age
        {
            get { return age; }
            set
            {
                age = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Age"));
            }
        }
        public Person(string n = "noname", int a= 0)
        {
            Name = n;
            Age = a;
        }
        public override string ToString()
        {
            return $"Name:{Name}, Age{Age}";
        }
    }
    public class PersonInfoCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
        private Action<object> cmdMethod;
        public PersonInfoCommand(Action<object> cm)
        {
            cmdMethod = cm;
        }

        public bool CanExecute(object parameter)
        {
            //체크박스를 누르면 true 안눌려있으면 false
            return true;
        }

        public void Execute(object parameter)
        {
            cmdMethod(parameter);
        }
    }
}
