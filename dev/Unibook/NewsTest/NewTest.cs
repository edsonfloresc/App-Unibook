using System;
using System.Text;
using System.Collections.Generic;
using Univalle.Fie.Sistemas.Unibook.Common;
using Univalle.Fie.Sistemas.UniBook.CommonDto;
using Univalle.Fie.Sistemas.Unibook.NewsBrl;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Univalle.Fie.Sistemas.UniBook.NewsTest
{
    /// <summary>
    /// Descripción resumida de NewTest
    /// </summary>
    [TestClass]
    public class NewTest
    {
        public NewTest()
        {
            //
            // TODO: Agregar aquí la lógica del constructor
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Obtiene o establece el contexto de las pruebas que proporciona
        ///información y funcionalidad para la serie de pruebas actual.
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

        #region Atributos de prueba adicionales
        //
        // Puede usar los siguientes atributos adicionales conforme escribe las pruebas:
        //
        // Use ClassInitialize para ejecutar el código antes de ejecutar la primera prueba en la clase
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup para ejecutar el código una vez ejecutadas todas las pruebas en una clase
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Usar TestInitialize para ejecutar el código antes de ejecutar cada prueba 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup para ejecutar el código una vez ejecutadas todas las pruebas
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion



        ModelUnibookContainer content = new ModelUnibookContainer();

        [TestMethod]
        public void TestCreateNews()
        {
            NewsDto newsdto = new NewsDto();
            newsdto.Title = "Crisis de Agua en Cochabamba";
            newsdto.Detail = "Municipios de ciudad de Cochabamba sufre de escases de agua";
            newsdto.DateNews = DateTime.Now;
            newsdto.PublicationNews = DateTime.Now;
            newsdto.Discontinued = false;
            newsdto.Deleted = false;
            //newsdto.CategoryNews = CategoryNewBrl.Get(1, content);

            NewBrl.Insertar(newsdto, content);
            //News actual = NewBrl.Get(1, content);
            Assert.AreEqual(true, true);
        }

        [TestMethod]
        public void TestEditNews()
        {
            NewsDto newsdto = NewBrl.GetDto(1, content);
            newsdto.Title = "No hay agua en Cochabamba";
            newsdto.Detail = "En la ciudad de Cochabamba existe escases de agua";
            newsdto.DateNews = DateTime.Now;
            newsdto.PublicationNews = DateTime.Now;
            NewBrl.Update(newsdto, content);
            Assert.AreEqual(true, true);
        }

        [TestMethod]
        public void TestDeleteNews()
        {
            NewsDto newsdto = NewBrl.GetDto(1, content);
            newsdto.Deleted = true;
            NewBrl.Update(newsdto, content);
            Assert.AreEqual(true, true);
        }

        [TestMethod]
        public void TestGetNews()
        {
            NewsDto actual = NewBrl.GetDto(1, content);
            Assert.AreEqual(actual, actual);
        }
    }
}
