using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W3Course2
{
    class MotorBikes:Vehicle
    {
        public string model;
        public string color;
        public int year;
        private int serialNum;

        public int SerialNum 
        {
            get { return serialNum; }
            set { serialNum = value; }
        }

        public MotorBikes() // constructor (must match the name of the class). All classes have 
        // constructors by default. If I don't create a constructor myself, C# creates one for me. 
        {
            model = "Kawasaki";
        }

        public void MotorBikeSound() //public method can only be accessed by creating an object. 
        {
            Console.WriteLine("Motor bikes go Brmmmm Brmmmmm");
        } 

    }
}
