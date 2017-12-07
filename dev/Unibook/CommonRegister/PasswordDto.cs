using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Univalle.Fie.Sistemas.UniBook.CommonDto
{
    public class PasswordDto
    {
        public long PasswordId { get; set; }
        public string Psw { get; set; }
        public DateTime Date { get; set; }
        public byte State { get; set; }
        public string NewPassword { get; set; }
        public long UserId { get; set; }
    }
}
