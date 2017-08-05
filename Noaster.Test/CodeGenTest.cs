using Noaster.Api;
using NUnit.Framework;
using System;
using System.Text;

namespace Noaster.Test
{
    [TestFixture]
    public class CodeGenTest
    {
        [Test]
        public void ShouldGenerateEnum()
        {
            var myEnum = Dist.Noaster.Create<IEnum>("MyEnum");
            Console.WriteLine(myEnum);
        }

        [Test]
        public void ShouldGenerateClass()
        {
            var myClass = Dist.Noaster.Create<IClass>("MyClass");
            Console.WriteLine(myClass);
        }

        [Test]
        public void ShouldGenerateDelegate()
        {
            var myDlgt = Dist.Noaster.Create<IDelegate>("MyDelegate");
            Console.WriteLine(myDlgt);
        }

        [Test]
        public void ShouldGenerateInterface()
        {
            var myIntf = Dist.Noaster.Create<IInterface>("MyInterface");
            Console.WriteLine(myIntf);
        }

        [Test]
        public void ShouldGenerateStruct()
        {
            var myStruct = Dist.Noaster.Create<IStruct>("MyStruct");
            Console.WriteLine(myStruct);
        }

        [Test]
        public void ShouldGenerateMethod()
        {
            var myMeth = Dist.Noaster.Create<IMethod>("MyMethod");
            Console.WriteLine(myMeth);
        }

        [Test]
        public void ShouldGenerateProperty()
        {
            var myProp = Dist.Noaster.Create<IProperty>("MyProperty");
            Console.WriteLine(myProp);
        }

        [Test]
        public void ShouldGenerateEvent()
        {
            var myEvent = Dist.Noaster.Create<IEvent>("MyEvent");
            Console.WriteLine(myEvent);
        }

        [Test]
        public void ShouldGenerateField()
        {
            var myField = Dist.Noaster.Create<IField>("MyField");
            Console.WriteLine(myField);
        }

        [Test]
        public void ShouldGenerateIndexer()
        {
            var myIndx = Dist.Noaster.Create<IIndexer>("MyIndexer");
            Console.WriteLine(myIndx);
        }

        [Test]
        public void ShouldGenerateConstructor()
        {
            var myCnstr = Dist.Noaster.Create<IConstructor>("MyConstructor");
            Console.WriteLine(myCnstr);
        }

        [Test]
        public void ShouldGenerateOperator()
        {
            var myOp = Dist.Noaster.Create<IOperator>("MyOperator");
            Console.WriteLine(myOp);
        }

        [Test]
        public void ShouldGenerateAll()
        {
            var aNsp = Dist.Noaster.Create<INamespace>("System.IO.Nasa");
            aNsp.Usings.Add(Dist.Noaster.Create<IUsing>(typeof(StringBuilder).Namespace));
            var aStruct = Dist.Noaster.Create<IStruct>("HelloStruct", aNsp);
            var anEnum = Dist.Noaster.Create<IEnum>("HelloEnum", aNsp);
            var anInterf = Dist.Noaster.Create<IInterface>("HelloInterf", aNsp);
            var aClass = Dist.Noaster.Create<IClass>("HelloClass", aNsp);
            var aDeleg = Dist.Noaster.Create<IDelegate>("HelloDelegate", aNsp);
            Console.WriteLine(aNsp);
        }
    }
}