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
    /// Descripción resumida de CategoryTest
    /// </summary>
    [TestClass]
    public class CategoryTest
    {
        public CategoryTest()
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
        public void TestCreateCategory()
        {
            CategoryEnter category = new CategoryEnter();
            category.Description = "Eventos";
            category.Deleted = false;
            CategoryBrl.Insert(category, content);
            CategoryEnter actual = CategoryBrl.Get(1, content);
            Assert.AreEqual(category, actual);

        }

        [TestMethod]
        public void TestEditCategory()
        {
            CategoryEnter category = CategoryBrl.Get(1, content);
            category.Description = "Eventos";
            CategoryBrl.Update(content);
            Assert.AreEqual(true, true);
        }

        [TestMethod]
        public void TestDeleteCategory()
        {
            CategoryEnter category = CategoryBrl.Get(1, content);
            CategoryBrl.Delete(category.CategoryId, content);
            Assert.AreEqual(true, true);
        }

        [TestMethod]
        public void TestGetCategory()
        {
            CategoryEnter actual = CategoryBrl.Get(1, content);
            Assert.AreEqual(actual, actual);
        }
    }
}
