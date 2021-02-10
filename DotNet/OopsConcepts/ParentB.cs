using System;

namespace OopsConcepts
{
    //ParentB implements InterfaceClass
    class ParentB : IClass
    {
        //need to implement all methods of Interface class, as all are abstract
        void IClass.Method1()
        {
            Console.WriteLine("Inside Method1");
        }

        void IClass.Method2()
        {
            Console.WriteLine("Inside Method2");
        }
    }
}
