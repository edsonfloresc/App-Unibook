using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Univalle.Fie.Sistemas.UniBook.CommonDto
{
    public class UserDto
    {
       

        public long UserId { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool Deleted { get; set; }
        public virtual RoleDto Role { get; set; }
        public virtual PersonDto Person { get; set; }
       
    }
}
