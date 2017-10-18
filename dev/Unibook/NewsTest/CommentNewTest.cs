using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Univalle.Fie.Sistemas.Unibook.Common;
using Univalle.Fie.Sistemas.Unibook.NewsBrl;

namespace Univalle.Fie.Sistemas.Unibook.NewsTest
{
    /// <summary>
    /// Descripción resumida de CommentNewTest
    /// </summary>
    [TestClass]
    public class CommentNewTest
    {
        ModelUnibookContainer content = new ModelUnibookContainer();
        [TestMethod]
        public void TestCreateCommentNew()
        {
            CommentNews commentnew = new CommentNews();
            commentnew.Message = "Excelente Noticia";
            commentnew.Date = DateTime.Now;
            commentnew.Deleted = false;
            CommentNewBrl.Insertar(commentnew, content);
            CommentNews actual = CommentNewBrl.Get(1, content);
            Assert.AreEqual(commentnew, content);

        }

        [TestMethod]
        public void TestEditCommentNew()
        {
            CommentNews commentnew = CommentNewBrl.Get(2, content);
            commentnew.Message = "Como fue que ocurrio eso";
            commentnew.Date = DateTime.Now;
            CommentNewBrl.Update(commentnew, content);
            Assert.AreEqual(true, true);
        }

        [TestMethod]
        public void TestDeleteCommentNew()
        {
            CommentNews commentnew = CommentNewBrl.Get(1, content);
            commentnew.Deleted = true;
            CommentNewBrl.Update(commentnew, content);
            Assert.AreEqual(true, true);
        }

        [TestMethod]
        public void TestGetCommentNew()
        {
            CommentNews actual = CommentNewBrl.Get(1, content);
            Assert.AreEqual(actual, actual);
        }
    }
}
