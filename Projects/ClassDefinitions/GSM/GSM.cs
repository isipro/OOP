using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSM
{

    //Task3: Add an enumeration BatteryType (Li-Ion, NiMH, NiCd, …)
    public enum BatteryType 
    {
        LiIon, NiMH, NiCd
    }

    class GSM
    {
        // Task1 "..holds information about a mobile phone device: model, manufacturer, price, owner,

        private string model = null;
        private string manufacturer = null;
        private decimal price = 0.0m;
        private string owner = null;

        Battery Battery;
        Display Display;

        //Task3:
        BatteryType BatteryType = 0;


        //Task2: "Define several constructors for the defined classes that take different sets of 
        //arguments (the full information for the class or part of it). Assume that model and manufacturer
        //are mandatory (the others are optional). All unknown data fill with null. "

        public GSM(string Model, string Manufacturer)
        {
            this.model = Model;
            this.manufacturer = Manufacturer;
        }

        public GSM(string Model, string Manufacturer, decimal Price)
        {
            this.model = Model;
            this.manufacturer = Manufacturer;
            this.price = Price;
           
        }

        public GSM(string Model, string Manufacturer, decimal Price, string Owner)
        {
            this.model = Model;
            this.manufacturer = Manufacturer;
            this.price = Price;
            this.owner = Owner;
        }

        //Task4: Add a method in the GSM class for displaying all
        //information about it. Try to override ToString()

        public override string ToString()
        {
            StringBuilder toString = new StringBuilder();
            toString.AppendLine("#######GSM#######");
            toString.AppendLine("#Model: " + this.model + " | #Manufacturer: " + this.manufacturer);
            toString.AppendLine("#Owner: " + this.owner + " | #Price: " + this.price);

            if (this.Battery != null)
            {
                toString.AppendLine("###Battery Characteristics: " + this.model);
                toString.AppendLine("#Battery hours talk time: " + this.Battery.HoursIdle);
                toString.AppendLine("#Battery hours talk time: " + this.Battery.HoursTalk);

            }

            if (this.Display != null)
            {
                toString.AppendLine("###Diplay Characteristics");
                toString.AppendLine("# size: " + this.Display.size); //inaccessible due to protection level
                toString.AppendLine("# colors: " + this.Display.colors); //inaccessible due to protection level
            }

            return base.ToString();
        }


        static void Main()
        {
        }
    }
}
