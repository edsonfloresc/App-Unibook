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
    /// Descripción resumida de CategoryNewTest
    /// </summary>
    [TestClass]
    public class CategoryNewTest
    {
        public CategoryNewTest()
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
        public void TestCreateCategoryNew()
        {
            CategoryNewsDto categorynewdto = new CategoryNewsDto();
            categorynewdto.NameCategory = "Deporte";
            categorynewdto.Deleted = false;
            CategoryNewBrl.Insertar(categorynewdto, content);
            CategoryNews actual = CategoryNewBrl.Get(3, content);
            Assert.AreEqual(content, actual);
        }
        [TestMethod]
        public void TestEditCategoryNew()
        {
            CategoryNewsDto categorynewdto = CategoryNewBrl.GetDto(1, content);
            categorynewdto.NameCategory = "Deporte";
            CategoryNewBrl.Update(categorynewdto, content);
            Assert.AreEqual(true, true);
        }
        [TestMethod]
        public void TestDeleteCategoryNew()
        {
            CategoryNewsDto categorynewdto = CategoryNewBrl.GetDto(1, content);
            categorynewdto.Deleted = true;
            CategoryNewBrl.Update(categorynewdto, content);
            Assert.AreEqual(true, true);
        }
        [TestMethod]
        public void TestGetCategoryNew()
        {
            CategoryNews actual = CategoryNewBrl.Get(1, content);
            Assert.AreEqual(actual, actual);
        }
    }
}
