﻿using Noaster.Api;
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