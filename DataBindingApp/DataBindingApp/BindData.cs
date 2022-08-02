using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBindingApp
{
    public class BindData
    {
        public string DataStr { get; set; }
        public int DataInt { get; set; }

        public BindData() : this("", 0)
        {

        }
        public BindData(string s, int n)
        {
            DataStr = s;
            DataInt = n;
        }
    }
}
