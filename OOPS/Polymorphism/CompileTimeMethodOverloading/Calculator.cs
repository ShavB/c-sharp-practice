using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// Method overloading, also called as compile time polymorphism.

namespace oops.Polymorphism
{
    public class Calculator
    {
        public int Add(int a, int b){
            return a + b;
        }

        public int Add(int a, int b, int c){
            return a + b +c;
        }

        public int Add(int a, int b, int c, int d){
            return a + b + c + d;
        }
    }
}