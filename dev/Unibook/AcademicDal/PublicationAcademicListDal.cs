using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Univalle.Fie.Sistemas.UniBook.Common;

namespace Univalle.Fie.Sistemas.UniBook.AcademicDal
{
    public class PublicationAcademicListDal
    {
        /// <summary>
        /// Get list publications
        /// </summary>
        /// <param name="objContex">Get table to object</param>
        /// <returns></returns>
        public static List<PublicationAcademic> Get(ModelUnibookContainer objContex)
        {
            List<PublicationAcademic> publicationsAcademicsReturn = null;

            try
            {
                publicationsAcademicsReturn = (from publicationAcademic in objContex.PublicationAcademicSet
                                  where publicationAcademic.Deleted == false
                                  select publicationAcademic).ToList<PublicationAcademic>();
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

            return publicationsAcademicsReturn;
        }
    }
}
