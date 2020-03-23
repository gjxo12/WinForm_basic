using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2_class
{
    public partial class Form1 : Form
    {  
        //public Customer[] arr = new Customer[10];
        public int index = 0;
        
        //List<>로 하는법
        public List<Customer> list = new List<Customer>();

        public Form1()
        {
            InitializeComponent();
        }

        private void QACustomer_Click(object sender, EventArgs e)
        {
            /*
                arr[index] =  new Customer(Tfirstname.Text,Tlastname.Text,
                    DateTime.Parse(TDate.Text));

                arr[index].address = Taddress.Text;
                cdescription.Text = Tdescription.Text;
                index++;
                배열로 하는 법*/

            Customer cus = new Customer(Tfirstname.Text, Tlastname.Text, DateTime.Parse(TDate.Text));
            cus.address = Taddress.Text;
            cdescription.Text = Tdescription.Text;
            //list1.Items.Add(cus.Firstname);
            dataGridView.Rows.Add(cus.Firstname, cus.Age, cus.Chk);
            list.Add(cus);
            //cfirstname.Text = cu.Firstname; 여기는 생성

            Tfirstname.Text = "";
            Tlastname.Text = "";
            Tdescription.Text = "";
            TDate.Text = "";
            Taddress.Text = "";


        }
        public void print(Customer cu)
        {
            cfullname.Text = cu.Fullname;
            cfullname.Text = cu.Lastname;
            cage.Text = cu.Age.ToString();
            caddress.Text = cu.address;
            //bool chk = cu.Chk;
            cchk.Text = cu.Chk.ToString();

            cpat.Text = "";
            foreach(Pet i in cu.mypet)
            {
                cpat.Text += i.name + " : ";
                if (i is Cat) cpat.Text += (i as Cat).scratch();
                else cpat.Text += (i as Dog).Bite();
                cpat.Text += Environment.NewLine;
            }

            //if(cu.mycat != null) cpat.Text = cu.mycat.name + "  " + cu.mycat.Sound() + Environment.NewLine;

            //if (cu.mydog != null) cpat.Text = cu.mydog.name + "  " + cu.mydog.Sound() + Environment.NewLine;
            
        }
        /*
        private void list1_Click(object sender, EventArgs e)
        {
            string fname = list1.SelectedItem.ToString();

            foreach(Customer i in list)
            {
                if(i.Firstname == fname)
                {
                    print(i);
                    break;
                }
            } 

            /* 배열로 하는법
            for(int i = 0; i < index; i++)
            {
                if(arr[i].Firstname == fname)
                {
                    print(arr[i]);
                    break;
                } 
            }
        }*/

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string fname = dataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
            foreach (Customer i in list)
            {
                if (i.Firstname == fname)
                {
                    print(i);
                    break;
                }
            }
            Datapanel1.Show();
            panel1.Hide();
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            datapanal.Dock = DockStyle.Fill;
            panel1.Dock = DockStyle.Right;
            Datapanel1.Dock = DockStyle.Right;

            Customer test = new Customer("HUR", "min", new DateTime(1993, 3, 1));
            Cat cat = new Cat(1, "111", "red", "Man");
            test.Adopt(cat);
            Cat cat2 = new Cat(2, "222", "blue", "Woman");
            test.Adopt(cat2);
            Dog dog = new Dog(3, "333", "black", "Man",DogBread.Jindo);
            test.Adopt(dog);

            list.Add(test);
            dataGridView.Rows.Add(test.Firstname, test.Age, test.Chk);
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            panel1.Show();
            Datapanel1.Hide();


        }
    }
}
