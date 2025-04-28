using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace oops.practice
{
    public class Cat: Animal
    {
        public override void MakeSound(){
            Console.WriteLine("Cat meows!!!");
        }
    }
}