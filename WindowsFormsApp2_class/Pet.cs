using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2_class
{
    public class Pet
    {
        public int PetId;
        public string name;
        public string color;
        public string gender;
        public string description;

        public Pet(int PetId, string name, string color, string gender)
        {
            this.PetId = PetId;
            this.name = name;
            this.color = color;
            this.gender = gender;
        }
        public virtual string Sound() { return ""; }
        
    }
}
