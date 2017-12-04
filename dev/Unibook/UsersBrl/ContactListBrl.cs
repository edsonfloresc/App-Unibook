using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Univalle.Fie.Sistemas.Unibook.Common;
using Univalle.Fie.Sistemas.UniBook.CommonDto;
using Univalle.Fie.Sistemas.UniBook.UsersDal;

namespace Univalle.Fie.Sistemas.UniBook.UsersBrl
{
    public class ContactListBrl
    {
        /// <summary>
        /// Get list comments
        /// </summary>
        /// <param name="objContex">Get table to object</param>
        /// <returns></returns>
        public static List<ContactDto> Get(ModelUnibookContainer objContex)
        {
            try
            {
                List<ContactDto> contactList = new List<ContactDto>();
                foreach (var item in ContactListDal.Get(objContex))
                {
                    contactList.Add(ContactBrl.GetDto(item.ContactId, objContex));
                }

                return contactList;
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
