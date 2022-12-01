using System;
using System.Diagnostics;

namespace EMP
{
    //.NEt is a framework to develop software application
    //framework contains large number of class libraries

    //CLR-it is a program excution engine that loads and excute the program.
    //JIT
    //Access modifiers-
    //public,private,protected,internal
    internal class Program
    {
        static void Main(string[] args)
        {
            int fullTime = 1;
            Random randobj = new Random();
            int checkPresent = randobj.Next(0, 2);
            Console.WriteLine("Random number="+checkPresent);
            if(checkPresent == fullTime)
            {
                Console.WriteLine("Employee is present");
            }
            else
            {
                Console.WriteLine("Employee is absent");
            }
        }
    }
}
