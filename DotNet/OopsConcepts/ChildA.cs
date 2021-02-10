using System;
using System.Collections.Generic;
using System.Text;

namespace OopsConcepts
{
    class ChildA : ParentA
    {
        //this method contains a keyword override, means it is overriden from its parent class.
        public override void GetClassName()
        {
            Console.WriteLine("ChildA");
        }
    }
}
