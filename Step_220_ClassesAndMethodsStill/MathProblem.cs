using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace Step_220_ClassesAndMethodsStill
{
    class MathProblem



    {
        
        public int Add(int a, int b = 0)
        {
            X = a + b + 100;
            return X;
        }


       public int X { get; set; }
    }
    }
