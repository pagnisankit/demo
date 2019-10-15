using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using demoDLL;

namespace Console_AssemblyConcept
{
    public class Program
    {

        public void newMethod()
        {
            Class1 obj = new Class1();
        }

        static void Main(string[] args)
        {

            //Console.WriteLine(obj.demoMethod());
            //Console.WriteLine(obj);
            SubClass objSubClass = new SubClass();
            objSubClass.Test();
            //objSubClass;
            BaseClass obj = new BaseClass();
            obj.Test();
            Console.WriteLine("This is a msg from console application");
            Console.ReadLine();
        }

        public class BaseClass
        {
            protected internal virtual void Test()
            {
                Console.WriteLine("protected Test method inside base class");
            }

            protected internal void Test1()
            {
                Console.WriteLine("protected Test method inside base class");
            }
        }

        public class SubClass : BaseClass
        {
            public new void Test()
            {
                base.Test();
            }
        }

    }

    
}
