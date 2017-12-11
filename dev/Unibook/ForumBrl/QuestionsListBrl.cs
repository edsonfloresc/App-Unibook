using ForumDal;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Univalle.Fie.Sistemas.Unibook.Common;
using Univalle.Fie.Sistemas.UniBook.CommonDto;

namespace ForumBrl
{
    public class QuestionsListBrl
    {
        /// <summary>
        /// Get list gender 
        /// </summary>
        /// <param name="objContex">Get table to object</param>
        /// <returns></returns>
        public static List<QuestionsDto> Get(ModelUnibookContainer objContex)
        {
            try
            {
                List<QuestionsDto> questionsList = new List<QuestionsDto>();
                foreach (var item in QuestionsListDal.Get(objContex))
                {
                    QuestionsDto question = new QuestionsDto()
                    {
                        QuestionsId = item.QuestionsId,
                        Title = item.Title,
                        Content = item.Content,
                        Points = item.Points,
                        Solved = item.Solved,
                        Deleted = item.Deleted
                    };
                    questionsList.Add(question);
                }

                return questionsList;
            }
            catch (DbEntityValidationException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
