using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2_Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of MyAnimals
            Console.WriteLine("Enter a mammal type:");
            string mammalType = Console.ReadLine(); // Accept user input for mammal type (not used in this example)

            MyAnimals myAnimal = new MyAnimals
            {
                BodyTemp = 37 // Set some value for BodyTemp
            };

            // Call the SaySomething method
            myAnimal.SaySomething();

            // Call the GetBodyTemp method and display the result
            // Passing the required string parameter
            int temp = myAnimal.GetBodyTemp(mammalType);
            Console.WriteLine($"Body Temperature: {temp}");

            // Keep the console window open
            Console.ReadKey();
        }

    }

}
