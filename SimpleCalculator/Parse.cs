using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    public class Parse
    {
        public string ExtractOperator(string input)
        {
            char[] delimiterChar = { ' ' };
            string[] expressionElements = input.Split(delimiterChar);
            string returnOperator = expressionElements[1];
            return returnOperator;
        }

    }
}
