using Noaster.Api.Model.Source;
using NUnit.Framework;
using System;

namespace Noaster.Test
{
    [TestFixture]
    public class CodeGenTest
    {
        [Test]
        public void ShouldGenerateEnum()
        {
        }

        [Test]
        public void ShouldGenerateClass()
        {
            var clazz = Dist.Noaster.Create<ICSharpClassSource>();
            clazz.Namespace = "Example";
            clazz.Name = "Person";
            clazz.addInterface("Serializable");

            var field = clazz.addField();
            field.Name = "serialVersionUID";
            field.Type = typeof(long);
            field.LiteralInitializer = "1L";
            field.setPrivate();
            field.setStatic(true);
            field.setFinal(true);

            var prop = clazz.addProperty(typeof(int), "id");
            prop.setMutable(false);

            prop = clazz.addProperty(typeof(string), "firstName");

            clazz.addProperty("String", "lastName");

            var meth = clazz.addMethod();
            meth.setConstructor(true);
            meth.setPublic();
            meth.setBody("this.id = id;");
            meth.addParameter(typeof(int), "id");

            /*
             * Namespace com.company.example;

            import CSharp.io.Serializable;

            public class Person implements Serializable {

            private static final long serialVersionUID = 1L;
            private final Integer id;
            private String firstName;
            private String lastName;

            public Integer getId() {
            return id;
            }

            public String getFirstName() {
            return firstName;
            }

            public void setFirstName(String firstName) {
            this.firstName = firstName;
            }

            public String getLastName() {
            return lastName;
            }

            public void setLastName(String lastName) {
            this.lastName = lastName;
            }

            public Person(Integer id) {
            this.id = id;
            }
            }
            */


        }

        [Test]
        public void ShouldGenerateDoc()
        {
            var clazz = Dist.Noaster.Create<ICSharpClassSource>();
            clazz.Namespace = "Example";
            clazz.Name = "SomeClass";
            var doc = clazz.XmlDoc;
            doc.FullText = "Full class documentation";
            Console.WriteLine(clazz);
        }

        [Test]
        public void ShouldGenerateDelegate()
        {

        }

        [Test]
        public void ShouldGenerateInterface()
        {

        }

        [Test]
        public void ShouldGenerateStruct()
        {

        }
    }
}