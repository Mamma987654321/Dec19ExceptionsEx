using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dec19ExceptionsEx
{
    public class Student
    {//Example of method overloading
        int sId, sNo;
        string fName, lName, Name, Addr;// are accessibe to any method in class 
        public void StudentDetails() { Console.WriteLine("no parameter"); }  //which has no parameter
        public void StudentDetails(int id, int sno, string fname, string lname)
        {
            this.sId = id;
            this.sNo = sno;
            this.fName = fname;
            this.lName = lname;
        }
      
        public void StudentDetails(int id) { this.sId = id; }
        public void StudentDetails(int id, string name, string addr) { 
            this.sId = id;
            this.Name = name;
            this.Addr = addr;
        }
        public void Display()
        {
            //  int num1 = Console.ReadLine();
            Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}\t{5}", this.sId, this.Name, this.Addr, this.sNo, this.fName, this.lName);
           // int x = 10 * 20;// 30 is ans , we get 200
        }

    }
}
