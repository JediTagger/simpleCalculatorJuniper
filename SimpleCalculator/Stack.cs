using System;
using SimpleCalculator;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    public class Stack
    {
        public string lastq { get; set; }
        public int last { get; set; }

        public Dictionary<char, int> constants = new Dictionary<char, int>();

        public void MyAdd(char c, int i)
        {
            constants.Add(char.ToLower(c), i);
        }


    }
}
