using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Univalle.Fie.Sistemas.Unibook.Common;

namespace ForumDal
{
    public class QuestionsDal
    {
        /// <summary>
        /// Get question by id
        /// </summary>
        /// <param name="id">Id gender to search</param>
        /// <returns></returns>
        public static Questions Get(long id, ModelUnibookContainer objContex)
        {
            Questions categoryReturn = null;

            try
            {
                categoryReturn = (from question in objContex.Questions
                                  where question.QuestionsId == id
                                  select question).Single<Questions>();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Trace.Write(string.Format("{0} {1} Error: {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ex.Message));
                categoryReturn = null;
            }

            return categoryReturn;
        }

        /// <summary>
        /// Insert a question
        /// </summary>
        /// <param name="role"></param>
        /// <param name="objContex"></param>
        public static void Insert(Questions question, ModelUnibookContainer objContex)
        {
            try
            {
                objContex.Questions.Add(question);
                objContex.SaveChanges();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Trace.Write(string.Format("{0} {1} Error: {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ex.Message));
                throw ex;
            }
        }

        /// <summary>
        /// Update a question
        /// </summary>
        /// <param name="role"></param>
        /// <param name="objContex"></param>
        public static void Update(Questions question, ModelUnibookContainer objContex)
        {
            try
            {
                objContex.SaveChanges();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Trace.Write(string.Format("{0} {1} Error: {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ex.Message));
                throw ex;
            }
        }
    }
}
