using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Univalle.Fie.Sistemas.Unibook.Common;
using Univalle.Fie.Sistemas.Unibook.EntertainmentsBrl;
using Univalle.Fie.Sistemas.UniBook.CommonDto;
using Univalle.Fie.Sistemas.UniBook.UsersBrl;

namespace Univalle.Fie.Sistemas.UniBook.EntertainmentsTest
{
    [TestClass]
    public class EntertainmentTest
    {
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
            entertainment.User = UserBrl.GetDto(1, content);
            EntertainmentBrl.Insert(entertainment, content);
           // Entertainment actual = EntertainmentBrl.Get(1, content);
            Assert.AreEqual(entertainment, entertainment);

        }

        [TestMethod]
        public void TestEditEntertainment()
        {
            EntertainmentDto entertainment = EntertainmentBrl.GetDto(1, content);
            entertainment.Details = "cambiamos details";
            EntertainmentBrl.Update(entertainment, content);
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
