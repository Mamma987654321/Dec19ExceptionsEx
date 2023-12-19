using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dec19ExceptionsEx
{
    public class MyOwnError: ApplicationException//:means inheritance

    {// MyOwnError ic child class of applicationException is parent(base) super class
        public void MyOwnER()
        {
            Console.WriteLine("An Exception Happended");
        }
        public void MyOwnDivideByError()
        {
            Console.WriteLine("Exception happened, division should not be zero");

        }
    }//end of class
    public class OwnException
    {
        static void Main(string[] args)
        {
            int n, div, Ans;
            Console.WriteLine("enter a number 0 ");
            div = int.Parse(Console.ReadLine());
            Console.WriteLine("enter a real number");
            n = int.Parse(Console.ReadLine());
            try
            {
                if(div == 0)
                {
                    throw new MyOwnError(); // class name we created like
                    //thow new DIvideByZero

                }
            }
            catch(MyOwnError e) { e.MyOwnDivideByError(); }
            Ans = n /div;
            Console.WriteLine("the ans is  " + Ans);
        }
    }
        
}
