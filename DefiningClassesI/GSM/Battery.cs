using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSM
{
    class Battery
    {
        private string model;
        private int hoursIdle;
        private int hoursTalk;

        public string Model
        {
            get { return this.model; }
            set { this.model = value; }
        }

        public int HoursIdle
        {
            get { return this.hoursIdle; }
            set { this.hoursIdle = value; }
        }
        public int HoursTalk
        {
            get { return this.hoursIdle; }
            set { this.hoursIdle = value; }
        }
    }
}
