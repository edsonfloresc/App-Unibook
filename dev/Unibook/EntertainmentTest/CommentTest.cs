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
    /// Descripción resumida de CommentTest
    /// </summary>
    [TestClass]
    public class CommentTest
    {
        public CommentTest()
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
        public void TestCreateComment()
        {


            CommentEnter comment = new CommentEnter();
            comment.CommentText = "Ejemplo de comentario";
            comment.DateHour = DateTime.Now;
            comment.Deleted = false;
            comment.Entertainment = EntertainmentBrl.Get(1, content);
            comment.User = UserBrl.Get(1, content);
            CommentBrl.Insert(comment, content);
            CommentEnter actual = CommentBrl.Get(1, content);
            Assert.AreEqual(comment, actual);

        }

        [TestMethod]
        public void TestEditComment()
        {
            CommentEnter comment = CommentBrl.Get(1, content);
            comment.CommentText= "cambiamos de comentario";
            CommentBrl.Update(content);
            Assert.AreEqual(true, true);
        }

        [TestMethod]
        public void TestDeleteComment()
        {
            CommentEnter comment = CommentBrl.Get(1, content);
            CommentBrl.Delete(int.Parse(comment.CommentId.ToString()), content);
            Assert.AreEqual(true, true);
        }

        [TestMethod]
        public void TestGetComment()
        {
            CommentEnter actual = CommentBrl.Get(1, content);
            Assert.AreEqual(actual, actual);
        }
    }
}
