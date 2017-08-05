using Noaster.Api;
using NUnit.Framework;
using System;
using System.Text;
using Noaster.Dist;

using Noast = Noaster.Dist.Noaster;

namespace Noaster.Test
{
    [TestFixture]
    public class CodeGenTest
    {
        [Test]
        public void ShouldGenerateEnum()
        {
            var myEnum = Noast.Create<IEnum>("MyEnum");
            Console.WriteLine(myEnum);
        }

        [Test]
        public void ShouldGenerateClass()
        {
            var myClass = Noast.Create<IClass>("MyClass");
            Console.WriteLine(myClass);
        }

        [Test]
        public void ShouldGenerateDelegate()
        {
            var myDlgt = Noast.Create<IDelegate>("MyDelegate");
            Console.WriteLine(myDlgt);
        }

        [Test]
        public void ShouldGenerateInterface()
        {
            var myIntf = Noast.Create<IInterface>("MyInterface");
            Console.WriteLine(myIntf);
        }

        [Test]
        public void ShouldGenerateStruct()
        {
            var myStruct = Noast.Create<IStruct>("MyStruct");
            Console.WriteLine(myStruct);
        }

        [Test]
        public void ShouldGenerateMethod()
        {
            var myMeth = Noast.Create<IMethod>("MyMethod");
            Console.WriteLine(myMeth);
        }

        [Test]
        public void ShouldGenerateProperty()
        {
            var myProp = Noast.Create<IProperty>("MyProperty");
            Console.WriteLine(myProp);
        }

        [Test]
        public void ShouldGenerateEvent()
        {
            var myEvent = Noast.Create<IEvent>("MyEvent");
            Console.WriteLine(myEvent);
        }

        [Test]
        public void ShouldGenerateField()
        {
            var myField = Noast.Create<IField>("MyField");
            Console.WriteLine(myField);
        }

        [Test]
        public void ShouldGenerateIndexer()
        {
            var myIndx = Noast.Create<IIndexer>("MyIndexer");
            Console.WriteLine(myIndx);
        }

        [Test]
        public void ShouldGenerateConstructor()
        {
            var myCnstr = Noast.Create<IConstructor>("MyConstructor");
            Console.WriteLine(myCnstr);
        }

        [Test]
        public void ShouldGenerateOperator()
        {
            var myOp = Noast.Create<IOperator>("UnaryPlus");
            Console.WriteLine(myOp);
        }

        [Test]
        public void ShouldGenerateParameter()
        {
            var myParm = Noast.Create<IParameter>("myParam");
            Console.WriteLine(myParm);
        }

        [Test]
        public void ShouldGenerateAll()
        {
            var aNsp = Noast.Create<INamespace>("System.IO.Nasa");
            aNsp.AddUsing(typeof(StringBuilder).Namespace);
            var aStruct = Noast.Create<IStruct>("HelloStruct", aNsp);
            var anEnum = Noast.Create<IEnum>("HelloEnum", aNsp);
            var anInterf = Noast.Create<IInterface>("HelloInterf", aNsp);
            var aClass = Noast.Create<IClass>("HelloClass", aNsp);
            var aDeleg = Noast.Create<IDelegate>("HelloDelegate", aNsp);
            Console.WriteLine(aNsp);
        }
    }
}