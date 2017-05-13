using System;
using System.Reflection;

namespace Reflection
{
    public class BaseClass
    {
        public int MyFieldBase;
    }

    public class DerivedClass : BaseClass
    {
        public int MyFieldDerived;
    }   
    
    public class Program
    {
        static void Main()
        {
            Type tbc = typeof(DerivedClass);                        // Get the type.
            Console.WriteLine("Result is {0}.", tbc.Name);

            Console.WriteLine("It has the following fields:");      // Use the type.
            var fi = tbc.GetFields();
            foreach (var f in fi)
                Console.WriteLine(" {0}", f.Name);

            Console.ReadLine();
        }

     }

}

