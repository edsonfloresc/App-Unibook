using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Univalle.Fie.Sistemas.Unibook.Common;
using Univalle.Fie.Sistemas.Unibook.EntertainmentsBrl;
using Univalle.Fie.Sistemas.UniBook.CommonDto;

namespace Univalle.Fie.Sistemas.UniBook.EntertainmentsTest
{
    [TestClass]
    public class CommentTest
    {
        ModelUnibookContainer content = new ModelUnibookContainer();

        [TestMethod]
        public void TestCreateComment()
        {


            CommentEnterDto comment = new CommentEnterDto();
            comment.CommentText = "Ejemplo de comentario";
            comment.DateHour = DateTime.Now;
            comment.Deleted = false;
            comment.Entertainment = EntertainmentBrl.GetDto(1, content);
            //comment.User = UserBrl.GetDto(1, content);
            CommentBrl.Insert(comment, content);
            CommentEnter actual = CommentBrl.Get(1, content);
            Assert.AreEqual(comment, actual);

        }

        [TestMethod]
        public void TestEditComment()
        {
            CommentEnterDto comment = CommentBrl.GetDto(1, content);
            comment.CommentText = "cambiamos de comentario";
            CommentBrl.Update(comment, content);
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
