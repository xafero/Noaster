using System;
using System.Text;
using Noaster.Impl.Types;
using Noaster.Impl.Base;

namespace Noaster.Impl
{
    public static class Program
    {
        public static void Main()
        {
            var aNsp = new NamespaceImpl("System.IO.Nasa");
            aNsp.Usings.Add(new UsingImpl(typeof(StringBuilder).Namespace));

            var aStruct = new StructImpl(aNsp, "HelloStruct");
            var anEnum = new EnumImpl(aNsp, "HelloEnum");
            var anInterf = new InterfaceImpl(aNsp, "HelloInterf");
            var aClass = new ClassImpl(aNsp, "HelloClass");
            var aDeleg = new DelegateImpl(aNsp, "HelloDelegate");

            Console.WriteLine(aNsp);

            Console.ReadLine();
        }
    }
}