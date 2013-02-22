using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSM
{
    class Display
    {
        private int size;
        private int colors;

        public int Size();
        
        public int Size
        {
            get { return this.size;}
            set { this.size = value; }
        }

        public int Colors
        {
            get { return this.colors; }
            set { this.colors = value; }
        }
    }
}
