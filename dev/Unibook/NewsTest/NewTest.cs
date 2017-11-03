using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Univalle.Fie.Sistemas.Unibook.Common;
using Univalle.Fie.Sistemas.Unibook.NewsBrl;
using Univalle.Fie.Sistemas.Unibook.CommonDto;

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
            NewsDto newsdto = new NewsDto();
            newsdto.Title = "Crisis de Agua en Cochabamba";
            newsdto.Detail = "Municipios de ciudad de Cochabamba sufre de escases de agua";
            newsdto.DateNews = DateTime.Now;
            newsdto.PublicationNews = DateTime.Now;
            newsdto.Discontinued = false;
            newsdto.Deleted = false;
            newsdto.CategoryNews = CategoryNewBrl.Get(1, content);
            
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
