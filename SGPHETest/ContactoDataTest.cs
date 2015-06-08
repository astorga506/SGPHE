using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LibreriaSistema.data;
using LibreriaSistema.domain;

namespace SGPHETest
{
    /// <summary>
    /// Summary description for ContactoDataTest
    /// </summary>
    [TestClass]
    public class ContactoDataTest
    {
        private ContactoData cd;
        private Contacto contacto;

        public ContactoDataTest()
        {
            cd = new ContactoData("Contactos.xml");
            contacto = new Contacto();
            //contacto.Nombre = "Chirra";
            //contacto.Telefono = "87654321";
            //contacto.Direccion = "Taras";
            //contacto.Correo = "chirra@correo.com";
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void TestMethod1()
        {
            //cd.InsertarContacto(contacto);
            contacto = cd.GetContacto("Chirra");
            Console.WriteLine(contacto.Nombre);
            Console.WriteLine(contacto.Telefono);
            Console.WriteLine(contacto.Direccion);
            Console.WriteLine(contacto.Correo);

        }
    }
}
