using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace Step_220_ClassesAndMethodsStill
{
    class MathProblem
    {


        public int a { get; set; }
        public int b { get; set; }
        public int nums { get; set; }
        public int x { get; set; }


        public int Add(int a, int b = 0)
        {
            int x = a + b + 100;
            return x;
        }

        public int Add(int a)
        {
            int x = a + 100;
            return x;
        }
    }
}