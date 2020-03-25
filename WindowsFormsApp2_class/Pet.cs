using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2_class
{
    public class Pet
    {// Dog와 cat 클래스에서 필요한 기본적인 맴버변수와 메서드를 미리 부모클래스에서 지정
        //아래의 virtual을 사용해 필요한 함수일 때 클래스에 따라 출력 결정
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
