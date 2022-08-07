using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ScottPlot;
using System.IO;
namespace _220825_황형준_NG
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filepath = openFileDialog1.FileName;
                fileExtension = Path.GetFileName(filepath);
                var lineCount = File.ReadLines(fileExtension).Count() - 3;
                pictureBox1.Load("before.JPG");
                pictureBox2.Load("after.JPG");
                DataTime = new double[lineCount];
                DataForce = new double[lineCount];
                DataDist = new double[lineCount];
                StreamReader sr = new StreamReader(fileExtension);
                int lineNum = 0;
                string temp = null;
                while (!sr.EndOfStream)
                {
                    temp = sr.ReadLine();
                    if (lineNum >= 3)
                    {
                        fileData = temp.Split(',');
                        DataTime[lineNum - 3] = double.Parse(fileData[1]);
                        DataDist[lineNum - 3] = double.Parse(fileData[2]);
                        DataForce[lineNum - 3] = double.Parse(fileData[3]);
                    }
                    ++lineNum;
                }
                comboBox1.SelectedIndex = 0;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        string filepath = null;
        string fileExtension = null;
        string[] fileData = null;

        double[] DataTime = null;
        double[] DataDist = null;
        double[] DataForce = null;

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                formsPlot1.Reset();
                formsPlot1.Plot.AddScatter(DataTime, DataForce);
                formsPlot1.Refresh();
            }

            else if (comboBox1.SelectedIndex == 1)
            {
                formsPlot1.Reset();
                formsPlot1.Plot.AddScatter(DataDist, DataForce);
                formsPlot1.Refresh();
            }
        }
    }
}
