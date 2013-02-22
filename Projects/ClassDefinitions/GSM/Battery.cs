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

        public Battery(string Model)
        {
            this.model = Model;
        }

        public int HoursIdle
        {
            get { return this.hoursIdle; }
            set { this.hoursIdle = value; }
        }

    }
}
