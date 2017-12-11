using ForumDal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Univalle.Fie.Sistemas.Unibook.Common;
using Univalle.Fie.Sistemas.UniBook.CommonDto;
using Univalle.Fie.Sistemas.UniBook.UsersBrl;

namespace ForumBrl
{
    public class QuestionsBrl
    {
        /// <summary>
        /// Get a question with identifier
        /// </summary>
        /// <param name="id"></param>
        /// <param name="objContex"></param>
        /// <returns></returns>
        public static Questions Get(long id, ModelUnibookContainer objContex)
        {
            Questions questions = null;
            try
            {
                questions = QuestionsDal.Get(id, objContex);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return questions;
        }

        /// <summary>
        /// Get a questions with identifier
        /// </summary>
        /// <param name="id"></param>
        /// <param name="objContex"></param>
        /// <returns></returns>
        public static QuestionsDto GetDto(long id, ModelUnibookContainer objContex)
        {
            QuestionsDto questionsDto = null;
            try
            {
                Questions questions = QuestionsDal.Get(id, objContex);
                questionsDto = new QuestionsDto();
                questionsDto.QuestionsId = questions.QuestionsId;
                questionsDto.Title = questions.Title;
                questionsDto.Content = questions.Content;
                questionsDto.Points = questions.Points;
                questionsDto.Solved = questions.Solved;
                questionsDto.Deleted = questions.Deleted;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return questionsDto;
        }

        /// <summary>
        /// Update changes in the context
        /// </summary>
        /// <param name="role"></param>
        /// <param name="objContex"></param>
        public static void Update(QuestionsDto questionsDto, ModelUnibookContainer objContex)
        {
            try
            {
                Questions questions = QuestionsBrl.Get(questionsDto.QuestionsId, objContex);
                questions.QuestionsId = questions.QuestionsId;
                questions.Title = questions.Title;
                questions.Content = questions.Content;
                questions.Points = questions.Points;
                questions.Solved = questions.Solved;
                questions.Deleted = questions.Deleted;
                QuestionsDal.Update(questions, objContex);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Create a new questions
        /// </summary>
        /// <param name="role"></param>
        /// <param name="objContex"></param>
        public static void Insert(QuestionsDto questionsDto, ModelUnibookContainer objContex)
        {
            try
            {
                Questions questions = new Questions();
                questions.Title = questionsDto.Title;
                questions.Content = questionsDto.Content;
                questions.Points = questionsDto.Points;
                questions.Solved = questionsDto.Solved;
                questions.Deleted = questionsDto.Deleted;
                questions.User = UserBrl.Get(1, objContex);
                questions.Category = CategoryBrl.Get(1, objContex);
                QuestionsDal.Insert(questions, objContex);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
