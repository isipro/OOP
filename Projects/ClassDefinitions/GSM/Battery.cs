using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSM
{
    class Battery
    {
        //battery characteristics (model, hours idle and hours talk)

        private string model = null;
        private int hoursIdle = 0;
        private int hoursTalk = 0;

        //Task2: "Define several constructors for the defined classes

        public Battery(string Model, int HoursIdle, int HoursTalk)
        {
            this.model = Model;
            this.hoursIdle = HoursIdle;
            this.hoursTalk = HoursTalk;
        }

        public Battery(string Model) : this(Model, 0, 0) { }

        public Battery(string Model, int HoursIdle) : this(Model, HoursIdle, 0) { }

        public Battery(string Model, int HoursIdle, int HoursTalk) : this(Model, HoursIdle, HoursTalk) { }

        public int HoursIdle
        {
            get { return this.hoursIdle; }
            set { this.hoursIdle = value; }
        }

        public int HoursTalk
        {
            get { return this.hoursTalk; }
            set { this.hoursTalk = value; }
        }
    }
}
