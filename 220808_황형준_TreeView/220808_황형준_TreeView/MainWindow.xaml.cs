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

namespace _220808_황형준_TreeView
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            // foreach (string str in Directory.GetDirectories(""))   // 특정폴더
            foreach (string str in Directory.GetLogicalDrives())   // 루트폴더
            {
                try
                {
                    TreeViewItem item = new TreeViewItem();
                    item.Header = str;
                    item.Tag = str;
                    item.Expanded += new RoutedEventHandler(item_Expanded);   // 노드 확장시 추가

                    Tree.Items.Add(item);
                    GetSubDirectories(item);
                }

                catch (Exception except)
                {
                    // 얘 주석 풀면 오류메세지가 뜨네 왜 이럴까?
                    //MessageBox.Show(except.Message);  
                }
            }
        }
        private void GetSubDirectories(TreeViewItem itemParent)
        {
            if (itemParent == null) return;
            if (itemParent.Items.Count != 0) return;

            try
            {
                string strPath = itemParent.Tag as string;
                DirectoryInfo dInfoParent = new DirectoryInfo(strPath);
                foreach (DirectoryInfo dInfo in dInfoParent.GetDirectories())
                {
                    TreeViewItem item = new TreeViewItem();
                    item.Header = dInfo.Name;
                    item.Tag = dInfo.FullName;
                    item.Expanded += new RoutedEventHandler(item_Expanded);
                    itemParent.Items.Add(item);
                }
            }
            catch (Exception except)
            {
                //MessageBox.Show(except.Message);
            }
        }
        void item_Expanded(object sender, RoutedEventArgs e)
        {
            TreeViewItem itemParent = sender as TreeViewItem;
            if (itemParent == null) return;
            if (itemParent.Items.Count == 0) return;
            foreach (TreeViewItem item in itemParent.Items)
            {
                GetSubDirectories(item);
            }
        }
    }
}
