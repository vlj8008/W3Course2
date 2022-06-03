using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W3Course2
{
    class Truck
    {

        //NB. C# default if you don't add access modifier is private. 
        public string model;
        public string color;
        public int year;
        public int wheels;
        private int pin; //private field as has sensitive data. 

        public int Pin //property (combination of field and method).
                       //Here is long hand way of accessing private field. 
                       //Naming convention, same name as field but capitalized.
                        
        {
            get { return pin; }
            set { pin = value; }
        }

        public void TruckSound()
        {
            Console.WriteLine("Trucks go rooom rooom rooom");
        }

        public Truck(string modelName,string modelColor, int modelYear, int modelWheels)
        {
            model = modelName;
            color = modelColor;
            year = modelYear;
            wheels = modelWheels;
        }

        public Truck(string modelName)
        {
            model = modelName;
        }


    }
}
