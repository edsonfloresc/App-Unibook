
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonDto
{
    public class LostObjectDto
    {
        public int LostObjectId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public System.DateTime LostDate { get; set; }
        public string DisplayTime { get; set; }

    }
}
