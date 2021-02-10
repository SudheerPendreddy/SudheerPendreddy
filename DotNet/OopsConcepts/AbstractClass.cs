using System;
using System.Collections.Generic;
using System.Text;

namespace OopsConcepts
{
    //Abstractclass contains minimum one abstract method and one regular method and declared with a key word abstract
    abstract class AbstractClass
    {
        //Abstract Method
        public abstract void Method1();

        //Regular Method
        public void Method2()
        {
            Console.WriteLine("Inside Method2");
        }

    }
}
