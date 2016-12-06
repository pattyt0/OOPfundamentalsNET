using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefineMyInterface
{
    using System;
    public interface IMyInterface{
        void MethodB();
    }
}

namespace extensions
{
    using System;
    using DefineMyInterface;

    public static class MyExtension
    {
        public static void MethodA(this IMyInterface myInterface, int i)
        {
            Console.WriteLine("Extension.MethodA(this myInterface, int i)");
        }

        public static void MethodA(this IMyInterface myInterface, string s)
        {
            Console.WriteLine("Extension.MethodA(this myInterface, stirng s)");
        }

        public static void MethodB(this IMyInterface myInterface)
        {
            Console.WriteLine("Extension.MethodB(this myInterface)");
        }
    }
}

namespace ExtensionMethodsDemo1 {
    using System;
    using extensions;
    using DefineMyInterface;

    class A : IMyInterface
    {
        public void MethodB() {
            Console.WriteLine("A.MethodB()");
        }
    }

    class B : IMyInterface
    {
        public void MethodB() {
            Console.WriteLine("B.MethodB()");

        }

    }
}