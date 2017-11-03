﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Univalle.Fie.Sistemas.Unibook.Common;
namespace Univalle.Fie.Sistemas.Unibook.CommonDto
{
    public class ImageNewsDto
    {
        public int ImageId { get; set; }
        public string PathImage { get; set; }
        public bool Deleted { get; set; }

        public virtual News News { get; set; }
    }
}
