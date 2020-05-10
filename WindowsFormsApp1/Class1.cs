using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Class1 : EventArgs
    {
        public int number;
        public string str;

        public Class1(int n, string s)
        {
            number = n;
            str = s;
        }
    }
}
