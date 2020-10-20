using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Step_220_ClassesAndMethodsStill
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Enter two numbers (The second number is optional)");
            string num1 = Console.ReadLine();
            string num2 = Console.ReadLine();
           
          

            MathProblem problem = new MathProblem();


            int a = Convert.ToInt32(num1);
            if (num2 == "")
            {
                int b = 0;
                Console.WriteLine("This is your new math problem: \n " + num1 + " + 100 = " + (problem.Add(a,b)));
            }

            else
            {
                int b = Convert.ToInt32(num2);
                Console.WriteLine("This is your new math problem: \n " + num1 + " + " + num2 + " + 100 = " + (problem.Add(a, b)));
            }
            Console.ReadLine();
        }
    }
}

