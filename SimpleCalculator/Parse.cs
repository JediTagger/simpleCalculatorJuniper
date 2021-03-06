﻿using System;
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
            string[] acceptableOperators = new string[] { "+", "-", "/", "*", "%" };
            if (acceptableOperators.Contains(returnOperator))
            {
                return returnOperator;
            }
            else 
            {
                throw new Exception("That's not a valid operator. Valid operators are + (addition), - (subtraction), * (multiplication), / (division), or % (modulus).");
            }
        }

        public int[] ExtractTerms(string input)
        {
            char[] delimiterChar = { ' ' };
            string[] expressionElements = input.Split(delimiterChar);
            int firstTerm;
            int secondTerm;
            bool firstTermIsInt = int.TryParse(expressionElements[0], out firstTerm);
            bool secondTermIsInt = int.TryParse(expressionElements[2], out secondTerm);
            if (firstTermIsInt && secondTermIsInt)
            {
                int[] returnTerms = { firstTerm, secondTerm };
                return returnTerms;
            }
            else
            {
                throw new Exception("That's not a valid term.  Only integers are valid terms.");
            }
        }


    }
}
