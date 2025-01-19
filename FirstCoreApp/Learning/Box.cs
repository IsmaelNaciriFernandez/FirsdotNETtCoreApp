using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstCoreApp.Learning
{
    internal class Box
    {
        private float _length;
        private float _height;
        private float _width;
        private float _volume;


        public Box(float length, float height, float width)
        {
            _length = length;
            _height = height;
            _width = width;
            _volume = length * height * width;
        }

        //To round up whilst printing use {Value:0.00}
        public void DisplayInfo()
        {
            Console.WriteLine($"Length: {Length}, Height: {Height}, Width: {Width} \nThe volume is: {Volume}");
        }


        public void RecalculateVolume()
        {
            _volume = Width * Height * Length;
        }


        public float Length
        {
            get => _length;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Length should be higher than 0");
                } else
                {
                    _length = value;
                }
                
            }
        }

        public float Height
        {
            get => _height; 
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Height should be higher than 0");
                } else
                {
                    _height = value;
                }
            }
        }

        public float Width
        {
            get => _width; 
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Width should be higher than 0");
                } else
                {
                    _width = value;
                }
            }
        }

        public float Volume { get => _volume; }
    }
}
