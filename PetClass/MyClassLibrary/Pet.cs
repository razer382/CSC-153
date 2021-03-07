using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassLibrary
{
    public class Pet
    {   // Fields
        private string _petName; 
        private string _petType;
        private string _petAge;

        public Pet()
        {  // Default Constructor
            PetName = "";
            PetType = "";
            PetAge = "";
        }
        public Pet(string name, string type, string age)
        {  // Constructor using all fields (not used)
            PetName = name;
            PetType = type;
            PetAge = age;
        }
        public string PetName //Getters and setters
        {
            get
            {
                return _petName;
            }
            set
            {
                _petName = value;
            }
        }
        public string PetType 
        {
            get
            {
                return _petType;
            }
            set
            {
                _petType = value;
            }
        }
        public string PetAge 
        {
            get
            {
                return _petAge;
            }
            set
            {
                _petAge = value;
            }
        }

    }
}
