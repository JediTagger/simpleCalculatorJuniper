using System;
using SimpleCalculator;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{ 
     class Program
     { 
         static void Main(string[] args)
         {
            Evaluate eval = new Evaluate();
            Parse parse = new Parse();
            Stack stack = new Stack();
            bool exit = false;

            while (!exit)
            {
                Console.Write("[" + eval.count + "]> ");
                string input = Console.ReadLine();
                if (input == "exit" || input == "quit")
                {
                    exit = true;
                }
                else if (input == "last")
                {
                    Console.WriteLine("Your last answer was " + stack.last + ".");
                }
                else if (input == "lastq")
                {
                    Console.WriteLine("You're last question was " + stack.lastq + ".");
                }
                else
                {
                    try
                    {
                        int solution = eval.DoMath(input);
                        stack.last = solution;
                        stack.lastq = input;
                        Console.WriteLine("   = " + solution);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
            }
            Console.Write("Bye!!");
            Console.Read();
         } 
     }
} 

