
using System;

class GFG
{

    public delegate void petanim(string pet);

    
    static public void Main()
    {

        
        petanim p = delegate (string mypet)
        {
            Console.WriteLine("My favorite pet is: {0}",
                                                mypet);
        };
        p("Dog");
    }
}
