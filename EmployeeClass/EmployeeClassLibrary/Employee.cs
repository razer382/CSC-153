using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeClassLibrary
{
    public class Employee
    {
        private string _name;       // fields/properties
        private string _idNum;
        private string _department;
        private string _position;

        public Employee()   //default constructor
        {
            Name = "";
            IdNumber = "0";
            Department = "";
            Position = "";
        }
        public Employee(string name, string id, string department, string position) //constructor using all properties
        {
            Name = name;
            IdNumber = id;
            Department = department;
            Position = position;
        }
        public Employee(string name, string id) //constructor assigning name and ID. rest is blank
        {
            Name = name;
            IdNumber = id;
            Department = "";
            Position = "";
        }

        public string Name // getters setters
        {
            get { return _name; }
            set { _name = value; }
        }
        public string IdNumber
        {
            get { return _idNum; }
            set { _idNum = value; }
        }
        public string Department
        {
            get { return _department; }
            set { _department = value; }
        }
        public string Position
        {
            get { return _position; }
            set { _position = value; }
        }
    }
}
