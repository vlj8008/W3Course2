using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace W3Course2
{
    class Program
    {
        static void MyMethod()
        {
            Console.WriteLine("I just got executed");
        }

        // Using Parameters

        static void FullName(string fName, string lName)
        {
            Console.WriteLine("Hello " + fName + " " + lName);
        }

        // Using default parameter values

        static void MyCountryMethod(string country = "Australia") // also called optional parameter
        {
            Console.WriteLine("The country where you live is " + country);
        }

        // Multiple parameters

        static void NameAndAge(string Name, int Age)
        {
            Console.WriteLine($"Hello {Name}, you are {Age} years old");
        }

        // Returning a value (use primitive datatype instead of "void" keyword)

        static int AddingMethod(int x, int y)
        {
            return x + y;
           
        }

        //Overloading methods

        static int PlusMethod(int x, int y)
        {
            return x + y;
        }

        static double PlusMethod(double x, double y)
        {
            return x + y;
        }

        






        static void Main(string[] args)
        {
            Console.WriteLine("hello");
            MyMethod();

            FullName("Vicky", "Jones");

            MyCountryMethod(); //output "Australia" as it is set to default
            MyCountryMethod("Israel"); // output "Israel as it overides default

            NameAndAge("Nerrida", 12);

            int result = AddingMethod(2, 2);
            Console.WriteLine(result);

            int myNum1 = PlusMethod(8, 5);
            double myNum2 = PlusMethod(4.3, 6.26);
            Console.WriteLine("Int: " + myNum1);
            Console.WriteLine("Double: " + myNum2);

            // Creating an object from the car class

            Car myFirstCar = new Car();// Specify class name, then my own name, then "new" keyword.
            Console.WriteLine(myFirstCar.color);
            myFirstCar.Pin = 5555;
            Console.WriteLine(myFirstCar.Pin);

            Car mySecondCar = new Car();
            Console.WriteLine(mySecondCar.maxSpeed);

            Car myThirdCar = new Car();
            myThirdCar.minSpeed = 2;
            Console.WriteLine(myThirdCar.minSpeed);

            // Creating multiple objects of one class

            MotorBikes bike1 = new MotorBikes();
            bike1.color = "black";
            bike1.model = "Kawasaki";
            bike1.year = 2021;
            int y = bike1.SerialNum = 4444;

            Console.WriteLine(y);

            MotorBikes bike2 = new MotorBikes();
            bike2.year = 2000;
            bike2.honk();
            bike2.caseMaterial = "plastic";
            Console.WriteLine(bike2.caseMaterial);

            Console.WriteLine(bike1.year);
            Console.WriteLine(bike2.year);
            Console.WriteLine(bike2.model);

            myFirstCar.fullThrottle();
            bike2.MotorBikeSound();

            Truck myFirstTruck = new Truck("Kenwood", "Black", 2001, 12);
            Console.WriteLine(myFirstTruck.wheels);

            Truck mySecondTruck = new Truck("Toyota");
            Console.WriteLine(mySecondTruck.model);
            Console.WriteLine(mySecondTruck.wheels);

            Truck myThirdTruck = new Truck("Nissan");
            int x = myThirdTruck.Pin = 023145;
            Console.WriteLine(x);




            Console.ReadKey();

            

            
        }
    }
}
