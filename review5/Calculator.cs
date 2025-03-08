using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace review5
{
    //Use NUnit to write unit tests for a simple calculator class that performs addition, subtraction, multiplication, and division.

    public class Calculator
    {
        public  int Add(int x, int y) { return x + y; }

        public  int Sub(int x, int y) { return x - y; }

        public  int Mul(int x, int y) {return x * y; }

        public int Div(int x, int y) { 

            return x / y;
        }
    }
}
