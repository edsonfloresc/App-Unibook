using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Univalle.Fie.Sistemas.Unibook.Common;
using Univalle.Fie.Sistemas.Unibook.UsersBrl;
using UsersBrl;

namespace EntertainmentTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //TEST CATEGORY
            CategoryEnter category = new CategoryEnter() { Description = "Deportes2", Deleted = false };
            ModelUnibookContainer context = new ModelUnibookContainer();
            //INSERT CATEGORY
            CategoryBrl.Insert(category, context);
            //GET A CATEGORY
            CategoryEnter categoryGet = CategoryBrl.Get(1, context);
            //UPDATE CATEGORY
            categoryGet.Description = "Sociales2";
            CategoryBrl.Update(context);
            //DELETE CATEGORY
            CategoryBrl.Delete(2, context);


            //  TEST Entertainment
            Entertainment entertainment = new Entertainment() { Title = "Entretenimiento prueba", PlaceAddress = "canchas de univalle", DateHour = DateTime.Now, Details = "evento para distraccion", Discontinued = false, Deleted = false };
            ModelUnibookContainer contextEntertainment = new ModelUnibookContainer();
            entertainment.CategoryId = CategoryBrl.Get(1, contextEntertainment);
            entertainment.UserId = UserBrl.Get(1, contextEntertainment);
            //INSERT Entertainment
            EntertainmentBrl.Insert(entertainment, contextEntertainment);
            //GET A Entertainment
            Entertainment entertainmentGet = EntertainmentBrl.Get(1, contextEntertainment);
            //UPDATE Entertainment
            entertainmentGet.Details = "Evento privado";
            EntertainmentBrl.Update(contextEntertainment);
            //DELETE Entertainment
            EntertainmentBrl.Delete(2, contextEntertainment);



            //TEST Image
            ImageEnter image = new ImageEnter() { PathImage = "path prueba", Deleted = false };
            ModelUnibookContainer contextImage = new ModelUnibookContainer();
            image.EntertainmentId = EntertainmentBrl.Get(1, contextImage);
            //INSERT Image
            ImageBrl.Insert(image, contextImage);
            //GET A Image
            ImageEnter imageGet = ImageBrl.Get(2, contextImage);
            //UPDATE Image
            imageGet.PathImage = "image2.jpg";
            ImageBrl.Update(contextImage);
            //DELETE Image
            ImageBrl.Delete(1, contextImage);



            //TEST Comment
            CommentEnter comment = new CommentEnter() { CommentText = "comentario de orueba", DateHour= DateTime.Now , Deleted = false };
            ModelUnibookContainer contextComment = new ModelUnibookContainer();
            comment.UserId = UserBrl.Get(1, contextComment);
            comment.EntertainmentId = EntertainmentBrl.Get(1, contextComment);
            //INSERT Image
            CommentBrl.Insert(comment, contextComment);
            //GET A Image
            CommentEnter commentget = CommentBrl.Get(2, contextComment);
            //UPDATE Image
            commentget.CommentText = "comentario cambiado por el update de comentario";
            CommentBrl.Update(contextComment);
            //DELETE Image
            CommentBrl.Delete(2, contextComment);


        }
    }
}
