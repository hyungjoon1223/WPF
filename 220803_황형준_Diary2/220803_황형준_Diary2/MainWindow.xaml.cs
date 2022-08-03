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
using System.Windows.Forms;

namespace _220803_황형준_Diary2
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        string[] filepath;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = true;
            openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                int count = 0;
                filepath = new string[10];
                foreach (string filename in openFileDialog.FileNames)
                {
                    filepath[count] = filename;
                    LoadFiles.Items.Add(System.IO.Path.GetFileName(filename));
                    count++;
                }
            }
        }
        private void LoadFiles_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (LoadFiles.SelectedItems.Count == 1)
            {
                foreach (var file in filepath)
                {
                    if (file.Contains((string)LoadFiles.SelectedItem))
                    {
                        using (StreamReader fas = new StreamReader(file))
                        {
                            StringBuilder sb = new StringBuilder();
                            for (int i = 0; i < 100; ++i)
                            {
                                sb.AppendLine(fas.ReadLine() + "\r\n");
                            }
                            TextBox1.Text = sb.ToString();
                        }
                        break;
                    }
                }
            }
        }
    }
}