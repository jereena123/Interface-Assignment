using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2_Interface
{
    public class MyAnimals : Animals, IMammals
    {
        private int _bodyTemp;

        // Property BodyTemp with get/set accessors
        public int BodyTemp
        {
            get => _bodyTemp;
            set => _bodyTemp = value;
        }

        public int GetBodyTemp(string _mammals)
        {
            return _bodyTemp;
        }

        // Implement the abstract method from Animals
        public override void SaySomething()
        {
            Console.WriteLine("I am an animal.");
        }

    }
}