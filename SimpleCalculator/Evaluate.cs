using System;
using SimpleCalculator;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    public class Evaluate
    {

        public int DoMath(string input)
        {
            int result = 0;
            Parse test = new Parse();
            string op = test.ExtractOperator(input);
            int[] terms = test.ExtractTerms(input);
            int termOne = terms[0];
            int termTwo = terms[1];
            switch (op)
            {
                case "+":
                    result = termOne + termTwo;
                    break;
                case "-":
                    result =  termOne - termTwo;
                    break;
                case "*":
                    result = termOne * termTwo;
                    break;
                case "/":
                    result = termOne / termTwo;
                    break;
                case "%":
                    result = termOne % termTwo;
                    break;
            }
        return result;
        }

        public string lastq(string input)
        {
            Stack lastQuestion = new Stack();
            lastQuestion.lastq = input;
            return lastQuestion.lastq;
        }

        public int last(string input)
        {
            Stack lastAnswer = new Stack();
            lastAnswer.last = DoMath(input);
            return lastAnswer.last;
        }
    }
}
