using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Univalle.Fie.Sistemas.Unibook.Common;
using Univalle.Fie.Sistemas.Unibook.NewsBrl;

namespace Univalle.Fie.Sistemas.Unibook.NewsTest
{
    /// <summary>
    /// Descripción resumida de NewTest
    /// </summary>
    [TestClass]
    public class NewTest
    {

        ModelUnibookContainer content = new ModelUnibookContainer();

        [TestMethod]
        public void TestCreateNews()
        {
            News news = new News();
            news.Title = "Crisis de Agua en Cochabamba";
            news.Detail = "Municipios de ciudad de Cochabamba sufre de escases de agua";
            news.DateNews = DateTime.Now;
            news.PublicationNews = DateTime.Now;
            news.Discontinued = false;
            news.Deleted = false;
            NewBrl.Insertar(news, content);
            News actual = NewBrl.Get(1, content);
            Assert.AreEqual(news, actual);
        }

        [TestMethod]
        public void TestEditNews()
        {
            News news = NewBrl.Get(2, content);
            news.Title = "No hay agua en Cochabamba";
            news.Detail = "En la ciudad de Cochabamba existe escases de agua";
            news.DateNews = DateTime.Now;
            news.PublicationNews = DateTime.Now;
            NewBrl.Update(news, content);
            Assert.AreEqual(true, true);
        }

        [TestMethod]
        public void TestDeleteNews()
        {
            News news = NewBrl.Get(1, content);
            news.Deleted = true;
            NewBrl.Update(news, content);
            Assert.AreEqual(true, true);
        }

        [TestMethod]
        public void TestGetNews()
        {
            News actual = NewBrl.Get(1, content);
            Assert.AreEqual(actual, actual);
        }
    }
}
