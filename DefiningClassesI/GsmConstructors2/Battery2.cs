using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSM
{

    //public enum BatteryType
    //{
    //    LiIon, NiMH, NiCd
    //}

    class Battery
    {
        private string model;
        private int hoursIdle;
        private int hoursTalk;
        //public BatteryType batType;

        // constructors  - changed
        public Battery(string model)
        {
            this.model = model;
        }

        public Battery(string model, int hoursIdle, int hoursTalk )
        {
            this.model = model;
            this.hoursIdle = 0;
            this.hoursTalk = 0;
        }

        //public BatteryType
        //{
        //    get {return batType;}
        //}

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
