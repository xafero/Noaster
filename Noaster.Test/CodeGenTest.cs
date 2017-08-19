using Noaster.Api;
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
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
            var myEnum = Noast.Create<IEnum>("MyEnum").With(Visibility.Public);
            myEnum.AddValue("Test1");
            myEnum.AddValue("Test2");
            myEnum.AddValue("Test3");
            Console.WriteLine(myEnum);
        }

        [Test]
        public void ShouldGenerateClass()
        {
            var myClass = Noast.Create<IClass>("MyClass").With(Visibility.Public)
                .ChildOf(typeof(Delegate).FullName);
            myClass.AddImplements(typeof(IDisposable).FullName);
            myClass.AddImplements(typeof(ICloneable).FullName);
            Console.WriteLine(myClass);
        }

        [Test]
        public void ShouldGenerateDelegate()
        {
            var myDlgt = Noast.Create<IDelegate>("MyDelegate").With(Visibility.Public);
            Console.WriteLine(myDlgt);
        }

        [Test]
        public void ShouldGenerateInterface()
        {
            var myIntf = Noast.Create<IInterface>("MyInterface").With(Visibility.Public);
            myIntf.AddImplements(typeof(IDisposable).FullName);
            myIntf.AddImplements(typeof(ICloneable).FullName);
            Console.WriteLine(myIntf);
        }

        [Test]
        public void ShouldGenerateStruct()
        {
            var myStruct = Noast.Create<IStruct>("MyStruct").With(Visibility.Public);
            myStruct.AddAttribute(typeof(SerializableAttribute).FullName);
            Console.WriteLine(myStruct);
        }

        [Test]
        public void ShouldGenerateMethod()
        {
            var myMeth = Noast.Create<IMethod>("MyMethod").With(Visibility.Public);
            var attr = myMeth.AddAttribute(typeof(DllImportAttribute).FullName);
            attr.Values.Add("cfgmgr32.dll");
            attr.Values.Add(44);
            attr.Values.Add(true);
            attr.Properties["Entrypoint"] = "Calc";
            attr.Properties["Count"] = 43;
            attr.Properties["SetLastError"] = true;
            myMeth.ReturnType = typeof(long).FullName;
            myMeth.Body = "System.Console.WriteLine(\"Hello world!\");" +
                          "throw new System.InvalidOperationException();";
            myMeth.AddParameter("a", "int");
            myMeth.AddParameter("b", "int", ParamModifier.Ref);
            myMeth.AddParameter("c", "int", ParamModifier.Out);
            Console.WriteLine(myMeth);
        }

        [Test]
        public void ShouldGenerateProperty()
        {
            var myProp = Noast.Create<IProperty>("MyProperty").With(Visibility.Public);
            Console.WriteLine(myProp);
        }

        [Test]
        public void ShouldGenerateEvent()
        {
            var myEvent = Noast.Create<IEvent>("MyEvent").With(Visibility.Public);
            Console.WriteLine(myEvent);
        }

        [Test]
        public void ShouldGenerateField()
        {
            var myField = Noast.Create<IField>("MyField").With(Visibility.Public);
            Console.WriteLine(myField);
        }

        [Test]
        public void ShouldGenerateIndexer()
        {
            var myIndx = Noast.Create<IIndexer>("MyIndexer").With(Visibility.Public);
            Console.WriteLine(myIndx);
        }

        [Test]
        public void ShouldGenerateConstructor()
        {
            var myCnstr = Noast.Create<IConstructor>("MyConstructor").With(Visibility.Public);
            Console.WriteLine(myCnstr);
        }

        [Test]
        public void ShouldGenerateOperator()
        {
            var myOp = Noast.Create<IOperator>("UnaryPlus").With(Modifier.Static).With(Visibility.Public);
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

        [Test]
        public void ShouldGenerateMetadata()
        {
            var myInfo = Noast.Create<IMetadata>("Super.Awesome.Lib");
            myInfo.AddUsing("System");
            myInfo.AddUsing("System.Diagnostics");
            myInfo.AddUsing("System.Reflection");
            myInfo.AddUsing("System.Runtime.CompilerServices");
            myInfo.Version = new Version("4.6.1.0");
            myInfo.ClsCompliant = true;
            myInfo.Company = "Autofac";
            myInfo.Configuration = "Debug";
            myInfo.Copyright = "Copyright © 2015 Autofac Contributors";
            myInfo.Description = "Autofac Inversion of Control container for .NET applications.";
            myInfo.Alias = "Autofac";
            myInfo.InternalVersion = "4.6.1-develop-00422";
            myInfo.Product = "Autofac";
            myInfo.Title = "Autofac";
            myInfo.NeutralLocale = "en-US";
            myInfo.ComVisible = false;
            myInfo.Trademark = "";
            myInfo.Culture = "en-GB";
            myInfo.Guid = Guid.NewGuid();
            myInfo.Metadata["Author"] = "PhD Franz Schuster";
            myInfo.Metadata["CreationDate"] = "August 23 2011";
            myInfo.Metadata["Website"] = "www.google.de";
            myInfo.TargetFramework = "4.5";
            Console.WriteLine(myInfo);
        }
    }
}