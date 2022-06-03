using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W3Course2
{
    class Car
    {
      
        public string color = "blue"; //NB. this is called a "field" or attribute
        public int maxSpeed = 100;
        public int minSpeed;
        public int Pin { get; set; }


        public void fullThrottle() // method
        {
            Console.WriteLine("You are going as fast as you can");
        }
        
    
    }
}
