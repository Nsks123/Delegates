using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
namespace Lambda
{
    public delegate string lambdaexpression(string s1);
    class Lambda
    {

        static public void Main()
        {
            lambdaexpression x = (s1) =>
            {
                return "hi " + s1 + " good morning.";
            };
            string str = x("sunil kumar");
            Console.WriteLine(str);

            Console.ReadLine();





        }
    }
}



