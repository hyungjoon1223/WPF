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
    }
    public class StrList : List<string>
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