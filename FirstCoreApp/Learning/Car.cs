using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstCoreApp.Learning
{
    internal class Car
    {
        private string _name;
        private int _horsePower;
        private byte _wheelAmount;
        
        public string Name { 
            get => _name; 
            set => _name = value ?? "Unknown"; 
        }
        
        public int HorsePower
        {
            get => _horsePower;
            set 
            { 
                if (value > 0)
                {
                    _horsePower = value;
                } 
                else
                {
                    throw new ArgumentException("HorsePower must be greater than 0");
                }
            }
        }

        public byte WheelAmount
        {
            get => _wheelAmount;
            set
            {
                if (_wheelAmount > 0)
                {
                    _wheelAmount = value;
                }
                else
                {
                    throw new ArgumentException("There are no cars with 0 or less wheels");
                }
            }
        }
        //Lumen
        //Doors


        public Car(string name, int horsePower, byte wheelAmount) 
        {
            _name = name;
            _horsePower = horsePower;
            _wheelAmount = wheelAmount;
        }

        public void DisplayCarDetails()
        {
            Console.WriteLine($"| Name: {Name} |\n| Horse Power: {HorsePower} |\n| Amount of Wheels: {WheelAmount} |\n");
        }
        
        private void OpenWindow()
        {
            Console.WriteLine("Windows oppened");
        }
        
    }
}
