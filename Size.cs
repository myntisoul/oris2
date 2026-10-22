using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oris2
{
    public class Size
    {
        public int height {  get; set; }
        public int width { get; set; }
        public int length { get; set; }
        public Size(int height, int width, int length)
        {
            this.height = height;
            this.width = width;
            this.length = length;
        }
    }
}
