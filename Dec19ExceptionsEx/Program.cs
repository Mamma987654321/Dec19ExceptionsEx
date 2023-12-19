using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dec19ExceptionsEx
{
    internal class Program
    {
        public static string  Msg()
        {
            string s = "Good Morining";
           // Console.WriteLine(s);
            return s;
        }
        static void Main(string[] args)
        {//..
         // string s = Msg();
         // Console.WriteLine(s);
         // Msg();


            Student s = new Student();
           // s.StudentDetails();//no parameters
      
             //s.StudentDetails(12, 123456789, "amit", "redy");//4 parameter
           // s.StudentDetails(20, "amit", "hyd");
           // s.StudentDetails(18);//
           // s.Display();
            Console.ReadLine();


        }
    }
}
