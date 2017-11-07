using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Univalle.Fie.Sistemas.Unibook.Common;
using Univalle.Fie.Sistemas.UniBook.CommonDto;
using Univalle.Fie.Sistemas.Unibook.NewsBrl;
namespace Univalle.Fie.Sistemas.UniBook.NewsTest
{
    /// <summary>
    /// Descripción resumida de ImageNewTest
    /// </summary>
    [TestClass]
    public class ImageNewTest
    {
        public ImageNewTest()
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
            public void TestCreateImageNew()
            {
                ImageNewsDto imagenewdto = new ImageNewsDto();
                imagenewdto.PathImage = "";
                imagenewdto.Deleted = false;
                ImageNewBrl.Insertar(imagenewdto, content);
                ImageNews actual = ImageNewBrl.Get(1, content);
                Assert.AreEqual(content, actual);

            }

            [TestMethod]
            public void TestEditImageNew()
            {
                ImageNewsDto imagenewdto = ImageNewBrl.GetDto(2, content);
                imagenewdto.PathImage = "";
                ImageNewBrl.Update(imagenewdto, content);
                Assert.AreEqual(true, true);
            }

            [TestMethod]
            public void TestDeleteImageNew()
            {
                ImageNewsDto imagenewdto = ImageNewBrl.GetDto(1, content);
                imagenewdto.Deleted = true;
                ImageNewBrl.Update(imagenewdto, content);
                Assert.AreEqual(true, true);
            }

            [TestMethod]
            public void TestGetImageNew()
            {
                ImageNews actual = ImageNewBrl.Get(1, content);
                Assert.AreEqual(actual, actual);
            }
        }
    }
