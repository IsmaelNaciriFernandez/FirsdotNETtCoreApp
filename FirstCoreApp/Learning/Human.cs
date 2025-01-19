using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstCoreApp.Learning
{
    internal class Human
    {
        internal enum _Gender
        {
            Male = 'M',
            Female = 'F'
        }
        
        private string _firstName;
        private string _lastName;
        private string _eyeColor;
        private byte _age;
        private _Gender _gender;


        public Human()
        {
            Console.WriteLine("Empty object for now!");
        }

        public Human(string firstName, string lastName, string eyeColor, byte age, _Gender gender)
        {
            _firstName = firstName;
            _lastName = lastName;
            _eyeColor = eyeColor;
            _age = age;
            _gender = gender;
        }

        public Human(string firstName, string lastName, string eyeColor, _Gender gender)
        {
            _firstName = firstName;
            _lastName = lastName;
            _eyeColor = eyeColor;
            _gender = gender;
        }

        public Human(string firstName, string lastName)
        {
            _firstName = firstName;
            _lastName = lastName;
        }


        public void Introduction()
        {
            Console.WriteLine($"Hi, I'm {FirstName} {LastName}, I'm a {Age} {(Gender == _Gender.Male ? "Man" : "Woman" )} and I have {EyeColor} eyes");
        }
        



        public string FirstName
        {
            get => _firstName;
            set => _firstName = value;
        }

        public string LastName
        {
            get => _lastName;
            set => _lastName = value;
        }

        public string EyeColor
        {
            get => _eyeColor;
            set => _eyeColor = value;
        }

        public byte Age
        {
            get => _age;
            set => _age = value;
        }

        public _Gender Gender
        {
            get => _gender;
            set => _gender = value;
        }

    }
}
