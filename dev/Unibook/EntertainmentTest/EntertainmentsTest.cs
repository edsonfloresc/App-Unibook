using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Univalle.Fie.Sistemas.Unibook.Common;
using Univalle.Fie.Sistemas.Unibook.EntertainmentsBrl;
using UsersBrl;
using Univalle.Fie.Sistemas.UniBook.CommonDto;

namespace Univalle.Fie.Sistemas.Unibook.EntertainmentTest
{
    /// <summary>
    /// Descripción resumida de EntertainmentsTest
    /// </summary>
    [TestClass]
    public class EntertainmentsTest
    {

        
        public EntertainmentsTest()
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
        public void TestCreateEntertainment()
        {
       

            EntertainmentDto entertainment = new EntertainmentDto(); 
            entertainment.Title = "Noche de cine Univalle";
            entertainment.DateHour = DateTime.Now;
            entertainment.PlaceAddress = "Cine center av. ramon rivero";
            entertainment.Details = "Ven a disfrutar de una noche con la familia univalle en el cine center las entradas a 10 bs.";
            entertainment.Discontinued = false;
            entertainment.Deleted = false;
            entertainment.CategoryEnter = CategoryBrl.GetDto(1, content);
          //  entertainment.User = UserBrl.GetDto(1, content);
            EntertainmentBrl.Insert(entertainment, content);
            Entertainment actual = EntertainmentBrl.Get(1, content);
            Assert.AreEqual(entertainment, actual);

        }

        [TestMethod]
        public void TestEditEntertainment()
        {
            EntertainmentDto entertainment = EntertainmentBrl.GetDto(1, content);
            entertainment.Details = "cambiamos details";
            EntertainmentBrl.Update(entertainment,content);
            Assert.AreEqual(true, true);
        }

        [TestMethod]
        public void TestDeleteEntertainment()
        {
            Entertainment entertainment = EntertainmentBrl.Get(1, content);
            EntertainmentBrl.Delete(int.Parse(entertainment.EntertainmentId.ToString()), content);
            Assert.AreEqual(true, true);
        }

        [TestMethod]
        public void TestGetEntertainment()
        {
            Entertainment actual = EntertainmentBrl.Get(1, content);
            Assert.AreEqual(actual, actual);
        }


      

    }
}
