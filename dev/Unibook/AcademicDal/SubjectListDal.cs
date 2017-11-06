using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Univalle.Fie.Sistemas.UniBook.Common;

namespace Univalle.Fie.Sistemas.UniBook.AcademicDal
{
    public class SubjectListDal
    {
        /// <summary>
        /// Get list subjects
        /// </summary>
        /// <param name="objContex">Get table to object</param>
        /// <returns></returns>
        public static List<Subject> Get(ModelUnibookContainer objContex)
        {
            List<Subject> subjectsReturn = null;

            try
            {
                subjectsReturn = (from subject in objContex.SubjectSet
                                               where subject.Deleted == false
                                               select subject).ToList<Subject>();
            }
            catch (DbEntityValidationException ex)
            {
                System.Diagnostics.Trace.Write(string.Format("{0} {1} Error: {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ex.Message));
                throw ex;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Trace.Write(string.Format("{0} {1} Error: {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ex.Message));
                throw ex;
            }

            return subjectsReturn;
        }
    }
}
