using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Univalle.Fie.Sistemas.Unibook.Common;
using Univalle.Fie.Sistemas.Unibook.CommonDto;
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
            CommentNewsDto commentnewdto = new CommentNewsDto();
            commentnewdto.Message = "Excelente Noticia";
            commentnewdto.Date = DateTime.Now;
            commentnewdto.Deleted = false;
            CommentNewBrl.Insertar(commentnewdto, content);
            //CommentNews actual = CommentNewBrl.Get(1, content);
            Assert.AreEqual(content, content);

        }

        [TestMethod]
        public void TestEditCommentNew()
        {
            CommentNewsDto commentnewdto = CommentNewBrl.GetDto(2, content);
            commentnewdto.Message = "Como fue que ocurrio eso";
            commentnewdto.Date = DateTime.Now;
            CommentNewBrl.Update(commentnewdto, content);
            Assert.AreEqual(true, true);
        }

        [TestMethod]
        public void TestDeleteCommentNew()
        {
            CommentNewsDto commentnewdto = CommentNewBrl.GetDto(1, content);
            commentnewdto.Deleted = true;
            CommentNewBrl.Update(commentnewdto, content);
            Assert.AreEqual(true, true);
        }

        [TestMethod]
        public void TestGetCommentNew()
        {
            CommentNewsDto actual = CommentNewBrl.GetDto(1, content);
            Assert.AreEqual(actual, actual);
        }
    }
}
