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
using System.Windows.Shapes;
using WpfApp1.Model;

namespace WpfApp1.View
{
    /// <summary>
    /// View.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class View : Window
    {
        public View()
        {
            InitializeComponent();
            this.DataContext = new ViewModel();
        }
    }
}
