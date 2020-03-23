using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2_class
{
    public enum DogBread { Jindo, Mixed, Malti, Fome}


    public class Dog : Pet
    {
        //public int PetId;
        //public string name;
        //public string color;
        //public string gender;
        //public string description;
        public DogBread bread;

        public Dog(int PetId,string name, string color, string gender, DogBread bread)
            :base(PetId,name,color,gender)
        {
            //PetId = PetId;
            //name = name;
            //color = color;
            //gender = gender;
            bread = bread;
        }
        public override string Sound() { return "왈왈!"; }
        public string Bite() { return "물기!"; }
    }
}
