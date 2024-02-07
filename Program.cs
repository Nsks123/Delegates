using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public delegate void adddelegate(int x, int y);
    public delegate string addstring(string A, string B);
    class program
    {
        public void addnums(int x, int y)
        {
            Console.WriteLine(x + y);
        }
        public static string addstrings(string A, string B)
        {
            return A + B;

        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
                program d = new program();

                adddelegate ad = new adddelegate(d.addnums);
                ad(2,3);
                addstring b = new addstring(program.addstrings);
                string str = program.addstrings("sunil" , "kumar");
                Console.WriteLine(str);
        }
    }
}
