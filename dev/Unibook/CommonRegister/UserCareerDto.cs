using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Univalle.Fie.Sistemas.UniBook.CommonDto
{
    public class UserCareerDto
    {
        public long UserCareerId { get; set; }

        public UserDto User { get; set; }
        public CareerDto Career { get; set; }
    }
}
