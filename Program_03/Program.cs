using System;

class Program
{
    static void Main(string[] args)
    {
        Queue<string> book = new Queue<string>();
        bool checks = true;
        string name;
        while(checks == true)
        {         
            name = Console.ReadLine();
            for (int i = 0; i < book.GetLength();i++)
            {
                if (name == book.Get(i))
                {
                    Console.WriteLine("Name Same");
                    name = Console.ReadLine();                 
                }
            }
            for (int i = 0; i < book.GetLength();i++)
            {
                if (name == book.Get(i))
                {
                    Console.WriteLine("Name Same");
                    name = Console.ReadLine();                 
                }
            }
            if(name == "Exit")
            {
                checks = false;
            }
            else 
            {
                if(book.GetLength() > 2)
                {
                    book.Pop();
                }
                book.Push(name);
            }
        }
        for (int i = 0; i < 3;i++)
        {
            Console.WriteLine(book.Get(i));
        }
    }
    
}
