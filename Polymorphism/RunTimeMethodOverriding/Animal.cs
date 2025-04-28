using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace oops.Polymorphism.RunTimeMethodOverriding
{
    public class Animal
    {
        public virtual void MakeSound(){
            Console.WriteLine("Aminals make sound!!!");
        }
    }
}