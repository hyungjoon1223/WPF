using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        public StrList List { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            List = new StrList();
            List.Add("Hello!");
            List.Add("Hi~!");
            
            this.DataContext = this;
            //this.DataContext = new StrList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {//왼쪽
            List.Add(tb1.Text);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {//오른쪽
            //FindResource() 방법 :검색에서 리소스를 찾음
            //Resources 속성 사용하는 방법 : 객체에서만 리소스를 찾음
            //var lt = this.FindResource("lt") as StrList;
            var lt = lb.FindResource("lt") as StrList;
            //var lt = this.Resources["lt"] as StrList;
            lt.Add(tb2.Text);
        }
    }
    //public class StrList : List<string>
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
}