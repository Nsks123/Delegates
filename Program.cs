using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public delegate void rectdelegate(double width, double height);
   
    class program
    {
        public void getarea(double width, double height)
        {
            Console.WriteLine(width + height);
        }
        public  void getperimeter(double width, double height)
        {
            Console.WriteLine(2*(width + height));


        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
                program d = new program();
            rectdelegate obj = new rectdelegate(d.getarea);
            obj = obj + d.getperimeter;
            obj.Invoke(12.34, 56.78);
            obj.Invoke(14.50, 60.78);
                

                
        }
    }
}
