using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalInfoLibrary
{
    public class PersonalInformation
    {   //properties
        private string _name; 
        private string _address;
        private int _age;
        private string _number;
        public PersonalInformation() // Default constructor
        {

        }
        public PersonalInformation(string name, string address, int age, string number) // constructor using all properties
        {
            Name = name;
            Address = address;
            Age = age;
            Number = number;
        }
        public string Name  // getters and setters 
        {
            get { return _name; }
            set { _name = value; }
        }
        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }
        public string Number
        {
            get { return _number; }
            set { _number = value; }
        }
    }
}
