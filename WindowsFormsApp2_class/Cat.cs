using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2_class
{
    public class Cat : Pet
    {
        //public int PetId;
        //public string name;
        //public string color;
        //public string gender;
        //public string description; 부모에서 다 물려받음

        public Cat(int PetId,string name, string color,string gender)
            :base(PetId,name,color,gender) //자식이 호출될때 부모 생성자가 먼저 호출, 부모클래스의 어떤 생성자를 호출하는지 명시해야함
        {
            //PetId = PetId;
            //name = name;
            //color = color;
            //gender = gender;
        }
        public override string Sound() { return "야옹"; }
        public string scratch() { return "할퀴기!"; }

    }
}
