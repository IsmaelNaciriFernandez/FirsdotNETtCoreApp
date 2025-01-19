using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace FirstCoreApp.Learning
{
    internal class Members
    {
        //member - private field
        private string _memberName;
        private string _jobTitle;
        private float _salary;

        //member - public field
        public byte age;

        //member constructor
        public Members()
        {
            age = 30;
            _memberName = "Lucy";
            _jobTitle = "Developer";
            _salary = 40_000;
        }


        // member - public method
        public void Introduce(bool isFriend)
        {
            if (isFriend) {
                SharePrivateInfo();
            } 
            else
            {
                Console.WriteLine($"Hi my name is {MemberName}, and my job title is {JobTitle}. I'm {age} years old.");
            }
        }

        private void SharePrivateInfo()
        {
            Console.WriteLine($"My salary is {_salary}");
        }


        //member - property - exposes _jobTitle safely
        public string JobTitle
        {
            get => _jobTitle;
            set
            {
                _jobTitle = value;
            }
        }

        public string MemberName { 
            get => _memberName; 
            set
            {
                _memberName = value;
            }
        }

        public float Salary {
            get => _salary;
            set
            {
                _salary = value;
            }
        }

        //member - finalizer - destructor (cannot be defined in structs, only possible in classes) (only use them if there's a point)
        ~Members() 
        {
            //cleanup statements
            Console.WriteLine($"Deconstruction of member object");
            Debug.Write($"Deconstruction of member object");
        }
    }
}
