using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSM
{
    class GSM
    {
        //model, manufacturer, price, owner,

        public Battery Bat = new Battery("Nokia");   ///!!! needs to contain at least models
        public Display Dis = new Display();

        private string model;
        private string manufacturer;
        private decimal price;
        private string owner;

        public GSM(string model, string manufacturer)
        {
            this.model = model;
            this.manufacturer = manufacturer;
            //this.hourIdle = 0;
            //this.hourTalk = 0;
            price = 0.0m;
            owner = null;

        }

        public GSM(string model, string manufacturer, decimal price)
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.price = price;
            
        }

        public GSM(string model, string manufacturer, decimal price, string owner)
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.price = price;
            this.owner = owner;
        }

        public string Model
        {
            get { return this.model; }
            set { this.model = value; }
        }

        public string Manufacturer
        {
            get { return this.manufacturer; }
            set { this.manufacturer = value; }
        }

        

        public decimal Price
        {
            get { return this.price; }
            set { this.price = value; }
        }

        

        public string Owner
        {
            get { return this.owner; }
            set { this.owner = value; }
        }

        static void Main()
        {

        }
    }
}
