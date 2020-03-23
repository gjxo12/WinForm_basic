using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2_class
{
    public class Customer
    {
        public string Firstname;
        public string Lastname;
        private DateTime birth;
        //private int age;
        private bool chk;
        public string address;
        public string Description;

        private List<Pet> Mypet = new List<Pet>();
        public List<Pet> mypet
        {
            get { return Mypet; }
        }
        public bool Adopt(Pet p)
        {
            if (chk == true)
            {
                mypet.Add(p);
                return true;
            }
            else return false;
        }
        // 부모클래스를 통해 한번에 해결, 자식 클래스로 오든 부모타입으로 
        /*
        private List<Cat> Mycat = new List<Cat>();
        // cumtomer  객체가 생성될때 Cat, Dog 객체도 list로 생성될것.
        public List<Cat> mycat
        {
            get { return Mycat; }
        }

        public bool Adopt(Cat c)
        {
            if (chk == true)
            {
                Mycat.Add(c);
                return true;
            }
            else return false;
        }

        private List<Dog> Mydog = new List<Dog>();

        public List<Dog> mydog
        {
            get { return Mydog; }
        }

        public bool Adopt(Dog c)
        {
            if (chk == true)
            {
                Mydog.Add(c);
                return true;
            }
            else return false;
        }
        */
        public Customer(string Firstname, string Lastname,DateTime birth)
        {
            this.Firstname = Firstname;
            this.Lastname = Lastname;
            this.birth = birth;
            this.chk = Age >= 20;
        }

        public DateTime Birth
        {
            get { return birth; }
            set {
                birth = value;
                chk = Age >= 20;    
            }
        }

        public int Age // 속성처럼 생각
        {
            get { return DateTime.Now.Year - birth.Year; }
            //set
            //{
              //  age = value;
              //  chk = value >= 20;
            //} // value는 매개변수 속성의 타입과 같음
        }
        public bool Chk
        {
            get { return chk; }
            //set이 없으니 읽기전용
        }
        public string Fullname
        {
            get { return Firstname + "  " + Lastname; }
        }


    }
}
