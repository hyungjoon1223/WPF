using Microsoft.Win32;
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
using System.Windows.Forms;
using System.IO;
using System.ComponentModel;

namespace _220809_황형준_실습과제
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        double[] DataTime = null;
        double[] DataDist = null;
        double[] DataForce = null;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                using (FolderBrowserDialog openFileDialog = new FolderBrowserDialog())
                {
                    string open = "";
                    if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        open = openFileDialog.SelectedPath;
                    }
                    text.Text = open;
                    Tree.Items.Clear();
                    string[] file = Directory.GetFiles(open);
                    string[] start = Directory.GetDirectories(open, "*.*");
                    foreach (string str in start)
                    {
                        DirectoryInfo strinfo = new DirectoryInfo(str);
                        TreeViewItem item = new TreeViewItem();
                        item.Header = strinfo.Name;
                        item.Tag = strinfo.FullName;
                        item.Expanded += new RoutedEventHandler(item_Expanded);   // 노드 확장시 추가
                        Tree.Items.Add(item);
                        GetSubDirectories(item);
                    }
                    foreach (string str in file)
                    {
                        DirectoryInfo strinfo = new DirectoryInfo(str);
                        TreeViewItem item = new TreeViewItem();
                        item.Header = strinfo.Name;
                        item.Tag = strinfo.FullName;
                        Tree.Items.Add(item);
                    }
                }
            }
            catch (Exception except)
            {

            }
            comboBox1.SelectedIndex = 0;
        }
        private void GetSubDirectories(TreeViewItem itemParent)
        {
            if (itemParent == null) return;
            if (itemParent.Items.Count != 0) return;

            try
            {
                string strPath = itemParent.Tag as string;
                DirectoryInfo dInfoParent = new DirectoryInfo(strPath);
                string[] file = Directory.GetFiles(strPath, "*.*");
                foreach (DirectoryInfo dInfo in dInfoParent.GetDirectories())
                {
                    TreeViewItem item = new TreeViewItem();
                    item.Header = dInfo.Name;
                    item.Tag = dInfo.FullName;
                    item.Expanded += new RoutedEventHandler(item_Expanded);
                    itemParent.Items.Add(item);
                }
                foreach (var str in file)
                {
                    DirectoryInfo strinfo = new DirectoryInfo(str);
                    TreeViewItem item = new TreeViewItem();
                    item.Header = strinfo.Name;
                    item.Tag = strinfo.FullName;
                    itemParent.Items.Add(strinfo.Name);
                }
            }
            catch (Exception except)
            {
                //MessageBox.Show(except.Message);
            }
        }
        void item_Expanded(object sender, RoutedEventArgs e)
        {
            try
            {
                TreeViewItem itemParent = sender as TreeViewItem;
                if (itemParent == null) return;
                if (itemParent.Items.Count == 0) return;
                foreach (TreeViewItem item in itemParent.Items)
                {
                    GetSubDirectories(item);
                }
            }
            catch (Exception except)
            {

            }
        }
            
        private void Tree_SelectedItemChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            try
            {
                TreeViewItem item = Tree.SelectedItem as TreeViewItem;
                string file = item.Tag as string;
                string line = "";
                using (StreamReader sw = new StreamReader(file))
                {
                    sw.ReadLine(); sw.ReadLine(); sw.ReadLine();
                    while (sw.EndOfStream == false)
                    {
                        line += sw.ReadLine() + ",";
                    }
                }
                string[] Info = line.Split(',');
                DataTime = new double[Info.Length / 4];
                DataForce = new double[Info.Length / 4];
                DataDist = new double[Info.Length / 4];
                for (int i = 0; i < Info.Length / 4; i++)
                {
                    DataTime[i] = double.Parse(Info[1 + (4 * i)]);
                    DataForce[i] = double.Parse(Info[3 + (4 * i)]);
                    DataDist[i] = double.Parse(Info[2 + (4 * i)]);
                }

            }
            catch (Exception except)
            {

            }
        }

        private void comboBox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                if (comboBox1.SelectedIndex == 0)
                {
                    Plot.Reset();
                    Plot.Plot.AddScatter(DataTime, DataForce);
                    Plot.Refresh();
                }

                else if (comboBox1.SelectedIndex == 1)
                {
                    Plot.Reset();
                    Plot.Plot.AddScatter(DataDist, DataForce);
                    Plot.Refresh();
                }
            }
            catch (Exception except)
            {

            }
        }
    }
    public class textInfo : Notifier
    {
        private string text;
        public string Text
        {
            get { return text; }
            set
            {
                text = value;
                OnPropertyChanged("text");
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
}
