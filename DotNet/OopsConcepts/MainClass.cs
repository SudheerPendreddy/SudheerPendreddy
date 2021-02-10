using System;
using System.Collections.Generic;
using System.Text;

namespace OopsConcepts
{
    class MainClass
    {
        static void Main(String[] args)
        {
            // We can create an object for Regular class but we cannot create for abstract class, and interfaces
            ParentA obj = new ParentA();
            obj.Method1();
            //This refers to the method in ParentA, as the object is of type ParentA.
            obj.GetClassName();

            ParentA obj1 = new ChildA();
            //This refers to the method in ChildA, as the object is of type ChildA.
            obj1.GetClassName();
        }
    }
}
