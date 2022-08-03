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
using System.IO;
using DataNS;

namespace _220803_황형준_일기장App
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Date_box.DataContext = new BindData();
            Day_box.DataContext = new BindData();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string a = Date_box.Text;
            string b = Day_box.Text;
            string c = Weather_box.Text;

            string vacation;

            if (Vacation.IsChecked == true)
            {
                vacation = String.Format("오늘은 휴가임~~~");
            }
            else
            {
                vacation = String.Format("오늘은 출근해뚬.");

            }

            string yy = a.Substring(0, 2);
            string mm = a.Substring(2, 2);
            string dd = a.Substring(4, 2);

            string savePath = String.Format(@"C:\Projects\C#\{0}.txt", a);

            string textValue = String.Format("20{0}년 {1}월 {2}일 {3}\n날씨 : {4}\n{5} \n", yy, mm, dd, b, c, vacation);

            System.IO.File.WriteAllText(savePath, textValue, Encoding.Default);
            MessageBox.Show("일기 생성 완료!");
        }
    }
}
