using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
class GFG
{
    static public void Main()
    {
        List<int> list = new List<int>()
        {
            1,2,3,4,5,6,7,8,9,10,11,12,13,14
        };
        List<int> list2 = list.FindAll(x=>x%2==0);
        foreach (int x in list2)
        {
            Console.WriteLine(x);
        }
        Console.ReadLine();
        


        
       
    }
}
