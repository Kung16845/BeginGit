using System;

class Program
{
    static void Main(string[] args)
    {
        Stack<string> A = new Stack<string>();
        bool c = true;
        int a = 0,b = 0;
        string n;
        while (c == true)
        {
            n = Console.ReadLine();
            if(n == "(" || n == ")")
            {
                A.Push(n); 
            }
            else 
            {
                c = false;
            }
        }

        for(int i = 0;i < A.GetLength();i++)
        {
            if (A.Get(i) == "(" )
            {
                a++;
            }
            if (A.Get(i) == ")")
            {
                b++;
            }
        }

        if (a == b)
        {
            Console.WriteLine("Valid");
        }
        else 
        {
            Console.WriteLine("Invalid");
        }
    }
}