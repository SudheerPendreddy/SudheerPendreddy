using System;
using System.Collections.Generic;
using System.Text;

namespace OopsConcepts
{
    //ParentA inherits Abstractclass
    class ParentA : AbstractClass
    {
        //Abstract Method needs to be implemented
        //override keword is used as we are overriding the method from AbstractClass
        public override void Method1()
        {
            Console.WriteLine("Inside Method 1");
        }

        public int Add(int a, int b)
        {
            int sum = a + b;
            return sum;
        }

        //same method signature but different parameters, this is called as method overloading
        public int Add(int a, int b, int c)
        {
           int sum = a + b + c;
            return sum;
        }

        //It contains a keyword virtual, means this method can be overriden in its child class
        public virtual void GetClassName()
        {
            Console.WriteLine("ParentA");
        }

    }
}
