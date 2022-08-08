using System;
using System.Collections;
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
        
        private ListCollectionView perListView1 = null;
        public ListCollectionView PerListView1 => perListView1;
        private ListCollectionView perListView2 = null;
        public ListCollectionView PerListView2 => perListView2;

        private Person addPerson = new Person();
        public Person AddPerson => addPerson;

        private AddPersonCommand addPersonCommad { get; set; }

        public AddPersonCommand AddPersonCommad { get { return addPersonCommad; } }

        public MainWindow()
            {
                InitializeComponent();
            
            addPerson.Name = "홍길동";
            addPerson.Age = 25;
            addPerson.Clr = Colors.AliceBlue;

            addPersonCommad = new AddPersonCommand(Button_Click);

            perListView1 = new ListCollectionView(perList);
            perListView2 = new ListCollectionView(perList);
            this.DataContext = this;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            perList.Add(addPerson);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ICollectionView icv= CollectionViewSource.GetDefaultView(PerList);
                perList.Remove(icv.CurrentItem as Person);
            
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {//첫 뷰 필터링
            if (PerListView1.Filter == null)
            {
                PerListView1.Filter = (per) =>
                {
                    Person person = per as Person;
                    return person.Age > 25;
                };
            }
            else
            {
                PerListView1.Filter = null;
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {//첫 뷰 정렬
            if (PerListView1.SortDescriptions.Count == 0)
            {
                PerListView1.SortDescriptions.Add(
                    new SortDescription("Name", ListSortDirection.Ascending));
            }
            else
            {
                PerListView1.SortDescriptions.Clear();
            }
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {//두번째 뷰 필터링
            if (PerListView2.Filter == null)
            {
                PerListView2.Filter = (per) =>
                {
                    Person person = per as Person;
                    return person.Name.Contains("길") || person.Name.Contains("동");
                };
            }
            else
            {
                PerListView2.Filter = null;
            }
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {//두번째 뷰 정렬
            if (PerListView2.CustomSort == null)
            {
                PerListView2.CustomSort = new PersonSorter("Name");
            }
            else
            {
                PerListView2.CustomSort = null;
            }

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
            MessageBox.Show("Person 두 번째버튼클릭");

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
            Add(new Person() { Name = "강호동", Age = 25, Clr = Colors.Yellow });
            Add(new Person() { Name = "강호동", Age = 25, Clr = Colors.Yellow });
            Add(new Person() { Name = "강호동", Age = 25, Clr = Colors.Yellow });
            Add(new Person() { Name = "강호동", Age = 25, Clr = Colors.Yellow });
            Add(new Person() { Name = "강호동", Age = 25, Clr = Colors.Yellow });
            Add(new Person() { Name = "하지원", Age = 40, Clr = Colors.Green });
            Add(new Person() { Name = "원빈", Age = 38, Clr = Colors.AliceBlue });
        }
    }

    public class PersonSorter : IComparer
    {
        private string Property;
        public PersonSorter(string prop)
        {
            Property = prop;
        }
        public int Compare(object x, object y)
        {
            Person lhs= x as Person;
            Person rhs= y as Person;
            if (Property=="Name")
            {
                return lhs.Name.CompareTo(rhs.Name);
            }
            else
            {
                if(lhs.Age>rhs.Age)
                {
                    return 1;
                }
                else if (lhs.Age < rhs.Age)
                {
                    return -1;
                }
                else 
                {
                    return 0;
                }
            }
        }
    }

    public class AddPersonCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
        public Action<object, RoutedEventArgs> Exec;
        public AddPersonCommand(Action<object, RoutedEventArgs> exec)
        {
            Exec = exec;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            Exec(null, null);
        }
    }
    public class AgeValidation : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            if( !int.TryParse(value.ToString(), out var num))
            {
                return new ValidationResult(false, "정수를 입력해야 합니다!!");
            }
            if( !(0<= num && num <= 120))
            {
                return new ValidationResult(false, "나이는 0 ~ 120 사이의 정수 입니다.");
            }
            return new ValidationResult(true, null);
        }
    }
}
