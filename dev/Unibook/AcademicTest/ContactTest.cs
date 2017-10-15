using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Univalle.Fie.Sistemas.Unibook.Common;
using Univalle.Fie.Sistemas.UniBook.AcademicBrl;

namespace AcademicTest
{
    class ContactTest
    {
        static void Main(string[] args)
        {
            Contact contact = new Contact() { Data = "PruebaTestContact", Description = "DescriptionPruebaTest", Deleted = false};
            ModelUnibookContainer Objectcontext = new ModelUnibookContainer();
            contact.Person = PersonBrl.Get(1, Objectcontext);
            ContactBrl.Insert(contact, Objectcontext);

            Contact contactGet = ContactBrl.Get(1, Objectcontext);
            contactGet.Data = "PruebaTestUpdate";
            ContactBrl.Update(Objectcontext);

            ContactBrl.Delete(1, Objectcontext);
        }
    }
}
