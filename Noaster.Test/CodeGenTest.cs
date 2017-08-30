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
        public void ShouldGeneratePartialClass()
        {
            var myClass = Noast.Create<IClass>("MyPartClass").With(Visibility.Public)
                .With(Modifier.Partial);
            myClass.AddImplements(typeof(IDisposable).FullName);
            Console.WriteLine(myClass);
            myClass = Noast.Create<IClass>("MyPartClass").With(Visibility.Public)
                .With(Modifier.Partial);
            var myMeth = Noast.Create<IMethod>("Dispose").With(Visibility.Public);
            myClass.Methods.Add(myMeth);
            Console.WriteLine(myClass);
        }

        [Test]
        public void ShouldGenerateAbstractClass()
        {
            var myClass = Noast.Create<IClass>("A").With(Visibility.Public).With(Modifier.Abstract);
            var myMeth = Noast.Create<IMethod>("DoWork").Accepts("i @ int")
                .With(Visibility.Public).With(Modifier.Abstract);
            myClass.Methods.Add(myMeth);
            Console.WriteLine(myClass);
            myClass = Noast.Create<IClass>("D").With(Visibility.Public);
            myMeth = Noast.Create<IMethod>("DoWork").Accepts("i @ int")
                .With(Visibility.Public).With(Modifier.Virtual);
            myClass.Methods.Add(myMeth);
            Console.WriteLine(myClass);
            myClass = Noast.Create<IClass>("E").With(Visibility.Public).With(Modifier.Abstract);
            myClass.BaseType = Noast.Create<IBase>("D");
            myMeth = Noast.Create<IMethod>("DoWork").Accepts("i @ int")
                .With(Visibility.Public).With(Modifier.Abstract).With(Modifier.Override);
            myClass.Methods.Add(myMeth);
            Console.WriteLine(myClass);
            myClass = Noast.Create<IClass>("F").With(Visibility.Public);
            myClass.BaseType = Noast.Create<IBase>("E");
            myMeth = Noast.Create<IMethod>("DoWork").Accepts("i @ int")
                .With(Visibility.Public).With(Modifier.Override);
            myClass.Methods.Add(myMeth);
            Console.WriteLine(myClass);
            myClass = Noast.Create<IClass>("D").With(Visibility.Public).With(Modifier.Sealed);
            Console.WriteLine(myClass);
            myClass = Noast.Create<IClass>("D").With(Visibility.Public);
            myClass.BaseType = Noast.Create<IBase>("C");
            myMeth = Noast.Create<IMethod>("DoWork")
                .With(Visibility.Public).With(Modifier.Sealed).With(Modifier.Override);
            myClass.Methods.Add(myMeth);
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
            // Manual
            var myProp = Noast.Create<IProperty>("MyProperty").With(Visibility.Public);
            Console.WriteLine(myProp);
            // Automatic            
            var myClass = Noast.Create<IClass>("Autogen");
            var getter = Noast.Create<IMethod>("get_MyProperty").With(Visibility.Public);
            getter.ReturnType = typeof(object).FullName;
            myClass.Methods.Add(getter);
            var setter = Noast.Create<IMethod>("set_MyProperty").With(Visibility.Public);
            setter.AddParameter("value", typeof(object).FullName);
            myClass.Methods.Add(setter);
            Console.WriteLine(myClass);
            // Compare
            Assert.AreEqual(myProp.ToString(), myClass.ToString());
        }

        [Test]
        public void ShouldGenerateEvent()
        {
            // Manual
            var myEvent = Noast.Create<IEvent>("MyEvent").With(Visibility.Public);
            Console.WriteLine(myEvent);
            // Automatic 
            var myClass = Noast.Create<IClass>("Autogen");
            var adder = Noast.Create<IMethod>("add_MyEvent").With(Visibility.Public);
            adder.AddParameter("listener", typeof(object).FullName);
            myClass.Methods.Add(adder);
            var remover = Noast.Create<IMethod>("remove_MyEvent").With(Visibility.Public);
            remover.AddParameter("listener", typeof(object).FullName);
            myClass.Methods.Add(remover);
            Console.WriteLine(myClass);
            // Compare
            Assert.AreEqual(myEvent.ToString(), myClass.ToString());
        }

        [Test]
        public void ShouldGenerateConstructor()
        {
            // Manual
            var myCnstr = Noast.Create<IConstructor>("MyConstructor").With(Visibility.Public);
            Console.WriteLine(myCnstr);
            // Automatic
            var myClass = Noast.Create<IClass>("Autogen");
            var cstr = Noast.Create<IMethod>(".ctor").With(Visibility.Public);
            myClass.Methods.Add(cstr);
            Console.WriteLine(myClass);
            // Compare
            Assert.AreEqual(myCnstr.ToString(), myClass.ToString());
        }

        [Test]
        public void ShouldGenerateInitializer()
        {
            // Manual
            var myCnstr = Noast.Create<IConstructor>("MyConstructor").With(Modifier.Static);
            Console.WriteLine(myCnstr);
            // Automatic
            var myClass = Noast.Create<IClass>("Autogen");
            var cstr = Noast.Create<IMethod>(".cctor");
            myClass.Methods.Add(cstr);
            Console.WriteLine(myClass);
            // Compare
            Assert.AreEqual(myCnstr.ToString(), myClass.ToString());
        }

        [Test]
        public void ShouldGenerateOperator()
        {
            // Manual
            var myOp = Noast.Create<IOperator>("UnaryPlus").With(Modifier.Static).With(Visibility.Public);
            Console.WriteLine(myOp);
            // Automatic
            var myClass = Noast.Create<IClass>("Autogen");
            var op = Noast.Create<IMethod>("op_UnaryPlus").With(Visibility.Public);
            myClass.Methods.Add(op);
            Console.WriteLine(myClass);
            // Compare
            Assert.AreEqual(myOp.ToString(), myClass.ToString());
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
            var myIndx = Noast.Create<IIndexer>("MyIndexer").Accepts("int").With(Visibility.Public);
            Console.WriteLine(myIndx);
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
        public void ShouldGenerateComplexClass()
        {
            var nsp = Noast.Create<INamespace>("MyProject.Complex");
            var cla = Noast.Create<IClass>("Person", nsp).With(Visibility.Public);
            var field = Noast.Create<IField>("cellCount").With(Visibility.Private);
            field.Type = typeof(ulong).FullName;
            cla.Fields.Add(field);
            var meth = Noast.Create<IMethod>("get_Id").With(Visibility.Internal);
            meth.ReturnType = typeof(Guid).FullName;
            cla.Methods.Add(meth);
            meth = Noast.Create<IMethod>("add_IdChanged").With(Visibility.Protected);
            meth.AddParameter("handler", typeof(EventHandler).FullName);
            cla.Methods.Add(meth);
            meth = Noast.Create<IMethod>(".ctor").With(Visibility.ProtectedInternal);
            meth.AddParameter("id", typeof(Guid).FullName);
            meth.AddParameter("name", typeof(string).FullName);
            cla.Methods.Add(meth);
            meth = Noast.Create<IMethod>("op_Inequality").With(Visibility.Public);
            meth.ReturnType = typeof(bool).FullName;
            meth.AddParameter("first", "Person");
            meth.AddParameter("second", "Person");
            cla.Methods.Add(meth);
            meth = Noast.Create<IMethod>("get_Item").With(Visibility.Public);
            meth.AddParameter("index", typeof(int).FullName);
            meth.ReturnType = typeof(string).FullName;
            cla.Methods.Add(meth);
            Console.WriteLine(nsp);
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

        [Test]
        public void ShouldGenerateCustomProps()
        {
            var intf = Noast.Create<IInterface>("MyIntf");
            intf.Methods.Add(Noast.Create<IMethod>("get_ReadOnly").Returns("string"));
            intf.Methods.Add(Noast.Create<IMethod>("set_WriteOnly").Accepts("char"));
            intf.Methods.Add(Noast.Create<IMethod>("get_ReadWrite").Returns("Stream"));
            intf.Methods.Add(Noast.Create<IMethod>("set_ReadWrite").Accepts("Stream"));
            intf.Methods.Add(Noast.Create<IMethod>("add_AutoEvent").Accepts("EventHandler"));
            intf.Methods.Add(Noast.Create<IMethod>("remove_AutoEvent").Accepts("EventHandler"));
            intf.Methods.Add(Noast.Create<IMethod>("get_ReadOnly").Accepts("byte").Returns("string"));
            intf.Methods.Add(Noast.Create<IMethod>("set_WriteOnly").Accepts("short", "string"));
            intf.Methods.Add(Noast.Create<IMethod>("get_ReadWrite").Accepts("int").Returns("string"));
            intf.Methods.Add(Noast.Create<IMethod>("set_ReadWrite").Accepts("int", "string"));
            Console.WriteLine(intf);
        }
    }
}