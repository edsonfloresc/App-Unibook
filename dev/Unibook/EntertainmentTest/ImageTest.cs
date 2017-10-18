using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Univalle.Fie.Sistemas.Unibook.Common;
using Univalle.Fie.Sistemas.Unibook.EntertainmentsBrl;
using UsersBrl;

namespace Univalle.Fie.Sistemas.Unibook.EntertainmentTest
{
    /// <summary>
    /// Descripción resumida de ImageTest
    /// </summary>
    [TestClass]
    public class ImageTest
    {
        public ImageTest()
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
        public void TestCreateImage()
        {


            ImageEnter image = new ImageEnter();
            image.PathImage = "Ejemplo de path";
            image.Deleted = false;
            ImageBrl.Insert(image, content);
            ImageEnter actual = ImageBrl.Get(1, content);
            Assert.AreEqual(image, actual);

        }

        [TestMethod]
        public void TestEditImage()
        {
            ImageEnter image = ImageBrl.Get(1, content);
            image.PathImage = "cambiamos de path";
            ImageBrl.Update(content);
            Assert.AreEqual(true, true);
        }

        [TestMethod]
        public void TestDeleteImage()
        {
            ImageEnter image = ImageBrl.Get(1, content);
            ImageBrl.Delete(int.Parse(image.ImageId.ToString()), content);
            Assert.AreEqual(true, true);
        }

        [TestMethod]
        public void TestGetImage()
        {
            ImageEnter actual = ImageBrl.Get(1, content);
            Assert.AreEqual(actual, actual);
        }


    }
}
