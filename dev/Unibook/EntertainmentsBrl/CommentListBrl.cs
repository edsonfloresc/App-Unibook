using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Univalle.Fie.Sistemas.Unibook.EntertainmentsDal;
using Univalle.Fie.Sistemas.Unibook.Common;
using System.Data.Entity.Validation;


namespace Univalle.Fie.Sistemas.Unibook.EntertainmentsBrl
{
    public class CommentListBrl
    {
        #region metodo
        public static List<CommentEnter> Get(ModelUnibookContainer objContex)
        {
            try
            {
                return CommentListDal.Get(objContex);
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
        #endregion
    }
}
