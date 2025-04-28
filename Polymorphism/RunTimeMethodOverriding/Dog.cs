using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace oops.Polymorphism.RunTimeMethodOverriding
{
    public class Dog : Animal
    {
        public override void MakeSound(){
            Console.WriteLine("Dog barks!!!");
        }
    }
}