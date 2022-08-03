using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataNS
{
    public class BindData
    {
        public string DataStr { get; set; }
        public int DataInt { get; set; } 

        public BindData() : this("none", 0)
        {

        }
        public BindData(string s, int n)
        {
            DataStr = s;
            DataInt = n;
        }
        public override string ToString()
        {
            return $"[{DataStr}] : [{DataInt}]";
        }
    }
}
