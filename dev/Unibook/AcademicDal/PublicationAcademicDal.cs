using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Univalle.Fie.Sistemas.Unibook.Common;

namespace Univalle.Fie.Sistemas.UniBook.AcademicDal
{
    public class PublicationAcademicDal
    {
        #region metodos

        /// <summary>
        /// Get publication by id
        /// </summary>
        /// <param name="id">Id publication to search</param>
        /// <returns>Return object publication</returns>
        public static PublicationAcademic Get(long id, ModelUnibookContainer objContex)
        {
            PublicationAcademic publicationAcademicReturn = null;
       
            try
            {
                bool exist = (from publicationAcademic in objContex.PublicationAcademicSet
                              where publicationAcademic.Deleted == false && publicationAcademic.PublicationAcademicId == id
                              select publicationAcademic).Count() > 0;
                if (exist)
                {
                    publicationAcademicReturn = (from publicationAcademic in objContex.PublicationAcademicSet
                                                 where publicationAcademic.Deleted == false && publicationAcademic.PublicationAcademicId == id
                                                 select publicationAcademic).Single<PublicationAcademic>();
                }
                
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

            return publicationAcademicReturn;
        }

        /// <summary>
        /// Insert a publication
        /// </summary>
        /// <param name="publicationAcademic">Object publication to insert</param>
        /// <param name="objContex">Get table to object</param>
        public static void Insert(PublicationAcademic publicationAcademic, ModelUnibookContainer objContex)
        {
            try
            {
                objContex.PublicationAcademicSet.Add(publicationAcademic);
                objContex.SaveChanges();
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
        }

        /// <summary>
        /// Update a publication 
        /// </summary>
        /// <param name="objContex">Get table to object</param> 
        public static void Update(ModelUnibookContainer objContex)
        {
            try
            {
                objContex.SaveChanges();
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
        }

        /// <summary>
        /// Deleted a publication
        /// </summary>
        /// <param name="id">Id publication to deleted</param>
        /// <param name="objContex">Get table to object</param>
        public static void Delete(long id, ModelUnibookContainer objContex)
        {
            try
            {
                PublicationAcademic publicationAcademic = objContex.PublicationAcademicSet.Find(id);
                publicationAcademic.Deleted = true;
                objContex.SaveChanges();
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
        }

        #endregion 
    }
}
