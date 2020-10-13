using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
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
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
           
            
                MathProblem problem = new MathProblem();
                Console.WriteLine(problem.Add(a, b));
                Console.ReadLine();
        }
    }}

